namespace ChatApplication
{
    partial class Kullanicilar
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
            this.lblkullanıcılar = new System.Windows.Forms.Label();
            this.cbkullanicilar = new System.Windows.Forms.ComboBox();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblkullanıcılar
            // 
            this.lblkullanıcılar.AutoSize = true;
            this.lblkullanıcılar.ForeColor = System.Drawing.Color.White;
            this.lblkullanıcılar.Location = new System.Drawing.Point(123, 34);
            this.lblkullanıcılar.Name = "lblkullanıcılar";
            this.lblkullanıcılar.Size = new System.Drawing.Size(88, 20);
            this.lblkullanıcılar.TabIndex = 1;
            this.lblkullanıcılar.Text = "Kullanıcılar";
            // 
            // cbkullanicilar
            // 
            this.cbkullanicilar.FormattingEnabled = true;
            this.cbkullanicilar.Location = new System.Drawing.Point(54, 68);
            this.cbkullanicilar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbkullanicilar.Name = "cbkullanicilar";
            this.cbkullanicilar.Size = new System.Drawing.Size(238, 28);
            this.cbkullanicilar.TabIndex = 2;
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(200)))));
            this.btnMesajGonder.Location = new System.Drawing.Point(116, 143);
            this.btnMesajGonder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(111, 60);
            this.btnMesajGonder.TabIndex = 3;
            this.btnMesajGonder.Text = "Mesaj Gönder";
            this.btnMesajGonder.UseVisualStyleBackColor = false;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(350, 327);
            this.Controls.Add(this.btnMesajGonder);
            this.Controls.Add(this.cbkullanicilar);
            this.Controls.Add(this.lblkullanıcılar);
            this.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kullanicilar_FormClosed);
            this.Load += new System.EventHandler(this.Kullanicilar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblkullanıcılar;
        private System.Windows.Forms.ComboBox cbkullanicilar;
        private System.Windows.Forms.Button btnMesajGonder;
    }
}