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
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticoneCustomGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.SuspendLayout();
            // 
            // txtmail
            // 
            this.txtmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtmail.Font = new System.Drawing.Font("Tw Cen MT Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmail.Location = new System.Drawing.Point(88, 75);
            this.txtmail.Multiline = true;
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(262, 28);
            this.txtmail.TabIndex = 0;
            // 
            // txtsifre
            // 
            this.txtsifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtsifre.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifre.Location = new System.Drawing.Point(88, 139);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(262, 29);
            this.txtsifre.TabIndex = 1;
            // 
            // btnkayitol
            // 
            this.btnkayitol.BackColor = System.Drawing.Color.SkyBlue;
            this.btnkayitol.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkayitol.ForeColor = System.Drawing.Color.White;
            this.btnkayitol.Location = new System.Drawing.Point(150, 330);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(134, 51);
            this.btnkayitol.TabIndex = 2;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = false;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmail.ForeColor = System.Drawing.Color.White;
            this.lblmail.Location = new System.Drawing.Point(84, 52);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(47, 20);
            this.lblmail.TabIndex = 3;
            this.lblmail.Text = "Email";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifre.ForeColor = System.Drawing.Color.White;
            this.lblsifre.Location = new System.Drawing.Point(84, 116);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(39, 20);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "Şifre";
            // 
            // txtsifretekrar
            // 
            this.txtsifretekrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtsifretekrar.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifretekrar.Location = new System.Drawing.Point(88, 205);
            this.txtsifretekrar.Multiline = true;
            this.txtsifretekrar.Name = "txtsifretekrar";
            this.txtsifretekrar.PasswordChar = '*';
            this.txtsifretekrar.Size = new System.Drawing.Size(262, 32);
            this.txtsifretekrar.TabIndex = 5;
            // 
            // lblsifretakrar
            // 
            this.lblsifretakrar.AutoSize = true;
            this.lblsifretakrar.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifretakrar.ForeColor = System.Drawing.Color.White;
            this.lblsifretakrar.Location = new System.Drawing.Point(84, 182);
            this.lblsifretakrar.Name = "lblsifretakrar";
            this.lblsifretakrar.Size = new System.Drawing.Size(87, 20);
            this.lblsifretakrar.TabIndex = 6;
            this.lblsifretakrar.Text = "Şifre Tekrar";
            // 
            // lbltamad
            // 
            this.lbltamad.AutoSize = true;
            this.lbltamad.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltamad.ForeColor = System.Drawing.Color.White;
            this.lbltamad.Location = new System.Drawing.Point(84, 250);
            this.lbltamad.Name = "lbltamad";
            this.lbltamad.Size = new System.Drawing.Size(62, 20);
            this.lbltamad.TabIndex = 7;
            this.lbltamad.Text = "Tam ad";
            // 
            // txttamad
            // 
            this.txttamad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txttamad.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttamad.Location = new System.Drawing.Point(88, 273);
            this.txttamad.Multiline = true;
            this.txttamad.Name = "txttamad";
            this.txttamad.Size = new System.Drawing.Size(262, 31);
            this.txttamad.TabIndex = 8;
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.Blue;
            this.siticoneCustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(0, 404);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(463, 15);
            this.siticoneCustomGradientPanel1.TabIndex = 9;
            // 
            // siticoneCustomGradientPanel2
            // 
            this.siticoneCustomGradientPanel2.FillColor3 = System.Drawing.Color.Blue;
            this.siticoneCustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel2.Location = new System.Drawing.Point(0, 11);
            this.siticoneCustomGradientPanel2.Name = "siticoneCustomGradientPanel2";
            this.siticoneCustomGradientPanel2.Size = new System.Drawing.Size(463, 15);
            this.siticoneCustomGradientPanel2.TabIndex = 10;
            // 
            // Kayitol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(457, 431);
            this.Controls.Add(this.siticoneCustomGradientPanel2);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol ";
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
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel2;
    }
}