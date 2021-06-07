namespace DatabaseConnect
{
    partial class Form1
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
            this.buttonAc = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.buttonDurum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAc
            // 
            this.buttonAc.Location = new System.Drawing.Point(78, 105);
            this.buttonAc.Name = "buttonAc";
            this.buttonAc.Size = new System.Drawing.Size(150, 61);
            this.buttonAc.TabIndex = 0;
            this.buttonAc.Text = "Bağlantıyı Aç";
            this.buttonAc.UseVisualStyleBackColor = true;
            this.buttonAc.Click += new System.EventHandler(this.buttonAc_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.Location = new System.Drawing.Point(317, 105);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(155, 61);
            this.buttonKapat.TabIndex = 1;
            this.buttonKapat.Text = "Bağlantıyı Kapat";
            this.buttonKapat.UseVisualStyleBackColor = true;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // buttonDurum
            // 
            this.buttonDurum.Location = new System.Drawing.Point(126, 196);
            this.buttonDurum.Name = "buttonDurum";
            this.buttonDurum.Size = new System.Drawing.Size(297, 61);
            this.buttonDurum.TabIndex = 2;
            this.buttonDurum.Text = "Bağlantı Durumu (Açık mı Kapalı mı)";
            this.buttonDurum.UseVisualStyleBackColor = true;
            this.buttonDurum.Click += new System.EventHandler(this.buttonDurum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 417);
            this.Controls.Add(this.buttonDurum);
            this.Controls.Add(this.buttonKapat);
            this.Controls.Add(this.buttonAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAc;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Button buttonDurum;
    }
}

