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
            this.cıkısyapbtn = new System.Windows.Forms.Button();
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
            this.kullanicigoruntulebtn.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // cıkısyapbtn
            // 
            this.cıkısyapbtn.Location = new System.Drawing.Point(26, 83);
            this.cıkısyapbtn.Name = "cıkısyapbtn";
            this.cıkısyapbtn.Size = new System.Drawing.Size(188, 25);
            this.cıkısyapbtn.TabIndex = 1;
            this.cıkısyapbtn.Text = "Çıkış Yap";
            this.cıkısyapbtn.UseVisualStyleBackColor = true;
            // 
            // anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 149);
            this.Controls.Add(this.cıkısyapbtn);
            this.Controls.Add(this.kullanicigoruntulebtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "anaekran";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button kullanicigoruntulebtn;
        private System.Windows.Forms.Button cıkısyapbtn;
    }
}