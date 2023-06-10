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
            this.SuspendLayout();
            // 
            // lblkullanıcılar
            // 
            this.lblkullanıcılar.AutoSize = true;
            this.lblkullanıcılar.Location = new System.Drawing.Point(52, 9);
            this.lblkullanıcılar.Name = "lblkullanıcılar";
            this.lblkullanıcılar.Size = new System.Drawing.Size(71, 16);
            this.lblkullanıcılar.TabIndex = 1;
            this.lblkullanıcılar.Text = "Kullanıcılar";
            // 
            // cbkullanicilar
            // 
            this.cbkullanicilar.FormattingEnabled = true;
            this.cbkullanicilar.Location = new System.Drawing.Point(34, 28);
            this.cbkullanicilar.Name = "cbkullanicilar";
            this.cbkullanicilar.Size = new System.Drawing.Size(121, 24);
            this.cbkullanicilar.TabIndex = 2;
            // 
            // Kullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 282);
            this.Controls.Add(this.cbkullanicilar);
            this.Controls.Add(this.lblkullanıcılar);
            this.Name = "Kullanicilar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Kullanicilar_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblkullanıcılar;
        private System.Windows.Forms.ComboBox cbkullanicilar;
    }
}