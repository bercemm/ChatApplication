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
            this.kullanicigoruntulebtn.Location = new System.Drawing.Point(26, 34);
            this.kullanicigoruntulebtn.Name = "kullanicigoruntulebtn";
            this.kullanicigoruntulebtn.Size = new System.Drawing.Size(188, 23);
            this.kullanicigoruntulebtn.TabIndex = 0;
            this.kullanicigoruntulebtn.Text = "Kullanıcıları Görüntüle";
            this.kullanicigoruntulebtn.UseVisualStyleBackColor = true;
            this.kullanicigoruntulebtn.Click += new System.EventHandler(this.kullanicigoruntulebtn_Click);
            // 
            // cikisyapbtn
            // 
            this.cikisyapbtn.Location = new System.Drawing.Point(26, 83);
            this.cikisyapbtn.Name = "cikisyapbtn";
            this.cikisyapbtn.Size = new System.Drawing.Size(188, 25);
            this.cikisyapbtn.TabIndex = 1;
            this.cikisyapbtn.Text = "Çıkış Yap";
            this.cikisyapbtn.UseVisualStyleBackColor = true;
            this.cikisyapbtn.Click += new System.EventHandler(this.cikisyapbtn_Click);
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 149);
            this.Controls.Add(this.cikisyapbtn);
            this.Controls.Add(this.kullanicigoruntulebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "anaekran";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullanicigoruntulebtn;
        private System.Windows.Forms.Button cikisyapbtn;
    }
}