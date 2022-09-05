using Client.FormControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControls
{
    public partial class UCDodajRacunarskeKomponente : UserControl
    {
        private UCDodajRacunarskeKomponenteController dodajRacunarskeKomponenteController;

        public UCDodajRacunarskeKomponente()
        {
            
        }

        public UCDodajRacunarskeKomponente(UCDodajRacunarskeKomponenteController uCDodajRacunarskeKomponenteController)
        {
            InitializeComponent();
            this.dodajRacunarskeKomponenteController = uCDodajRacunarskeKomponenteController;
            dodajRacunarskeKomponenteController.PripremiFormu(cbTip, dgvRacunarskeKomponente);
            
        }

        private void btnDodajUDgv_Click(object sender, EventArgs e)
        {
            dodajRacunarskeKomponenteController.DodajRacunarskuKomponentu(dgvRacunarskeKomponente, txtNaziv, rtbOpis, cbTip);
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            dodajRacunarskeKomponenteController.Sacuvaj(dgvRacunarskeKomponente, txtNaziv, rtbOpis, cbTip);
        }
    }
}
