using Client.Exceptions;
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
    public class UCDodajRacunarskeKomponenteController
    {
        private BindingList<RacunarskaKomponenta> komponente = new BindingList<RacunarskaKomponenta>();
        internal void PripremiFormu(ComboBox cbTip, DataGridView dgvRacunarskeKomponente)
        {
            cbTip.DataSource = Enum.GetValues(typeof(Tip));
            cbTip.SelectedIndex = -1;
            cbTip.Text = "Odaberite tip";
            dgvRacunarskeKomponente.DataSource = null;
            dgvRacunarskeKomponente.DataSource = komponente;

        }

        internal void DodajRacunarskuKomponentu(DataGridView dgvRacunarskeKomponente, TextBox txtNaziv, RichTextBox rtbOpis, ComboBox cbTip)
        {
            RacunarskaKomponenta rk = new RacunarskaKomponenta
            {
                Naziv = txtNaziv.Text,
                Opis = rtbOpis.Text,
                Tip = (Tip)cbTip.SelectedItem
            };

            try
            {
                //List<RacunarskaKomponenta> komponenteBaza = ServerCommunication.Communication.Instance.SendRequestGetResult<List<RacunarskaKomponenta>>
                   // (Operation.VratiRacunarskeKomponente, null);

                if (komponente.Any(x => x.Naziv.Equals(rk.Naziv)))
                {
                    MessageBox.Show("Ne mozete uneti dve komponente sa istim nazivom.");
                    return;
                }

                komponente.Add(rk);
                dgvRacunarskeKomponente.DataSource = null;
                dgvRacunarskeKomponente.DataSource = komponente;
                IsprazniPolja(txtNaziv, rtbOpis, cbTip);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem nije mogao da validira podatke za unos. Pokusajte kasnije.");
                IsprazniPolja(txtNaziv, rtbOpis, cbTip);
            }


           

        }



        internal void Sacuvaj(DataGridView dgvRacunarskeKomponente, TextBox txtNaziv, RichTextBox rtbOpis, ComboBox cbTip)
        {
            try
            {
                if (komponente == null || komponente.Count == 0)
                {
                    MessageBox.Show("Nema komponenti za cuvanje!");
                    return;
                }

                ServerCommunication.Communication.Instance.SendRequestNoResult(Operation.ZapamtiRacunarskeKomponente, komponente.ToList());
                MessageBox.Show("Uspesno ste sacuvali komponente!");
                komponente?.Clear();
                dgvRacunarskeKomponente.DataSource = null;
                dgvRacunarskeKomponente.DataSource = komponente;
                IsprazniPolja(txtNaziv, rtbOpis, cbTip);

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IsprazniPolja(TextBox txtNaziv, RichTextBox rtbOpis, ComboBox cbTip)
        {
            txtNaziv.Text = "";
            rtbOpis.Text = "";
            cbTip.DataSource = Enum.GetValues(typeof(Tip));
            cbTip.SelectedIndex = -1;
            cbTip.Text = "Odaberite tip";
        }
    }
}
