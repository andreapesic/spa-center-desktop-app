
namespace Client.UserControls
{
    partial class UCDodajUslugu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajUslugu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvNapomene = new System.Windows.Forms.DataGridView();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.cbVrstaUsluge = new System.Windows.Forms.ComboBox();
            this.btnDodajNapomenu = new System.Windows.Forms.Button();
            this.btnObrisiNapomenu = new System.Windows.Forms.Button();
            this.btnSacuvajUslugu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNOS USLUGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cena";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trajanje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta usluge";
            // 
            // dgvNapomene
            // 
            this.dgvNapomene.AllowUserToAddRows = false;
            this.dgvNapomene.AllowUserToDeleteRows = false;
            this.dgvNapomene.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNapomene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNapomene.Location = new System.Drawing.Point(802, 264);
            this.dgvNapomene.Name = "dgvNapomene";
            this.dgvNapomene.ReadOnly = true;
            this.dgvNapomene.RowHeadersWidth = 51;
            this.dgvNapomene.RowTemplate.Height = 24;
            this.dgvNapomene.Size = new System.Drawing.Size(580, 214);
            this.dgvNapomene.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(415, 264);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(262, 27);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrajanje.Location = new System.Drawing.Point(415, 435);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(262, 27);
            this.txtTrajanje.TabIndex = 7;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCena.Location = new System.Drawing.Point(415, 353);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(262, 27);
            this.txtCena.TabIndex = 8;
            // 
            // cbVrstaUsluge
            // 
            this.cbVrstaUsluge.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVrstaUsluge.FormattingEnabled = true;
            this.cbVrstaUsluge.Location = new System.Drawing.Point(415, 514);
            this.cbVrstaUsluge.Name = "cbVrstaUsluge";
            this.cbVrstaUsluge.Size = new System.Drawing.Size(262, 28);
            this.cbVrstaUsluge.TabIndex = 9;
            // 
            // btnDodajNapomenu
            // 
            this.btnDodajNapomenu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNapomenu.Location = new System.Drawing.Point(802, 503);
            this.btnDodajNapomenu.Name = "btnDodajNapomenu";
            this.btnDodajNapomenu.Size = new System.Drawing.Size(274, 39);
            this.btnDodajNapomenu.TabIndex = 10;
            this.btnDodajNapomenu.Text = "Dodaj napomenu za uslugu";
            this.btnDodajNapomenu.UseVisualStyleBackColor = true;
            this.btnDodajNapomenu.Click += new System.EventHandler(this.btnDodajNapomenu_Click);
            // 
            // btnObrisiNapomenu
            // 
            this.btnObrisiNapomenu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiNapomenu.Location = new System.Drawing.Point(1108, 503);
            this.btnObrisiNapomenu.Name = "btnObrisiNapomenu";
            this.btnObrisiNapomenu.Size = new System.Drawing.Size(274, 39);
            this.btnObrisiNapomenu.TabIndex = 11;
            this.btnObrisiNapomenu.Text = "Obriši napomenu za uslugu";
            this.btnObrisiNapomenu.UseVisualStyleBackColor = true;
            this.btnObrisiNapomenu.Click += new System.EventHandler(this.btnObrisiNapomenu_Click);
            // 
            // btnSacuvajUslugu
            // 
            this.btnSacuvajUslugu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajUslugu.Location = new System.Drawing.Point(1108, 604);
            this.btnSacuvajUslugu.Name = "btnSacuvajUslugu";
            this.btnSacuvajUslugu.Size = new System.Drawing.Size(274, 43);
            this.btnSacuvajUslugu.TabIndex = 12;
            this.btnSacuvajUslugu.Text = "Sačuvaj uslugu";
            this.btnSacuvajUslugu.UseVisualStyleBackColor = true;
            this.btnSacuvajUslugu.Click += new System.EventHandler(this.btnSacuvajUslugu_Click);
            // 
            // UCDodajUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnSacuvajUslugu);
            this.Controls.Add(this.btnObrisiNapomenu);
            this.Controls.Add(this.btnDodajNapomenu);
            this.Controls.Add(this.cbVrstaUsluge);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dgvNapomene);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UCDodajUslugu";
            this.Size = new System.Drawing.Size(1548, 794);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNapomene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvNapomene;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.ComboBox cbVrstaUsluge;
        private System.Windows.Forms.Button btnDodajNapomenu;
        private System.Windows.Forms.Button btnObrisiNapomenu;
        private System.Windows.Forms.Button btnSacuvajUslugu;
    }
}
