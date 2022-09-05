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

namespace Client.Forms
{
    public partial class FrmUnosNezeljenogEfekta : Form
    {
        private FrmUnosNezeljenogEfektaController frmUnosNezeljenogEfektaController;

        public FrmUnosNezeljenogEfekta()
        {
           
        }

        public FrmUnosNezeljenogEfekta(FrmUnosNezeljenogEfektaController frmUnosNezeljenogEfektaController)
        {
            InitializeComponent();
            this.frmUnosNezeljenogEfektaController = frmUnosNezeljenogEfektaController;
            frmUnosNezeljenogEfektaController.PripremiFormu(cbTipNapomene);
        }


        private void btnDodajNapomenu_Click(object sender, EventArgs e)
        {
            frmUnosNezeljenogEfektaController.DodajNapomenu(rtbOpis, cbTipNapomene, this);
        }
    }
}
