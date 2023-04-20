using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ChatApplication.Tablolar;

namespace ChatApplication
{
    public partial class Kayitol : Form
    {
        public Kayitol()
        {
            InitializeComponent();
        }

       private async void btnkayitol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmail.Text) || string.IsNullOrEmpty(txtsifre.Text))
            {
                MessageBox.Show("email ya da şifre boş olamaz!!", "HATA!");
            }
            if (txtsifre.Text != txtsifretekrar.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor");
            }

            var kullanici = new kullanici 
            {
                email = txtmail.Text,
                sifre = txtsifre.Text,
                tamad = txttamad.Text
            };

            await Firebase.Baglan().Child("Kullanicilar").PostAsync(JsonConvert.SerializeObject(kullanici));

            MessageBox.Show("Kayıt İşlemi Başarılı");

            txtmail.Text = "";
            txtsifre.Text = "";
            txttamad.Text = "";
            txtsifretekrar.Text = "";
        }

        private void btnformclosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Girisyap girisekrani = new Girisyap();
            girisekrani.Show();
            
        }

        
    }
}

