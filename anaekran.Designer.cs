namespace ChatApplication
{
    partial class anaekran
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
            this.kullanicigoruntulebtn = new System.Windows.Forms.Button();
            this.cikisyapbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullanicigoruntulebtn
            // 
            this.kullanicigoruntulebtn.AllowDrop = true;
            this.kullanicigoruntulebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kullanicigoruntulebtn.Location = new System.Drawing.Point(29, 42);
            this.kullanicigoruntulebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.kullanicigoruntulebtn.Name = "kullanicigoruntulebtn";
            this.kullanicigoruntulebtn.Size = new System.Drawing.Size(212, 29);
            this.kullanicigoruntulebtn.TabIndex = 0;
            this.kullanicigoruntulebtn.Text = "Kullanıcıları Görüntüle";
            this.kullanicigoruntulebtn.UseVisualStyleBackColor = false;
            this.kullanicigoruntulebtn.Click += new System.EventHandler(this.kullanicigoruntulebtn_Click);
            // 
            // cikisyapbtn
            // 
            this.cikisyapbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cikisyapbtn.Location = new System.Drawing.Point(29, 104);
            this.cikisyapbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cikisyapbtn.Name = "cikisyapbtn";
            this.cikisyapbtn.Size = new System.Drawing.Size(212, 31);
            this.cikisyapbtn.TabIndex = 1;
            this.cikisyapbtn.Text = "Çıkış Yap";
            this.cikisyapbtn.UseVisualStyleBackColor = false;
            this.cikisyapbtn.Click += new System.EventHandler(this.cikisyapbtn_Click);
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(278, 185);
            this.Controls.Add(this.cikisyapbtn);
            this.Controls.Add(this.kullanicigoruntulebtn);
            this.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "anaekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullanicigoruntulebtn;
        private System.Windows.Forms.Button cikisyapbtn;
    }
}