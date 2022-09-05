
namespace Client.UserControls
{
    partial class UCObrisiUslugu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCObrisiUslugu));
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.txtUkupnoTermina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dgvNapomene = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.chbNaziv = new System.Windows.Forms.CheckBox();
            this.chbVrsta = new System.Windows.Forms.CheckBox();
            this.txtNazivKriterijum = new System.Windows.Forms.TextBox();
            this.cbVrstaKriterijum = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            this.gbDetalji.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(58, 287);
            this.dgvUsluge.MultiSelect = false;
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.RowHeadersWidth = 51;
            this.dgvUsluge.RowTemplate.Height = 24;
            this.dgvUsluge.Size = new System.Drawing.Size(533, 318);
            this.dgvUsluge.TabIndex = 0;
            this.dgvUsluge.SelectionChanged += new System.EventHandler(this.dgvUsluge_SelectionChanged);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(512, 81);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(410, 27);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "PRETRAGA I BRISANJE USLUGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Trajanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vrsta usluge";
            // 
            // gbDetalji
            // 
            this.gbDetalji.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalji.Controls.Add(this.txtUkupnoTermina);
            this.gbDetalji.Controls.Add(this.label6);
            this.gbDetalji.Controls.Add(this.txtTrajanje);
            this.gbDetalji.Controls.Add(this.txtVrsta);
            this.gbDetalji.Controls.Add(this.txtCena);
            this.gbDetalji.Controls.Add(this.txtNaziv);
            this.gbDetalji.Controls.Add(this.dgvNapomene);
            this.gbDetalji.Controls.Add(this.label5);
            this.gbDetalji.Controls.Add(this.label2);
            this.gbDetalji.Controls.Add(this.label4);
            this.gbDetalji.Controls.Add(this.label3);
            this.gbDetalji.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalji.Location = new System.Drawing.Point(648, 231);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(569, 374);
            this.gbDetalji.TabIndex = 6;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji";
            // 
            // txtUkupnoTermina
            // 
            this.txtUkupnoTermina.Enabled = false;
            this.txtUkupnoTermina.Location = new System.Drawing.Point(289, 38);
            this.txtUkupnoTermina.Name = "txtUkupnoTermina";
            this.txtUkupnoTermina.Size = new System.Drawing.Size(95, 27);
            this.txtUkupnoTermina.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(114, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ukupan broj termina";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Enabled = false;
            this.txtTrajanje.Location = new System.Drawing.Point(394, 88);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(148, 27);
            this.txtTrajanje.TabIndex = 10;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Enabled = false;
            this.txtVrsta.Location = new System.Drawing.Point(394, 139);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(148, 27);
            this.txtVrsta.TabIndex = 9;
            // 
            // txtCena
            // 
            this.txtCena.Enabled = false;
            this.txtCena.Location = new System.Drawing.Point(84, 139);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(148, 27);
            this.txtCena.TabIndex = 8;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Enabled = false;
            this.txtNaziv.Location = new System.Drawing.Point(84, 90);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(148, 27);
            this.txtNaziv.TabIndex = 7;
            // 
            // dgvNapomene
            // 
            this.dgvNapomene.AllowUserToAddRows = false;
            this.dgvNapomene.AllowUserToDeleteRows = false;
            this.dgvNapomene.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNapomene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNapomene.Location = new System.Drawing.Point(21, 183);
            this.dgvNapomene.Name = "dgvNapomene";
            this.dgvNapomene.ReadOnly = true;
            this.dgvNapomene.RowHeadersWidth = 51;
            this.dgvNapomene.RowTemplate.Height = 24;
            this.dgvNapomene.Size = new System.Drawing.Size(521, 149);
            this.dgvNapomene.TabIndex = 6;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(452, 631);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(139, 34);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši uslugu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // chbNaziv
            // 
            this.chbNaziv.AutoSize = true;
            this.chbNaziv.BackColor = System.Drawing.Color.Transparent;
            this.chbNaziv.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbNaziv.Location = new System.Drawing.Point(77, 188);
            this.chbNaziv.Name = "chbNaziv";
            this.chbNaziv.Size = new System.Drawing.Size(127, 24);
            this.chbNaziv.TabIndex = 10;
            this.chbNaziv.Text = "Naziv usluge";
            this.chbNaziv.UseVisualStyleBackColor = false;
            // 
            // chbVrsta
            // 
            this.chbVrsta.AutoSize = true;
            this.chbVrsta.BackColor = System.Drawing.Color.Transparent;
            this.chbVrsta.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVrsta.Location = new System.Drawing.Point(77, 232);
            this.chbVrsta.Name = "chbVrsta";
            this.chbVrsta.Size = new System.Drawing.Size(124, 24);
            this.chbVrsta.TabIndex = 11;
            this.chbVrsta.Text = "Vrsta usluge";
            this.chbVrsta.UseVisualStyleBackColor = false;
            // 
            // txtNazivKriterijum
            // 
            this.txtNazivKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNazivKriterijum.Location = new System.Drawing.Point(217, 188);
            this.txtNazivKriterijum.Name = "txtNazivKriterijum";
            this.txtNazivKriterijum.Size = new System.Drawing.Size(209, 27);
            this.txtNazivKriterijum.TabIndex = 12;
            // 
            // cbVrstaKriterijum
            // 
            this.cbVrstaKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVrstaKriterijum.FormattingEnabled = true;
            this.cbVrstaKriterijum.Location = new System.Drawing.Point(217, 232);
            this.cbVrstaKriterijum.Name = "cbVrstaKriterijum";
            this.cbVrstaKriterijum.Size = new System.Drawing.Size(209, 28);
            this.cbVrstaKriterijum.TabIndex = 13;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(452, 226);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(139, 32);
            this.btnPretrazi.TabIndex = 14;
            this.btnPretrazi.Text = "Pretraži uslugu";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // UCObrisiUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.cbVrstaKriterijum);
            this.Controls.Add(this.txtNazivKriterijum);
            this.Controls.Add(this.chbVrsta);
            this.Controls.Add(this.chbNaziv);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.dgvUsluge);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCObrisiUslugu";
            this.Size = new System.Drawing.Size(1264, 794);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbDetalji;
        private System.Windows.Forms.DataGridView dgvNapomene;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.CheckBox chbNaziv;
        private System.Windows.Forms.CheckBox chbVrsta;
        private System.Windows.Forms.TextBox txtNazivKriterijum;
        private System.Windows.Forms.ComboBox cbVrstaKriterijum;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtUkupnoTermina;
        private System.Windows.Forms.Label label6;
    }
}
