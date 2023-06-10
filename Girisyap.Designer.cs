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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(40, 67);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSifre.Location = new System.Drawing.Point(40, 137);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(198, 22);
            this.txtSifre.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGiris.ForeColor = System.Drawing.Color.Transparent;
            this.btnGiris.Location = new System.Drawing.Point(101, 165);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(91, 27);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Indigo;
            this.lblEmail.Location = new System.Drawing.Point(37, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.ForeColor = System.Drawing.Color.Indigo;
            this.lblsifre.Location = new System.Drawing.Point(37, 108);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(34, 16);
            this.lblsifre.TabIndex = 4;
            this.lblsifre.Text = "Şifre";
            // 
            // btnkayitol
            // 
            this.btnkayitol.BackColor = System.Drawing.Color.SkyBlue;
            this.btnkayitol.ForeColor = System.Drawing.Color.Transparent;
            this.btnkayitol.Location = new System.Drawing.Point(101, 224);
            this.btnkayitol.Name = "btnkayitol";
            this.btnkayitol.Size = new System.Drawing.Size(91, 27);
            this.btnkayitol.TabIndex = 5;
            this.btnkayitol.Text = "Kayıt Ol";
            this.btnkayitol.UseVisualStyleBackColor = false;
            this.btnkayitol.Click += new System.EventHandler(this.btnkayitol_Click);
            // 
            // gosterCB
            // 
            this.gosterCB.AutoSize = true;
            this.gosterCB.ForeColor = System.Drawing.Color.AliceBlue;
            this.gosterCB.Location = new System.Drawing.Point(244, 139);
            this.gosterCB.Name = "gosterCB";
            this.gosterCB.Size = new System.Drawing.Size(69, 20);
            this.gosterCB.TabIndex = 6;
            this.gosterCB.Text = "Göster";
            this.gosterCB.UseVisualStyleBackColor = true;
            this.gosterCB.CheckedChanged += new System.EventHandler(this.checkboxtxt_CheckedChanged);
            // 
            // girisPb
            // 
            this.girisPb.BackColor = System.Drawing.Color.MediumBlue;
            this.girisPb.ForeColor = System.Drawing.Color.Blue;
            this.girisPb.Location = new System.Drawing.Point(101, 198);
            this.girisPb.Name = "girisPb";
            this.girisPb.Size = new System.Drawing.Size(91, 20);
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
            // Girisyap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(318, 343);
            this.Controls.Add(this.girisPb);
            this.Controls.Add(this.gosterCB);
            this.Controls.Add(this.btnkayitol);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtEmail);
            this.ForeColor = System.Drawing.Color.Plum;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Girisyap";
            this.Text = "Giris Ekrani";
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
    }
}

