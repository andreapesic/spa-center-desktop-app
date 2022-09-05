using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControllers
{
    public class UCPretraziObrisiTerminController
    {
        private BindingList<Termin> termini = new BindingList<Termin>();
        private readonly string senderEmail = "andrea.softveri.spacentar@gmail.com";
        private readonly string senderPassword = "dnttozzavgawlqnw";
        private readonly string baseImagePath = @"Resources/";

        internal void PripremiFormu(DataGridView dgvTermini, ComboBox cbKlijentKriterijum)
        {
            try
            {
                UcitajKlijente(cbKlijentKriterijum);
                UcitajTermine(dgvTermini);
                InicijalizujTermine(dgvTermini);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            } 
        }

        internal void UcitajKlijente(ComboBox cbKlijentKriterijum)
        {
            cbKlijentKriterijum.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>(Communication.Operation.VratiListuKlijenata, null);
            cbKlijentKriterijum.SelectedIndex = -1;
            cbKlijentKriterijum.Text = "Odaberite klijenta";
            cbKlijentKriterijum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbKlijentKriterijum.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKlijentKriterijum.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        internal void UcitajTermine(DataGridView dgvTermini)
        {
            termini = new BindingList<Termin>(ServerCommunication.Communication.Instance.
                     SendRequestGetResult<List<Termin>>(Operation.VratiListuTermina, null));
        }

        internal void InicijalizujTermine(DataGridView dgvTermini)
        {
            if (termini == null || termini.Count == 0)
            {
                dgvTermini.DataSource = new BindingList<Usluga>();
            }
            else
            {
                dgvTermini.DataSource = null;
                dgvTermini.DataSource = termini;
                dgvTermini.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvTermini.Columns["SifraKlijenta"].HeaderText = "Klijent";
                dgvTermini.Columns["SifraUsluge"].HeaderText = "Usluga";
                dgvTermini.Columns["DatumVremeTermina"].HeaderText = "Datum i vreme termina";
                dgvTermini.Columns["BrojProstorije"].HeaderText = "Broj prostorije";
                dgvTermini.Columns["KonacnaCena"].HeaderText = "Konacna cena";
            }
        }

        private void IsprazniPolja(ComboBox cbKlijent, ComboBox cbUsluga, ComboBox cbVaucer, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, NumericUpDown nudBrojProstorije, RichTextBox rtbNapomena)
        {
            cbKlijent.SelectedIndex = -1;
            cbKlijent.Text = "";
            cbUsluga.SelectedIndex = -1;
            cbUsluga.Text = "";
            dtpDatum.Text = "";
            txtSati.Text = "";
            txtMinuti.Text = "";
            nudBrojProstorije.Value = 1;
            rtbNapomena.Text = "";
            cbVaucer.SelectedIndex = -1;
            cbVaucer.Text = "";
        }

        internal void PopuniDetalje(DataGridView dgvTermini, ComboBox cbKlijent, ComboBox cbUsluga, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, NumericUpDown nudBrojProstorije, RichTextBox rtbNapomena, ComboBox cbVaucer)
        {
            if (dgvTermini.SelectedRows == null || dgvTermini.SelectedRows.Count == 0 || termini.Count == 0)
            {
                IsprazniPolja(cbKlijent, cbUsluga, cbVaucer, dtpDatum, txtSati, txtMinuti, nudBrojProstorije, rtbNapomena);
                return;
            }

            DataGridViewRow red = dgvTermini.SelectedRows[0];
            Termin termin = (Termin)red.DataBoundItem;

            cbKlijent.Text = termin.SifraKlijenta.ToString();
            cbUsluga.Text = termin.SifraUsluge.ToString();
            DateTime datum = termin.DatumVremeTermina;
            dtpDatum.Value = datum.Date;
            txtSati.Text = datum.Hour.ToString();
            txtMinuti.Text = datum.Minute.ToString().Length == 1 ? "0" + datum.Minute.ToString() : datum.Minute.ToString();
            nudBrojProstorije.Value = termin.BrojProstorije;
            rtbNapomena.Text = termin.Napomena;
            cbVaucer.DataSource = Enum.GetValues(typeof(Vaucer));
            cbVaucer.SelectedItem = termin.Vaucer;
        }

        internal void ObavestiKlijenta(DataGridView dgvTermini)
        {
            if (dgvTermini.SelectedRows == null || dgvTermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali termin o kom zelite da obavestite klijenta!");
                return;
            }

            DataGridViewRow red = dgvTermini.SelectedRows[0];
            Termin termin = (Termin)red.DataBoundItem;

            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail, senderPassword),
                    EnableSsl = true,
                };

                string subject = "Obavestenje o zakazanom terminu u SPA centru";
                string body = "Postovana/i " + termin.SifraKlijenta.Ime + ",<br/>" + 
                    "Podsecamo Vas da je Vas termin za " + "<h3><font color='#f6add0'>" + termin.SifraUsluge.NazivUsluge + "</font></h3>" +
                    " zakazan za " + "<h3><font color='#f6add0'>" + termin.DatumVremeTermina + ".</font></h3>" + "<br/>" + "Vidimo se!";

                var mailMessage = new MailMessage
                {
                    From = new MailAddress(senderEmail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };

                string vaucer = AttachVoucher(termin.Vaucer);

                if(!string.IsNullOrEmpty(vaucer))
                {
                    var attachment = new Attachment(vaucer, MediaTypeNames.Image.Jpeg);
                    mailMessage.Attachments.Add(attachment);
                }

                mailMessage.To.Add(termin.SifraKlijenta.Email);
                smtpClient.Send(mailMessage);
                MessageBox.Show("Klijent je uspesno obavesten o terminu!");

            } 
            catch(Exception)
            {
                MessageBox.Show("Trenutno nije moguce poslati obavestenje klijentu. Pokusajte kasnije.");
            }
        }

        private string AttachVoucher(Vaucer vaucer)
        {
            string slika = "";

            switch(vaucer)
            {
                case Vaucer.BezVaucera:
                    break;
                case Vaucer.Popust10:
                    slika = baseImagePath + "Vaucer10.jpg";
                    break;
                case Vaucer.Popust15:
                    slika = baseImagePath + "Vaucer15.jpg";
                    break;
                case Vaucer.Popust20:
                    slika = baseImagePath + "Vaucer20.jpg";
                    break;
            }

            return slika;
        }

        internal void PretraziTermine(DataGridView dgvTermini, CheckBox chbKlijentKriterijum, CheckBox chbDatumVremeKriterijum, CheckBox chbBrojProstorijeKriterijum, ComboBox cbKlijentKriterijum, DateTimePicker dtpDatumKriterijum, TextBox txtSatiKriterijum, TextBox txtMinutiKriterijum, NumericUpDown nudBrojProstorijeKriterijum)
        {
            string uslov = "";

            if(chbKlijentKriterijum.Checked && ValidationHelper.ComboBoxValidation(cbKlijentKriterijum))
            {
                uslov += $"t.SifraKlijenta={((Klijent)cbKlijentKriterijum.SelectedItem).SifraKlijenta} and ";
            }
            if (chbDatumVremeKriterijum.Checked && ValidationHelper.AppointmentTimeValidation(txtSatiKriterijum, txtMinutiKriterijum))
            {
                int sati = int.Parse(txtSatiKriterijum.Text);
                int minuti = int.Parse(txtMinutiKriterijum.Text);
                DateTime datum = new DateTime(dtpDatumKriterijum.Value.Year, dtpDatumKriterijum.Value.Month,
                    dtpDatumKriterijum.Value.Day, sati, minuti, 0);
                uslov += $"t.DatumVremeTermina='{datum}' and ";
            }
            if(chbBrojProstorijeKriterijum.Checked)
            {
                uslov += $"t.BrojProstorije={(int)nudBrojProstorijeKriterijum.Value} and ";
            }
            
            if(String.IsNullOrEmpty(uslov))
            {
                UcitajTermine(dgvTermini);
                InicijalizujTermine(dgvTermini);
            }
            else
            {
                uslov = uslov.Substring(0, (uslov.Length - 5));

                try
                {
                    Termin termin = new Termin
                    {
                        SearchCondition = uslov
                    };

                    termini = new BindingList<Termin>(ServerCommunication.Communication.Instance.
                        SendRequestGetResult<List<Termin>>(Operation.PretraziTermine, termin));

                    InicijalizujTermine(dgvTermini);
                }
                catch (SystemOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        internal void ObrisiTermin(DataGridView dgvTermini)
        {
            if (dgvTermini.SelectedRows == null || dgvTermini.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali termin za brisanje!");
                return;
            }

            DataGridViewRow red = dgvTermini.SelectedRows[0];
            Termin termin = (Termin)red.DataBoundItem;

            try
            {
                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ObrisiTermin, termin);
                MessageBox.Show("Uspesno ste obrisali termin!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            termini.Remove(termin);
            InicijalizujTermine(dgvTermini);
        }

    }
}
