using Client.FormControllers;
using Domain;
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
    public partial class UCObrisiUslugu : UserControl
    {
        private UCObrisiUsluguController obrisiUsluguController;

        public UCObrisiUslugu()
        {
            
        }

        public UCObrisiUslugu(UCObrisiUsluguController UCObrisiUsluguController)
        {

            InitializeComponent();
            this.obrisiUsluguController = UCObrisiUsluguController;
            obrisiUsluguController.PripremiFormu(cbVrstaKriterijum, dgvUsluge);

        }

        private void dgvUsluge_SelectionChanged(object sender, EventArgs e)
        {
            obrisiUsluguController.PopuniDetalje(dgvUsluge, dgvNapomene, txtNaziv, txtCena, txtTrajanje, txtVrsta, txtUkupnoTermina);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            obrisiUsluguController.ObrisiUslugu(dgvUsluge, txtUkupnoTermina);
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            obrisiUsluguController.PretraziUslugu(dgvUsluge, chbNaziv, chbVrsta, txtNazivKriterijum, cbVrstaKriterijum);
        }
    }
}
