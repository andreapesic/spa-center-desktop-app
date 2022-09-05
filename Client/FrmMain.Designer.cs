
namespace Client
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.klijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaBrisanjeKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosUslugeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeUslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosTerminaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaBrisanjeTerminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPrijavljeniKorisnik = new System.Windows.Forms.Label();
            this.unosRacunarskihKomponentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuMain.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.klijentToolStripMenuItem,
            this.uslugaToolStripMenuItem,
            this.terminiToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(1269, 28);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // klijentToolStripMenuItem
            // 
            this.klijentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosKlijentaToolStripMenuItem,
            this.izmenaBrisanjeKlijentaToolStripMenuItem});
            this.klijentToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klijentToolStripMenuItem.Name = "klijentToolStripMenuItem";
            this.klijentToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.klijentToolStripMenuItem.Text = "Klijenti";
            // 
            // unosKlijentaToolStripMenuItem
            // 
            this.unosKlijentaToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.unosKlijentaToolStripMenuItem.Name = "unosKlijentaToolStripMenuItem";
            this.unosKlijentaToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.unosKlijentaToolStripMenuItem.Text = "Unos";
            this.unosKlijentaToolStripMenuItem.Click += new System.EventHandler(this.unosKlijentaToolStripMenuItem_Click);
            // 
            // izmenaBrisanjeKlijentaToolStripMenuItem
            // 
            this.izmenaBrisanjeKlijentaToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Name = "izmenaBrisanjeKlijentaToolStripMenuItem";
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Text = "Izmena / Brisanje";
            this.izmenaBrisanjeKlijentaToolStripMenuItem.Click += new System.EventHandler(this.izmenaBrisanjeKlijentaToolStripMenuItem_Click);
            // 
            // uslugaToolStripMenuItem
            // 
            this.uslugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosUslugeToolStripMenuItem1,
            this.brisanjeUslugeToolStripMenuItem});
            this.uslugaToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uslugaToolStripMenuItem.Name = "uslugaToolStripMenuItem";
            this.uslugaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.uslugaToolStripMenuItem.Text = "Usluge";
            // 
            // unosUslugeToolStripMenuItem1
            // 
            this.unosUslugeToolStripMenuItem1.BackColor = System.Drawing.Color.LavenderBlush;
            this.unosUslugeToolStripMenuItem1.Name = "unosUslugeToolStripMenuItem1";
            this.unosUslugeToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.unosUslugeToolStripMenuItem1.Text = "Unos";
            this.unosUslugeToolStripMenuItem1.Click += new System.EventHandler(this.unosUslugeToolStripMenuItem1_Click);
            // 
            // brisanjeUslugeToolStripMenuItem
            // 
            this.brisanjeUslugeToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.brisanjeUslugeToolStripMenuItem.Name = "brisanjeUslugeToolStripMenuItem";
            this.brisanjeUslugeToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.brisanjeUslugeToolStripMenuItem.Text = "Brisanje";
            this.brisanjeUslugeToolStripMenuItem.Click += new System.EventHandler(this.brisanjeUslugeToolStripMenuItem_Click);
            // 
            // terminiToolStripMenuItem
            // 
            this.terminiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosTerminaToolStripMenuItem2,
            this.pretragaBrisanjeTerminaToolStripMenuItem,
            this.unosRacunarskihKomponentiToolStripMenuItem});
            this.terminiToolStripMenuItem.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.terminiToolStripMenuItem.Name = "terminiToolStripMenuItem";
            this.terminiToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.terminiToolStripMenuItem.Text = "Termini";
            // 
            // unosTerminaToolStripMenuItem2
            // 
            this.unosTerminaToolStripMenuItem2.BackColor = System.Drawing.Color.LavenderBlush;
            this.unosTerminaToolStripMenuItem2.Name = "unosTerminaToolStripMenuItem2";
            this.unosTerminaToolStripMenuItem2.Size = new System.Drawing.Size(321, 26);
            this.unosTerminaToolStripMenuItem2.Text = "Unos";
            this.unosTerminaToolStripMenuItem2.Click += new System.EventHandler(this.unosTerminaToolStripMenuItem2_Click);
            // 
            // pretragaBrisanjeTerminaToolStripMenuItem
            // 
            this.pretragaBrisanjeTerminaToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.pretragaBrisanjeTerminaToolStripMenuItem.Name = "pretragaBrisanjeTerminaToolStripMenuItem";
            this.pretragaBrisanjeTerminaToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.pretragaBrisanjeTerminaToolStripMenuItem.Text = "Pretraga / Brisanje";
            this.pretragaBrisanjeTerminaToolStripMenuItem.Click += new System.EventHandler(this.pretragaBrisanjeTerminaToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.lblNaslov);
            this.pnlMain.Location = new System.Drawing.Point(0, 29);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1269, 794);
            this.pnlMain.TabIndex = 1;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.BackColor = System.Drawing.Color.Transparent;
            this.lblNaslov.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNaslov.Location = new System.Drawing.Point(248, 381);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(921, 69);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Dobro došli u Andrea SPA centar!";
            // 
            // lblPrijavljeniKorisnik
            // 
            this.lblPrijavljeniKorisnik.AutoSize = true;
            this.lblPrijavljeniKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.lblPrijavljeniKorisnik.Location = new System.Drawing.Point(999, 9);
            this.lblPrijavljeniKorisnik.Name = "lblPrijavljeniKorisnik";
            this.lblPrijavljeniKorisnik.Size = new System.Drawing.Size(0, 17);
            this.lblPrijavljeniKorisnik.TabIndex = 2;
            // 
            // unosRacunarskihKomponentiToolStripMenuItem
            // 
            this.unosRacunarskihKomponentiToolStripMenuItem.Name = "unosRacunarskihKomponentiToolStripMenuItem";
            this.unosRacunarskihKomponentiToolStripMenuItem.Size = new System.Drawing.Size(321, 26);
            this.unosRacunarskihKomponentiToolStripMenuItem.Text = "Unos racunarskih komponenti";
            this.unosRacunarskihKomponentiToolStripMenuItem.Click += new System.EventHandler(this.unosRacunarskihKomponentiToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1269, 747);
            this.Controls.Add(this.lblPrijavljeniKorisnik);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Softverski sistem za praćenje rada SPA centra - Klijentski program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem klijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminiToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem unosKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaBrisanjeKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosUslugeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brisanjeUslugeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosTerminaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pretragaBrisanjeTerminaToolStripMenuItem;
        private System.Windows.Forms.Label lblPrijavljeniKorisnik;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.ToolStripMenuItem unosRacunarskihKomponentiToolStripMenuItem;
    }
}