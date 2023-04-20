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
    public partial class Kayitol : Form
    {
        public Kayitol()
        {
            InitializeComponent();
        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmail.Text) || string.IsNullOrEmpty(txtsifre.Text)) 
            {
                MessageBox.Show("email ya da şifre boş olamaz!!", "HATA!");
            }
            if (txtsifre.Text != txtsifretekrar.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor");

            }
        }

        private void btnformclosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Girisyap girisekrani = new Girisyap();
            girisekrani.Show();
            
        }
        

      
    }
}
