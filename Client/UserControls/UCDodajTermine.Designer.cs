
namespace Client.UserControls
{
    partial class UCDodajTermine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDodajTermine));
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.lblUsluga = new System.Windows.Forms.Label();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblBrojProstorije = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblVaucer = new System.Windows.Forms.Label();
            this.cbVaucer = new System.Windows.Forms.ComboBox();
            this.nudBrojProstorije = new System.Windows.Forms.NumericUpDown();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.btnSacuvajTermine = new System.Windows.Forms.Button();
            this.txtSati = new System.Windows.Forms.TextBox();
            this.lblVreme = new System.Windows.Forms.Label();
            this.txtMinuti = new System.Windows.Forms.TextBox();
            this.lblDveTacke = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojProstorije)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(768, 100);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(203, 27);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "UNOS TERMINA";
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(321, 470);
            this.dgvTermini.MultiSelect = false;
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(1040, 215);
            this.dgvTermini.TabIndex = 1;
            // 
            // cbKlijent
            // 
            this.cbKlijent.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(496, 196);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(318, 28);
            this.cbKlijent.TabIndex = 2;
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.BackColor = System.Drawing.Color.Transparent;
            this.lblKlijent.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKlijent.Location = new System.Drawing.Point(394, 199);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(60, 20);
            this.lblKlijent.TabIndex = 3;
            this.lblKlijent.Text = "Klijent";
            // 
            // lblUsluga
            // 
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblUsluga.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsluga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsluga.Location = new System.Drawing.Point(394, 251);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(62, 20);
            this.lblUsluga.TabIndex = 5;
            this.lblUsluga.Text = "Usluga";
            // 
            // cbUsluga
            // 
            this.cbUsluga.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(496, 248);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(318, 28);
            this.cbUsluga.TabIndex = 4;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDatum.Location = new System.Drawing.Point(394, 310);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(62, 20);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Datum";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(496, 305);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(150, 27);
            this.dtpDatum.TabIndex = 8;
            // 
            // lblBrojProstorije
            // 
            this.lblBrojProstorije.AutoSize = true;
            this.lblBrojProstorije.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojProstorije.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojProstorije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBrojProstorije.Location = new System.Drawing.Point(350, 424);
            this.lblBrojProstorije.Name = "lblBrojProstorije";
            this.lblBrojProstorije.Size = new System.Drawing.Size(118, 20);
            this.lblBrojProstorije.TabIndex = 10;
            this.lblBrojProstorije.Text = "Broj prostorije";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.BackColor = System.Drawing.Color.Transparent;
            this.lblNapomena.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapomena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNapomena.Location = new System.Drawing.Point(886, 199);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(92, 20);
            this.lblNapomena.TabIndex = 12;
            this.lblNapomena.Text = "Napomena";
            // 
            // lblVaucer
            // 
            this.lblVaucer.AutoSize = true;
            this.lblVaucer.BackColor = System.Drawing.Color.Transparent;
            this.lblVaucer.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaucer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVaucer.Location = new System.Drawing.Point(910, 354);
            this.lblVaucer.Name = "lblVaucer";
            this.lblVaucer.Size = new System.Drawing.Size(62, 20);
            this.lblVaucer.TabIndex = 14;
            this.lblVaucer.Text = "Vaučer";
            // 
            // cbVaucer
            // 
            this.cbVaucer.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaucer.FormattingEnabled = true;
            this.cbVaucer.Location = new System.Drawing.Point(1019, 351);
            this.cbVaucer.Name = "cbVaucer";
            this.cbVaucer.Size = new System.Drawing.Size(310, 28);
            this.cbVaucer.TabIndex = 13;
            // 
            // nudBrojProstorije
            // 
            this.nudBrojProstorije.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBrojProstorije.Location = new System.Drawing.Point(496, 419);
            this.nudBrojProstorije.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBrojProstorije.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrojProstorije.Name = "nudBrojProstorije";
            this.nudBrojProstorije.Size = new System.Drawing.Size(72, 27);
            this.nudBrojProstorije.TabIndex = 15;
            this.nudBrojProstorije.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNapomena.Location = new System.Drawing.Point(1019, 196);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(310, 128);
            this.rtbNapomena.TabIndex = 16;
            this.rtbNapomena.Text = "";
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTermin.Location = new System.Drawing.Point(1019, 416);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(151, 37);
            this.btnDodajTermin.TabIndex = 18;
            this.btnDodajTermin.Text = "Dodaj termin";
            this.btnDodajTermin.UseVisualStyleBackColor = true;
            this.btnDodajTermin.Click += new System.EventHandler(this.btnDodajTermin_Click);
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTermin.Location = new System.Drawing.Point(1186, 416);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(143, 37);
            this.btnObrisiTermin.TabIndex = 19;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = true;
            this.btnObrisiTermin.Click += new System.EventHandler(this.btnObrisiTermin_Click);
            // 
            // btnSacuvajTermine
            // 
            this.btnSacuvajTermine.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajTermine.Location = new System.Drawing.Point(1173, 720);
            this.btnSacuvajTermine.Name = "btnSacuvajTermine";
            this.btnSacuvajTermine.Size = new System.Drawing.Size(188, 37);
            this.btnSacuvajTermine.TabIndex = 20;
            this.btnSacuvajTermine.Text = "Sačuvaj termine";
            this.btnSacuvajTermine.UseVisualStyleBackColor = true;
            this.btnSacuvajTermine.Click += new System.EventHandler(this.btnSacuvajTermine_Click);
            // 
            // txtSati
            // 
            this.txtSati.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSati.Location = new System.Drawing.Point(495, 361);
            this.txtSati.Name = "txtSati";
            this.txtSati.Size = new System.Drawing.Size(43, 27);
            this.txtSati.TabIndex = 21;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.BackColor = System.Drawing.Color.Transparent;
            this.lblVreme.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVreme.Location = new System.Drawing.Point(397, 364);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(58, 20);
            this.lblVreme.TabIndex = 22;
            this.lblVreme.Text = "Vreme";
            // 
            // txtMinuti
            // 
            this.txtMinuti.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuti.Location = new System.Drawing.Point(566, 361);
            this.txtMinuti.Name = "txtMinuti";
            this.txtMinuti.Size = new System.Drawing.Size(43, 27);
            this.txtMinuti.TabIndex = 23;
            // 
            // lblDveTacke
            // 
            this.lblDveTacke.AutoSize = true;
            this.lblDveTacke.BackColor = System.Drawing.Color.Transparent;
            this.lblDveTacke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDveTacke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDveTacke.Location = new System.Drawing.Point(544, 364);
            this.lblDveTacke.Name = "lblDveTacke";
            this.lblDveTacke.Size = new System.Drawing.Size(15, 20);
            this.lblDveTacke.TabIndex = 24;
            this.lblDveTacke.Text = ":";
            // 
            // UCDodajTermine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblDveTacke);
            this.Controls.Add(this.txtMinuti);
            this.Controls.Add(this.lblVreme);
            this.Controls.Add(this.txtSati);
            this.Controls.Add(this.btnSacuvajTermine);
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.btnDodajTermin);
            this.Controls.Add(this.rtbNapomena);
            this.Controls.Add(this.nudBrojProstorije);
            this.Controls.Add(this.lblVaucer);
            this.Controls.Add(this.cbVaucer);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblBrojProstorije);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblUsluga);
            this.Controls.Add(this.cbUsluga);
            this.Controls.Add(this.lblKlijent);
            this.Controls.Add(this.cbKlijent);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.lblNaslov);
            this.DoubleBuffered = true;
            this.Name = "UCDodajTermine";
            this.Size = new System.Drawing.Size(1488, 794);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojProstorije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblBrojProstorije;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblVaucer;
        private System.Windows.Forms.ComboBox cbVaucer;
        private System.Windows.Forms.NumericUpDown nudBrojProstorije;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.Button btnObrisiTermin;
        private System.Windows.Forms.Button btnSacuvajTermine;
        private System.Windows.Forms.TextBox txtSati;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.TextBox txtMinuti;
        private System.Windows.Forms.Label lblDveTacke;
    }
}
