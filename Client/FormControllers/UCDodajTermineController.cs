using Client.Exceptions;
using Client.FormHelpers;
using Communication;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormControllers
{
    public class UCDodajTermineController
    {
        private BindingList<Termin> termini = new BindingList<Termin>();
        private List<Klijent> klijenti = new List<Klijent>();

        internal void PripremiFormu(ComboBox cbKlijent, ComboBox cbUsluga, ComboBox cbVaucer, DataGridView dgvTermini)
        {
            try
            {
                UcitajKlijente(cbKlijent);
                UcitajUsluge(cbUsluga);
                UcitajVaucere(cbVaucer);
                InicijalizujTermine(dgvTermini);
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce pokrenuti izabranu formu. Pokusajte kasnije.");
                throw;
            }
            
        }
        internal void UcitajKlijente(ComboBox cbKlijent)
        {
            klijenti = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Klijent>>(Communication.Operation.VratiListuKlijenata, null);
            cbKlijent.DataSource = klijenti;
            cbKlijent.SelectedIndex = -1;
            cbKlijent.Text = "Odaberite klijenta";
            cbKlijent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbKlijent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbKlijent.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        internal void UcitajUsluge(ComboBox cbUsluga)
        {
            cbUsluga.DataSource = ServerCommunication.Communication.Instance.SendRequestGetResult<List<Usluga>>(Communication.Operation.VratiListuUsluga, null);
            cbUsluga.SelectedIndex = -1;
            cbUsluga.Text = "Odaberite uslugu";
            cbUsluga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cbUsluga.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbUsluga.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        internal void UcitajVaucere(ComboBox cbVaucer)
        {
            cbVaucer.DataSource = Enum.GetValues(typeof(Vaucer));
            cbVaucer.SelectedIndex = -1;
            cbVaucer.Text = "Odaberite vaucer";
        }

        internal void InicijalizujTermine(DataGridView dgvTermini)
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
        private void IsprazniPolja(ComboBox cbKlijent, ComboBox cbUsluga, ComboBox cbVaucer, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, NumericUpDown nudBrojProstorije, RichTextBox rtbNapomena)
        {
            cbKlijent.SelectedIndex = -1;
            cbKlijent.Text = "Odaberite klijenta";
            cbUsluga.SelectedIndex = -1;
            cbUsluga.Text = "Odaberite uslugu";
            dtpDatum.Text = "";
            txtSati.Text = "";
            txtMinuti.Text = "";
            nudBrojProstorije.Value = 1;
            rtbNapomena.Text = "";
            cbVaucer.SelectedIndex = -1;
            cbVaucer.Text = "Odaberite vaucer";
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

            MessageBox.Show("Termin je obrisan!");
            termini.Remove(termin);          
            InicijalizujTermine(dgvTermini);
        }

        internal void SacuvajTermine(DataGridView dgvTermini, ComboBox cbKlijent, ComboBox cbUsluga, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, NumericUpDown nudBrojProstorije, RichTextBox rtbNapomena, ComboBox cbVaucer)
        {
            try
            {
                if(termini == null || termini.Count == 0)
                {
                    MessageBox.Show("Nema termina za cuvanje!");
                    return;
                }

                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ZapamtiTermine, termini.ToList());
                MessageBox.Show("Uspesno ste sacuvali termine!");
                termini?.Clear();
                InicijalizujTermine(dgvTermini);
                IsprazniPolja(cbKlijent, cbUsluga, cbVaucer, dtpDatum, txtSati, txtMinuti, nudBrojProstorije, rtbNapomena);

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     

        internal void DodajTermin(DataGridView dgvTermini, ComboBox cbKlijent, ComboBox cbUsluga, DateTimePicker dtpDatum, TextBox txtSati, TextBox txtMinuti, NumericUpDown nudBrojProstorije, RichTextBox rtbNapomena, ComboBox cbVaucer)
        {
            if (!ValidationHelper.ComboBoxValidation(cbKlijent) || !ValidationHelper.ComboBoxValidation(cbUsluga))
            {
                return;
            }

            if (!ValidationHelper.AppointmentDateValidation(dtpDatum))
            {
                MessageBox.Show("Datum termina ne moze biti u proslosti!");
                return;
            }

            if (!ValidationHelper.AppointmentTimeValidation(txtSati, txtMinuti))
            {
                MessageBox.Show("Vreme morate uneti u 24-casovnom formatu! Radno vreme SPA centra je od 8-22h.");
                return;
            }

            if (!ValidationHelper.ComboBoxValidation(cbVaucer))
            {
                return;
            }

            int sati = int.Parse(txtSati.Text);
            int minuti = int.Parse(txtMinuti.Text);
            DateTime datum = new DateTime(dtpDatum.Value.Year, dtpDatum.Value.Month, dtpDatum.Value.Day, sati, minuti, 0);

            Termin termin = new Termin
            {
                SifraKlijenta = (Klijent)cbKlijent.SelectedItem,
                SifraUsluge = (Usluga)cbUsluga.SelectedItem,
                DatumVremeTermina = datum,
                BrojProstorije = (int)nudBrojProstorije.Value,
                Napomena = rtbNapomena.Text,
                Vaucer = (Vaucer)cbVaucer.SelectedItem
            };           

            try
            {
                if (termini.Any(x => x.SifraKlijenta.Equals(termin.SifraKlijenta) &&
                    ((x.DatumVremeTermina.AddMinutes(x.SifraUsluge.TrajanjeUsluge) > termin.DatumVremeTermina &&
                    x.DatumVremeTermina < termin.DatumVremeTermina) ||
                    (termin.DatumVremeTermina.AddMinutes(termin.SifraUsluge.TrajanjeUsluge) > x.DatumVremeTermina &&
                    x.DatumVremeTermina > termin.DatumVremeTermina) ||
                    DateTime.Compare(x.DatumVremeTermina, termin.DatumVremeTermina) == 0)))
                {
                    MessageBox.Show("Vec ste uneli termin u zeljenom periodu za izabranog klijenta!");
                    return;
                }

                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Termin>>
                    (Operation.VratiListuTermina, null).Any(x => x.SifraKlijenta.Equals(termin.SifraKlijenta) &&
                    ((x.DatumVremeTermina.AddMinutes(x.SifraUsluge.TrajanjeUsluge) > termin.DatumVremeTermina &&
                    x.DatumVremeTermina < termin.DatumVremeTermina) ||
                    (termin.DatumVremeTermina.AddMinutes(termin.SifraUsluge.TrajanjeUsluge) > x.DatumVremeTermina &&
                    x.DatumVremeTermina > termin.DatumVremeTermina) ||
                    DateTime.Compare(x.DatumVremeTermina, termin.DatumVremeTermina) == 0)))
                {
                    MessageBox.Show("Vec postoji termin u zeljenom periodu za izabranog klijenta!");
                    return;
                }

                if (termini.Any(x => x.BrojProstorije == termin.BrojProstorije &&
                    ((x.DatumVremeTermina.AddMinutes(x.SifraUsluge.TrajanjeUsluge) > termin.DatumVremeTermina &&
                    x.DatumVremeTermina < termin.DatumVremeTermina) ||
                    (termin.DatumVremeTermina.AddMinutes(termin.SifraUsluge.TrajanjeUsluge) > x.DatumVremeTermina &&
                    x.DatumVremeTermina > termin.DatumVremeTermina) ||
                    DateTime.Compare(x.DatumVremeTermina, termin.DatumVremeTermina) == 0)))
                {
                    MessageBox.Show("Vec ste uneli termin u zeljenom periodu u izabranoj prostoriji!");
                    return;
                }

                if (ServerCommunication.Communication.Instance.SendRequestGetResult<List<Termin>>
                    (Operation.VratiListuTermina, null).Any(x => x.BrojProstorije == termin.BrojProstorije &&
                    ((x.DatumVremeTermina.AddMinutes(x.SifraUsluge.TrajanjeUsluge) > termin.DatumVremeTermina &&
                    x.DatumVremeTermina < termin.DatumVremeTermina) ||
                    (termin.DatumVremeTermina.AddMinutes(termin.SifraUsluge.TrajanjeUsluge) > x.DatumVremeTermina &&
                    x.DatumVremeTermina > termin.DatumVremeTermina) ||
                    DateTime.Compare(x.DatumVremeTermina, termin.DatumVremeTermina) == 0)))
                {
                    MessageBox.Show("Vec postoji termin u zeljenom periodu u izabranoj prostoriji!");
                    return;
                }
            }
            catch (SystemOperationException)
            {
                MessageBox.Show("Trenutno nije moguce izvrsiti validaciju za unos termina. Pokusajte kasnije.");
                return;
            }

            IzracunajKonacnuCenu(termin);
            termini.Add(termin);
            InicijalizujTermine(dgvTermini);
            IsprazniPolja(cbKlijent, cbUsluga, cbVaucer, dtpDatum, txtSati, txtMinuti, nudBrojProstorije, rtbNapomena);

        }

        private void IzracunajKonacnuCenu(Termin termin)
        {
            switch (termin.Vaucer)
            {
                case Vaucer.BezVaucera:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge;
                    break;
                case Vaucer.Popust10:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge - 0.1 * termin.SifraUsluge.CenaUsluge;
                    break;
                case Vaucer.Popust15:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge - 0.15 * termin.SifraUsluge.CenaUsluge;
                    break;
                case Vaucer.Popust20:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge - 0.2 * termin.SifraUsluge.CenaUsluge;
                    break;
                default:
                    termin.KonacnaCena = termin.SifraUsluge.CenaUsluge;
                    break;
            }
        }

        
    }
}
