namespace ChatApplication
{
    partial class Girisyap
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblsifre = new System.Windows.Forms.Label();
            this.btnkayitol = new System.Windows.Forms.Button();
            this.gosterCB = new System.Windows.Forms.CheckBox();
            this.girisPb = new System.Windows.Forms.ProgressBar();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.siticoneCustomGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticoneCustomGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(45, 91);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSifre.Location = new System.Drawing.Point(45, 172);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(222, 26);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiris.Location = new System.Drawing.Point(114, 236);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(102, 34);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Info;
            this.lblEmail.Location = new System.Drawing.Point(42, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.ForeColor = System.Drawing.SystemColors.Info;
            this.lblsifre.Location = new System.Drawing.Point(42, 135);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(39, 20);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "Şifre";
            // 
            // btnkayitol
            // 
            this.btnkayitol.BackColor = System.Drawing.Color.SkyBlue;
            this.btnkayitol.ForeColor = System.Drawing.Color.Transparent;
            this.btnkayitol.Location = new System.Drawing.Point(114, 340);
            this.btnkayitol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(102, 34);
            this.btnkayitol.TabIndex = 5;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = false;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // gosterCB
            // 
            this.gosterCB.AutoSize = true;
            this.gosterCB.ForeColor = System.Drawing.Color.AliceBlue;
            this.gosterCB.Location = new System.Drawing.Point(274, 174);
            this.gosterCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gosterCB.Name = "gosterCB";
            this.gosterCB.Size = new System.Drawing.Size(76, 24);
            this.gosterCB.TabIndex = 6;
            this.gosterCB.Text = "Göster";
            this.gosterCB.UseVisualStyleBackColor = true;
            this.gosterCB.CheckedChanged += new System.EventHandler(this.checkboxtxt_CheckedChanged);
            // 
            // girisPb
            // 
            this.girisPb.BackColor = System.Drawing.Color.MediumBlue;
            this.girisPb.ForeColor = System.Drawing.Color.Blue;
            this.girisPb.Location = new System.Drawing.Point(114, 278);
            this.girisPb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.girisPb.Name = "girisPb";
            this.girisPb.Size = new System.Drawing.Size(102, 25);
            this.girisPb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.girisPb.TabIndex = 7;
            this.girisPb.Visible = false;
            this.girisPb.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.Blue;
            this.siticoneCustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(1, 404);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(362, 13);
            this.siticoneCustomGradientPanel1.TabIndex = 8;
            // 
            // siticoneCustomGradientPanel2
            // 
            this.siticoneCustomGradientPanel2.FillColor3 = System.Drawing.Color.Blue;
            this.siticoneCustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.siticoneCustomGradientPanel2.Location = new System.Drawing.Point(1, 12);
            this.siticoneCustomGradientPanel2.Name = "siticoneCustomGradientPanel2";
            this.siticoneCustomGradientPanel2.Size = new System.Drawing.Size(362, 13);
            this.siticoneCustomGradientPanel2.TabIndex = 9;
            // 
            // Girisyap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(358, 429);
            this.Controls.Add(this.siticoneCustomGradientPanel2);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.Controls.Add(this.girisPb);
            this.Controls.Add(this.gosterCB);
            this.Controls.Add(this.btnkayitol);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Plum;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Girisyap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Girisyap_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.Button btnkayitol;
        private System.Windows.Forms.CheckBox gosterCB;
        private System.Windows.Forms.ProgressBar girisPb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel2;
    }
}

