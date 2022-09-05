
namespace Client.UserControls
{
    partial class UCDodajRacunarskeKomponente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.dgvRacunarskeKomponente = new System.Windows.Forms.DataGridView();
            this.btnDodajUDgv = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunarskeKomponente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(271, 55);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(252, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(271, 102);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(252, 96);
            this.rtbOpis.TabIndex = 4;
            this.rtbOpis.Text = "";
            // 
            // cbTip
            // 
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Location = new System.Drawing.Point(271, 231);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(252, 24);
            this.cbTip.TabIndex = 5;
            // 
            // dgvRacunarskeKomponente
            // 
            this.dgvRacunarskeKomponente.AllowUserToAddRows = false;
            this.dgvRacunarskeKomponente.AllowUserToDeleteRows = false;
            this.dgvRacunarskeKomponente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacunarskeKomponente.Location = new System.Drawing.Point(95, 343);
            this.dgvRacunarskeKomponente.Name = "dgvRacunarskeKomponente";
            this.dgvRacunarskeKomponente.ReadOnly = true;
            this.dgvRacunarskeKomponente.RowHeadersWidth = 51;
            this.dgvRacunarskeKomponente.RowTemplate.Height = 24;
            this.dgvRacunarskeKomponente.Size = new System.Drawing.Size(624, 150);
            this.dgvRacunarskeKomponente.TabIndex = 6;
            // 
            // btnDodajUDgv
            // 
            this.btnDodajUDgv.Location = new System.Drawing.Point(369, 279);
            this.btnDodajUDgv.Name = "btnDodajUDgv";
            this.btnDodajUDgv.Size = new System.Drawing.Size(110, 35);
            this.btnDodajUDgv.TabIndex = 7;
            this.btnDodajUDgv.Text = "Dodaj";
            this.btnDodajUDgv.UseVisualStyleBackColor = true;
            this.btnDodajUDgv.Click += new System.EventHandler(this.btnDodajUDgv_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(620, 541);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(99, 45);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // UCDodajRacunarskeKomponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnDodajUDgv);
            this.Controls.Add(this.dgvRacunarskeKomponente);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCDodajRacunarskeKomponente";
            this.Size = new System.Drawing.Size(843, 646);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacunarskeKomponente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.DataGridView dgvRacunarskeKomponente;
        private System.Windows.Forms.Button btnDodajUDgv;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}
