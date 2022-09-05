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
    public partial class UCPretraziObrisiTermin : UserControl
    {
        private UCPretraziObrisiTerminController pretraziObrisiTerminController;

        public UCPretraziObrisiTermin()
        {
            InitializeComponent();
        }

        public UCPretraziObrisiTermin(UCPretraziObrisiTerminController uCPretraziObrisiTerminController)
        {
            InitializeComponent();
            this.pretraziObrisiTerminController = uCPretraziObrisiTerminController;
            pretraziObrisiTerminController.PripremiFormu(dgvTermini, cbKlijentKriterijum);
           
        }

        private void dgvTermini_SelectionChanged(object sender, EventArgs e)
        {
            pretraziObrisiTerminController.PopuniDetalje(dgvTermini, cbKlijent, cbUsluga, dtpDatum, txtSati, txtMinuti, nudBrojProstorije, rtbNapomena, cbVaucer);
        }

        private void btnObrisiTermin_Click(object sender, EventArgs e)
        {
            pretraziObrisiTerminController.ObrisiTermin(dgvTermini);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            pretraziObrisiTerminController.PretraziTermine(dgvTermini, chbKlijentKriterijum, chbDatumVremeKriterijum, chbBrojProstorijeKriterijum, cbKlijentKriterijum, dtpDatumKriterijum, txtSatiKriterijum, txtMinutiKriterijum, nudBrojProstorijeKriterijum);
        }

        private void btnObavestiKlijenta_Click(object sender, EventArgs e)
        {
            pretraziObrisiTerminController.ObavestiKlijenta(dgvTermini);
        }
    }
}
