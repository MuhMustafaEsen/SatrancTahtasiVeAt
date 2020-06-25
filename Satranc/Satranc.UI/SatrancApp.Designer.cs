namespace Satranc.UI
{
    partial class SatrancApp
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
            this.components = new System.ComponentModel.Container();
            this.gbSatrancApp = new System.Windows.Forms.GroupBox();
            this.btnDur = new System.Windows.Forms.Button();
            this.pnlTahta = new System.Windows.Forms.Panel();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnIlerle = new System.Windows.Forms.Button();
            this.lstOlasilikListesi = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbSatrancApp.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSatrancApp
            // 
            this.gbSatrancApp.Controls.Add(this.btnDur);
            this.gbSatrancApp.Controls.Add(this.pnlTahta);
            this.gbSatrancApp.Controls.Add(this.btnBaslat);
            this.gbSatrancApp.Controls.Add(this.btnIlerle);
            this.gbSatrancApp.Controls.Add(this.lstOlasilikListesi);
            this.gbSatrancApp.Location = new System.Drawing.Point(5, 1);
            this.gbSatrancApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSatrancApp.Name = "gbSatrancApp";
            this.gbSatrancApp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSatrancApp.Size = new System.Drawing.Size(1015, 492);
            this.gbSatrancApp.TabIndex = 6;
            this.gbSatrancApp.TabStop = false;
            this.gbSatrancApp.Text = "Satranc App";
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(8, 152);
            this.btnDur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(193, 50);
            this.btnDur.TabIndex = 6;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // pnlTahta
            // 
            this.pnlTahta.Location = new System.Drawing.Point(223, 24);
            this.pnlTahta.Name = "pnlTahta";
            this.pnlTahta.Size = new System.Drawing.Size(452, 454);
            this.pnlTahta.TabIndex = 5;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(8, 32);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(193, 50);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnIlerle
            // 
            this.btnIlerle.Location = new System.Drawing.Point(8, 92);
            this.btnIlerle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIlerle.Name = "btnIlerle";
            this.btnIlerle.Size = new System.Drawing.Size(193, 50);
            this.btnIlerle.TabIndex = 1;
            this.btnIlerle.Text = "Adım Adım İlerle";
            this.btnIlerle.UseVisualStyleBackColor = true;
            this.btnIlerle.Click += new System.EventHandler(this.btnIlerle_Click);
            // 
            // lstOlasilikListesi
            // 
            this.lstOlasilikListesi.FormattingEnabled = true;
            this.lstOlasilikListesi.ItemHeight = 25;
            this.lstOlasilikListesi.Location = new System.Drawing.Point(693, 24);
            this.lstOlasilikListesi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstOlasilikListesi.Name = "lstOlasilikListesi";
            this.lstOlasilikListesi.Size = new System.Drawing.Size(298, 454);
            this.lstOlasilikListesi.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SatrancApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 504);
            this.Controls.Add(this.gbSatrancApp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SatrancApp";
            this.Text = "Satranc App";
            this.Load += new System.EventHandler(this.SatrancApp_Load);
            this.gbSatrancApp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSatrancApp;
        private System.Windows.Forms.Panel pnlTahta;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnIlerle;
        private System.Windows.Forms.ListBox lstOlasilikListesi;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Timer timer1;
    }
}