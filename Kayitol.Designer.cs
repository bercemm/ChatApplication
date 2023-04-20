namespace ChatApplication
{
    partial class Kayitol
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
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnkayitol = new System.Windows.Forms.Button();
            this.lblmail = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.txtsifretekrar = new System.Windows.Forms.TextBox();
            this.lblsifretakrar = new System.Windows.Forms.Label();
            this.lbltamad = new System.Windows.Forms.Label();
            this.txttamad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(110, 44);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(207, 22);
            this.txtmail.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(110, 94);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(207, 22);
            this.txtsifre.TabIndex = 1;
            // 
            // btnkayitol
            // 
            this.btnkayitol.Location = new System.Drawing.Point(167, 235);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(75, 23);
            this.btnkayitol.TabIndex = 2;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = true;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Location = new System.Drawing.Point(107, 25);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(41, 16);
            this.lblmail.TabIndex = 3;
            this.lblmail.Text = "Email";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Location = new System.Drawing.Point(107, 75);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(34, 16);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "Şifre";
            // 
            // txtsifretekrar
            // 
            this.txtsifretekrar.Location = new System.Drawing.Point(110, 142);
            this.txtsifretekrar.Name = "txtsifretekrar";
            this.txtsifretekrar.PasswordChar = '*';
            this.txtsifretekrar.Size = new System.Drawing.Size(207, 22);
            this.txtsifretekrar.TabIndex = 5;
            // 
            // lblsifretakrar
            // 
            this.lblsifretakrar.AutoSize = true;
            this.lblsifretakrar.Location = new System.Drawing.Point(107, 123);
            this.lblsifretakrar.Name = "lblsifretakrar";
            this.lblsifretakrar.Size = new System.Drawing.Size(77, 16);
            this.lblsifretakrar.TabIndex = 6;
            this.lblsifretakrar.Text = "Şifre Tekrar";
            // 
            // lbltamad
            // 
            this.lbltamad.AutoSize = true;
            this.lbltamad.Location = new System.Drawing.Point(107, 175);
            this.lbltamad.Name = "lbltamad";
            this.lbltamad.Size = new System.Drawing.Size(54, 16);
            this.lbltamad.TabIndex = 7;
            this.lbltamad.Text = "Tam ad";
            
            // 
            // txttamad
            // 
            this.txttamad.Location = new System.Drawing.Point(110, 195);
            this.txttamad.Name = "txttamad";
            this.txttamad.PasswordChar = '*';
            this.txttamad.Size = new System.Drawing.Size(207, 22);
            this.txttamad.TabIndex = 8;
            // 
            // Kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 431);
            this.Controls.Add(this.txttamad);
            this.Controls.Add(this.lbltamad);
            this.Controls.Add(this.lblsifretakrar);
            this.Controls.Add(this.txtsifretekrar);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.btnkayitol);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Kayitol";
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.btnformclosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button btnkayitol;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox txtsifretekrar;
        private System.Windows.Forms.Label lblsifretakrar;
        private System.Windows.Forms.Label lbltamad;
        private System.Windows.Forms.TextBox txttamad;
    }
}