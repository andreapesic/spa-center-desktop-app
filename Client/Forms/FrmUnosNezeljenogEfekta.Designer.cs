
namespace Client.Forms
{
    partial class FrmUnosNezeljenogEfekta
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnosNezeljenogEfekta));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipNapomene = new System.Windows.Forms.ComboBox();
            this.btnDodajNapomenu = new System.Windows.Forms.Button();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tip napomene";
            // 
            // cbTipNapomene
            // 
            this.cbTipNapomene.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipNapomene.FormattingEnabled = true;
            this.cbTipNapomene.Location = new System.Drawing.Point(198, 249);
            this.cbTipNapomene.Name = "cbTipNapomene";
            this.cbTipNapomene.Size = new System.Drawing.Size(257, 26);
            this.cbTipNapomene.TabIndex = 5;
            // 
            // btnDodajNapomenu
            // 
            this.btnDodajNapomenu.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajNapomenu.Location = new System.Drawing.Point(231, 340);
            this.btnDodajNapomenu.Name = "btnDodajNapomenu";
            this.btnDodajNapomenu.Size = new System.Drawing.Size(200, 37);
            this.btnDodajNapomenu.TabIndex = 6;
            this.btnDodajNapomenu.Text = "Dodaj napomenu";
            this.btnDodajNapomenu.UseVisualStyleBackColor = true;
            this.btnDodajNapomenu.Click += new System.EventHandler(this.btnDodajNapomenu_Click);
            // 
            // rtbOpis
            // 
            this.rtbOpis.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOpis.Location = new System.Drawing.Point(198, 111);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(257, 101);
            this.rtbOpis.TabIndex = 7;
            this.rtbOpis.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "UNOS NAPOMENE ZA USLUGU";
            // 
            // FrmUnosNezeljenogEfekta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(223)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(629, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.btnDodajNapomenu);
            this.Controls.Add(this.cbTipNapomene);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUnosNezeljenogEfekta";
            this.Text = "Softverski sitem za praćenje rada SPA centra - klijentski program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipNapomene;
        private System.Windows.Forms.Button btnDodajNapomenu;
        private System.Windows.Forms.RichTextBox rtbOpis;
        private System.Windows.Forms.Label label1;
    }
}