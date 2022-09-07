
namespace Client.UserControls
{
    partial class UCPretraziObrisiTermin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPretraziObrisiTermin));
            this.lblDveTacke = new System.Windows.Forms.Label();
            this.txtMinuti = new System.Windows.Forms.TextBox();
            this.lblVreme = new System.Windows.Forms.Label();
            this.txtSati = new System.Windows.Forms.TextBox();
            this.btnObrisiTermin = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.rtbNapomena = new System.Windows.Forms.RichTextBox();
            this.nudBrojProstorije = new System.Windows.Forms.NumericUpDown();
            this.lblVaucer = new System.Windows.Forms.Label();
            this.cbVaucer = new System.Windows.Forms.ComboBox();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.lblBrojProstorije = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblUsluga = new System.Windows.Forms.Label();
            this.cbUsluga = new System.Windows.Forms.ComboBox();
            this.lblKlijent = new System.Windows.Forms.Label();
            this.cbKlijent = new System.Windows.Forms.ComboBox();
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.chbKlijentKriterijum = new System.Windows.Forms.CheckBox();
            this.chbBrojProstorijeKriterijum = new System.Windows.Forms.CheckBox();
            this.chbDatumVremeKriterijum = new System.Windows.Forms.CheckBox();
            this.cbKlijentKriterijum = new System.Windows.Forms.ComboBox();
            this.nudBrojProstorijeKriterijum = new System.Windows.Forms.NumericUpDown();
            this.dtpDatumKriterijum = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinutiKriterijum = new System.Windows.Forms.TextBox();
            this.txtSatiKriterijum = new System.Windows.Forms.TextBox();
            this.gbDetalji = new System.Windows.Forms.GroupBox();
            this.btnObavestiKlijenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojProstorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojProstorijeKriterijum)).BeginInit();
            this.gbDetalji.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDveTacke
            // 
            this.lblDveTacke.AutoSize = true;
            this.lblDveTacke.BackColor = System.Drawing.Color.Transparent;
            this.lblDveTacke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDveTacke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDveTacke.Location = new System.Drawing.Point(314, 179);
            this.lblDveTacke.Name = "lblDveTacke";
            this.lblDveTacke.Size = new System.Drawing.Size(15, 20);
            this.lblDveTacke.TabIndex = 44;
            this.lblDveTacke.Text = ":";
            // 
            // txtMinuti
            // 
            this.txtMinuti.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinuti.Location = new System.Drawing.Point(335, 176);
            this.txtMinuti.Name = "txtMinuti";
            this.txtMinuti.Size = new System.Drawing.Size(43, 27);
            this.txtMinuti.TabIndex = 43;
            // 
            // lblVreme
            // 
            this.lblVreme.AutoSize = true;
            this.lblVreme.BackColor = System.Drawing.Color.Transparent;
            this.lblVreme.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVreme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVreme.Location = new System.Drawing.Point(167, 179);
            this.lblVreme.Name = "lblVreme";
            this.lblVreme.Size = new System.Drawing.Size(58, 20);
            this.lblVreme.TabIndex = 42;
            this.lblVreme.Text = "Vreme";
            // 
            // txtSati
            // 
            this.txtSati.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSati.Location = new System.Drawing.Point(265, 176);
            this.txtSati.Name = "txtSati";
            this.txtSati.Size = new System.Drawing.Size(43, 27);
            this.txtSati.TabIndex = 41;
            // 
            // btnObrisiTermin
            // 
            this.btnObrisiTermin.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiTermin.Location = new System.Drawing.Point(1456, 769);
            this.btnObrisiTermin.Name = "btnObrisiTermin";
            this.btnObrisiTermin.Size = new System.Drawing.Size(155, 37);
            this.btnObrisiTermin.TabIndex = 40;
            this.btnObrisiTermin.Text = "Obriši termin";
            this.btnObrisiTermin.UseVisualStyleBackColor = true;
            this.btnObrisiTermin.Click += new System.EventHandler(this.btnObrisiTermin_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(515, 478);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(190, 37);
            this.btnPretrazi.TabIndex = 39;
            this.btnPretrazi.Text = "Pretraži termine";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // rtbNapomena
            // 
            this.rtbNapomena.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNapomena.Location = new System.Drawing.Point(263, 256);
            this.rtbNapomena.Name = "rtbNapomena";
            this.rtbNapomena.Size = new System.Drawing.Size(310, 81);
            this.rtbNapomena.TabIndex = 38;
            this.rtbNapomena.Text = "";
            // 
            // nudBrojProstorije
            // 
            this.nudBrojProstorije.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBrojProstorije.Location = new System.Drawing.Point(264, 214);
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
            this.nudBrojProstorije.TabIndex = 37;
            this.nudBrojProstorije.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblVaucer
            // 
            this.lblVaucer.AutoSize = true;
            this.lblVaucer.BackColor = System.Drawing.Color.Transparent;
            this.lblVaucer.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaucer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVaucer.Location = new System.Drawing.Point(163, 356);
            this.lblVaucer.Name = "lblVaucer";
            this.lblVaucer.Size = new System.Drawing.Size(62, 20);
            this.lblVaucer.TabIndex = 36;
            this.lblVaucer.Text = "Vaučer";
            // 
            // cbVaucer
            // 
            this.cbVaucer.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVaucer.FormattingEnabled = true;
            this.cbVaucer.Location = new System.Drawing.Point(264, 353);
            this.cbVaucer.Name = "cbVaucer";
            this.cbVaucer.Size = new System.Drawing.Size(310, 28);
            this.cbVaucer.TabIndex = 35;
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.BackColor = System.Drawing.Color.Transparent;
            this.lblNapomena.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNapomena.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNapomena.Location = new System.Drawing.Point(133, 259);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(92, 20);
            this.lblNapomena.TabIndex = 34;
            this.lblNapomena.Text = "Napomena";
            // 
            // lblBrojProstorije
            // 
            this.lblBrojProstorije.AutoSize = true;
            this.lblBrojProstorije.BackColor = System.Drawing.Color.Transparent;
            this.lblBrojProstorije.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojProstorije.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBrojProstorije.Location = new System.Drawing.Point(107, 216);
            this.lblBrojProstorije.Name = "lblBrojProstorije";
            this.lblBrojProstorije.Size = new System.Drawing.Size(118, 20);
            this.lblBrojProstorije.TabIndex = 33;
            this.lblBrojProstorije.Text = "Broj prostorije";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(265, 136);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(150, 27);
            this.dtpDatum.TabIndex = 32;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.BackColor = System.Drawing.Color.Transparent;
            this.lblDatum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDatum.Location = new System.Drawing.Point(163, 141);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(62, 20);
            this.lblDatum.TabIndex = 31;
            this.lblDatum.Text = "Datum";
            // 
            // lblUsluga
            // 
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.BackColor = System.Drawing.Color.Transparent;
            this.lblUsluga.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsluga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUsluga.Location = new System.Drawing.Point(163, 96);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(62, 20);
            this.lblUsluga.TabIndex = 30;
            this.lblUsluga.Text = "Usluga";
            // 
            // cbUsluga
            // 
            this.cbUsluga.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsluga.FormattingEnabled = true;
            this.cbUsluga.Location = new System.Drawing.Point(264, 93);
            this.cbUsluga.Name = "cbUsluga";
            this.cbUsluga.Size = new System.Drawing.Size(309, 28);
            this.cbUsluga.TabIndex = 29;
            // 
            // lblKlijent
            // 
            this.lblKlijent.AutoSize = true;
            this.lblKlijent.BackColor = System.Drawing.Color.Transparent;
            this.lblKlijent.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlijent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblKlijent.Location = new System.Drawing.Point(165, 52);
            this.lblKlijent.Name = "lblKlijent";
            this.lblKlijent.Size = new System.Drawing.Size(60, 20);
            this.lblKlijent.TabIndex = 28;
            this.lblKlijent.Text = "Klijent";
            // 
            // cbKlijent
            // 
            this.cbKlijent.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKlijent.FormattingEnabled = true;
            this.cbKlijent.Location = new System.Drawing.Point(264, 49);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(309, 28);
            this.cbKlijent.TabIndex = 27;
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(112, 537);
            this.dgvTermini.MultiSelect = false;
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.Size = new System.Drawing.Size(1479, 197);
            this.dgvTermini.TabIndex = 26;
            this.dgvTermini.SelectionChanged += new System.EventHandler(this.dgvTermini_SelectionChanged);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(332, 101);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(414, 27);
            this.lblNaslov.TabIndex = 25;
            this.lblNaslov.Text = "PRETRAGA I BRISANJE TERMINA";
            // 
            // chbKlijentKriterijum
            // 
            this.chbKlijentKriterijum.AutoSize = true;
            this.chbKlijentKriterijum.BackColor = System.Drawing.Color.Transparent;
            this.chbKlijentKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbKlijentKriterijum.Location = new System.Drawing.Point(211, 265);
            this.chbKlijentKriterijum.Name = "chbKlijentKriterijum";
            this.chbKlijentKriterijum.Size = new System.Drawing.Size(82, 24);
            this.chbKlijentKriterijum.TabIndex = 45;
            this.chbKlijentKriterijum.Text = "Klijent";
            this.chbKlijentKriterijum.UseVisualStyleBackColor = false;
            // 
            // chbBrojProstorijeKriterijum
            // 
            this.chbBrojProstorijeKriterijum.AutoSize = true;
            this.chbBrojProstorijeKriterijum.BackColor = System.Drawing.Color.Transparent;
            this.chbBrojProstorijeKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBrojProstorijeKriterijum.Location = new System.Drawing.Point(211, 402);
            this.chbBrojProstorijeKriterijum.Name = "chbBrojProstorijeKriterijum";
            this.chbBrojProstorijeKriterijum.Size = new System.Drawing.Size(140, 24);
            this.chbBrojProstorijeKriterijum.TabIndex = 46;
            this.chbBrojProstorijeKriterijum.Text = "Broj prostorije";
            this.chbBrojProstorijeKriterijum.UseVisualStyleBackColor = false;
            // 
            // chbDatumVremeKriterijum
            // 
            this.chbDatumVremeKriterijum.AutoSize = true;
            this.chbDatumVremeKriterijum.BackColor = System.Drawing.Color.Transparent;
            this.chbDatumVremeKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDatumVremeKriterijum.Location = new System.Drawing.Point(216, 332);
            this.chbDatumVremeKriterijum.Name = "chbDatumVremeKriterijum";
            this.chbDatumVremeKriterijum.Size = new System.Drawing.Size(143, 24);
            this.chbDatumVremeKriterijum.TabIndex = 47;
            this.chbDatumVremeKriterijum.Text = "Datum i vreme";
            this.chbDatumVremeKriterijum.UseVisualStyleBackColor = false;
            // 
            // cbKlijentKriterijum
            // 
            this.cbKlijentKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKlijentKriterijum.FormattingEnabled = true;
            this.cbKlijentKriterijum.Location = new System.Drawing.Point(396, 263);
            this.cbKlijentKriterijum.Name = "cbKlijentKriterijum";
            this.cbKlijentKriterijum.Size = new System.Drawing.Size(309, 28);
            this.cbKlijentKriterijum.TabIndex = 48;
            // 
            // nudBrojProstorijeKriterijum
            // 
            this.nudBrojProstorijeKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBrojProstorijeKriterijum.Location = new System.Drawing.Point(396, 399);
            this.nudBrojProstorijeKriterijum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudBrojProstorijeKriterijum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBrojProstorijeKriterijum.Name = "nudBrojProstorijeKriterijum";
            this.nudBrojProstorijeKriterijum.Size = new System.Drawing.Size(72, 27);
            this.nudBrojProstorijeKriterijum.TabIndex = 49;
            this.nudBrojProstorijeKriterijum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpDatumKriterijum
            // 
            this.dtpDatumKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatumKriterijum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumKriterijum.Location = new System.Drawing.Point(396, 328);
            this.dtpDatumKriterijum.Name = "dtpDatumKriterijum";
            this.dtpDatumKriterijum.Size = new System.Drawing.Size(162, 27);
            this.dtpDatumKriterijum.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(640, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = ":";
            // 
            // txtMinutiKriterijum
            // 
            this.txtMinutiKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutiKriterijum.Location = new System.Drawing.Point(662, 328);
            this.txtMinutiKriterijum.Name = "txtMinutiKriterijum";
            this.txtMinutiKriterijum.Size = new System.Drawing.Size(43, 27);
            this.txtMinutiKriterijum.TabIndex = 52;
            // 
            // txtSatiKriterijum
            // 
            this.txtSatiKriterijum.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSatiKriterijum.Location = new System.Drawing.Point(591, 328);
            this.txtSatiKriterijum.Name = "txtSatiKriterijum";
            this.txtSatiKriterijum.Size = new System.Drawing.Size(43, 27);
            this.txtSatiKriterijum.TabIndex = 51;
            // 
            // gbDetalji
            // 
            this.gbDetalji.BackColor = System.Drawing.Color.Transparent;
            this.gbDetalji.Controls.Add(this.rtbNapomena);
            this.gbDetalji.Controls.Add(this.cbKlijent);
            this.gbDetalji.Controls.Add(this.lblKlijent);
            this.gbDetalji.Controls.Add(this.cbUsluga);
            this.gbDetalji.Controls.Add(this.lblUsluga);
            this.gbDetalji.Controls.Add(this.lblDatum);
            this.gbDetalji.Controls.Add(this.dtpDatum);
            this.gbDetalji.Controls.Add(this.lblBrojProstorije);
            this.gbDetalji.Controls.Add(this.lblNapomena);
            this.gbDetalji.Controls.Add(this.cbVaucer);
            this.gbDetalji.Controls.Add(this.lblDveTacke);
            this.gbDetalji.Controls.Add(this.lblVaucer);
            this.gbDetalji.Controls.Add(this.txtMinuti);
            this.gbDetalji.Controls.Add(this.nudBrojProstorije);
            this.gbDetalji.Controls.Add(this.lblVreme);
            this.gbDetalji.Controls.Add(this.txtSati);
            this.gbDetalji.Enabled = false;
            this.gbDetalji.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalji.Location = new System.Drawing.Point(869, 101);
            this.gbDetalji.Name = "gbDetalji";
            this.gbDetalji.Size = new System.Drawing.Size(722, 414);
            this.gbDetalji.TabIndex = 54;
            this.gbDetalji.TabStop = false;
            this.gbDetalji.Text = "Detalji";
            // 
            // btnObavestiKlijenta
            // 
            this.btnObavestiKlijenta.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObavestiKlijenta.Location = new System.Drawing.Point(1169, 769);
            this.btnObavestiKlijenta.Name = "btnObavestiKlijenta";
            this.btnObavestiKlijenta.Size = new System.Drawing.Size(266, 37);
            this.btnObavestiKlijenta.TabIndex = 55;
            this.btnObavestiKlijenta.Text = "Obavesti klijenta o terminu";
            this.btnObavestiKlijenta.UseVisualStyleBackColor = true;
            this.btnObavestiKlijenta.Click += new System.EventHandler(this.btnObavestiKlijenta_Click);
            // 
            // UCPretraziObrisiTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnObavestiKlijenta);
            this.Controls.Add(this.gbDetalji);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinutiKriterijum);
            this.Controls.Add(this.txtSatiKriterijum);
            this.Controls.Add(this.dtpDatumKriterijum);
            this.Controls.Add(this.nudBrojProstorijeKriterijum);
            this.Controls.Add(this.cbKlijentKriterijum);
            this.Controls.Add(this.chbDatumVremeKriterijum);
            this.Controls.Add(this.chbBrojProstorijeKriterijum);
            this.Controls.Add(this.chbKlijentKriterijum);
            this.Controls.Add(this.btnObrisiTermin);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvTermini);
            this.Controls.Add(this.lblNaslov);
            this.DoubleBuffered = true;
            this.Name = "UCPretraziObrisiTermin";
            this.Size = new System.Drawing.Size(1720, 844);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojProstorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojProstorijeKriterijum)).EndInit();
            this.gbDetalji.ResumeLayout(false);
            this.gbDetalji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDveTacke;
        private System.Windows.Forms.TextBox txtMinuti;
        private System.Windows.Forms.Label lblVreme;
        private System.Windows.Forms.TextBox txtSati;
        private System.Windows.Forms.Button btnObrisiTermin;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.RichTextBox rtbNapomena;
        private System.Windows.Forms.NumericUpDown nudBrojProstorije;
        private System.Windows.Forms.Label lblVaucer;
        private System.Windows.Forms.ComboBox cbVaucer;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.Label lblBrojProstorije;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.ComboBox cbUsluga;
        private System.Windows.Forms.Label lblKlijent;
        private System.Windows.Forms.ComboBox cbKlijent;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.CheckBox chbKlijentKriterijum;
        private System.Windows.Forms.CheckBox chbBrojProstorijeKriterijum;
        private System.Windows.Forms.CheckBox chbDatumVremeKriterijum;
        private System.Windows.Forms.ComboBox cbKlijentKriterijum;
        private System.Windows.Forms.NumericUpDown nudBrojProstorijeKriterijum;
        private System.Windows.Forms.DateTimePicker dtpDatumKriterijum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinutiKriterijum;
        private System.Windows.Forms.TextBox txtSatiKriterijum;
        private System.Windows.Forms.GroupBox gbDetalji;
        private System.Windows.Forms.Button btnObavestiKlijenta;
    }
}
