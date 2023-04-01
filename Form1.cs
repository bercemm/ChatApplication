using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtKullanici.Text;
            string sifre = txtSifre.Text;

          
            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Giris yapilamadi","Hata!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Giris yapildi","Basarili!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
      
        }
    }
}
