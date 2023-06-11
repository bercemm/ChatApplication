namespace ChatApplication
{
    partial class MesajEkrani
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
            this.mesajyollatxtbx = new System.Windows.Forms.TextBox();
            this.msjyollabuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mesajyollatxtbx
            // 
            this.mesajyollatxtbx.Location = new System.Drawing.Point(38, 66);
            this.mesajyollatxtbx.Multiline = true;
            this.mesajyollatxtbx.Name = "mesajyollatxtbx";
            this.mesajyollatxtbx.Size = new System.Drawing.Size(306, 31);
            this.mesajyollatxtbx.TabIndex = 0;
            // 
            // msjyollabuton
            // 
            this.msjyollabuton.Location = new System.Drawing.Point(119, 143);
            this.msjyollabuton.Name = "msjyollabuton";
            this.msjyollabuton.Size = new System.Drawing.Size(129, 48);
            this.msjyollabuton.TabIndex = 1;
            this.msjyollabuton.Text = "Mesajı Gönder";
            this.msjyollabuton.UseVisualStyleBackColor = true;
            // 
            // MesajEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(372, 265);
            this.Controls.Add(this.msjyollabuton);
            this.Controls.Add(this.mesajyollatxtbx);
            this.Font = new System.Drawing.Font("Tw Cen MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MesajEkrani";
            this.Text = "Mesaj Yollama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox mesajyollatxtbx;
        private System.Windows.Forms.Button msjyollabuton;
    }
}