
namespace Server
{
    partial class FrmServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.pbStop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(221)))), ((int)(((byte)(252)))));
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtStatus.Location = new System.Drawing.Point(296, 373);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(259, 34);
            this.txtStatus.TabIndex = 2;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 326);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status:";
            // 
            // pbStart
            // 
            this.pbStart.BackColor = System.Drawing.Color.Transparent;
            this.pbStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStart.Image = ((System.Drawing.Image)(resources.GetObject("pbStart.Image")));
            this.pbStart.Location = new System.Drawing.Point(322, 95);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(100, 219);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStart.TabIndex = 4;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            // 
            // pbStop
            // 
            this.pbStop.BackColor = System.Drawing.Color.Transparent;
            this.pbStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStop.Image = ((System.Drawing.Image)(resources.GetObject("pbStop.Image")));
            this.pbStop.Location = new System.Drawing.Point(418, 127);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(97, 156);
            this.pbStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStop.TabIndex = 5;
            this.pbStop.TabStop = false;
            this.pbStop.Click += new System.EventHandler(this.pbStop_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 552);
            this.Controls.Add(this.pbStop);
            this.Controls.Add(this.pbStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmServer";
            this.Text = "Softverski sistem za praćenje rada SPA centra - serverski program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmServer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.PictureBox pbStop;
    }
}

