using System;
using Firebase.Auth.Providers;
using Firebase.Auth;
using Firebase.Auth.Repository;
using Firebase.Storage;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ChatApplication
{
    public partial class Kayitol : Form
    {
        public Kayitol()
        {
            InitializeComponent();
        }
        
        private async void btnkayitol_Click(object sender, EventArgs e)
        //kayitol butonuna tıklayınca gerçekleşecek işlemler buraya 
        {
            string kayitemail = txtmail.Text;
            string kayitsifre = txtsifre.Text;
            string kayitsifretekrar = txtsifretekrar.Text;
            string kayit_tamad = txttamad.Text;

           

            if (string.IsNullOrEmpty(kayitemail) || string.IsNullOrEmpty(kayitsifre))
            {
                MessageBox.Show("email ya da şifre boş olamaz!!", "HATA!");
            }
            else if (txtsifre.Text != txtsifretekrar.Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor");
            }
            else if (!string.IsNullOrEmpty(kayitemail) || !string.IsNullOrEmpty(kayitsifre) ||
                !string.IsNullOrEmpty(kayitsifretekrar) || !string.IsNullOrEmpty(kayit_tamad))
            {
               
                var sonuc = await Firebase.FirebaseAuthBaglan()
                   .CreateUserWithEmailAndPasswordAsync(kayitemail, kayitsifre, kayit_tamad);
                 
               
 

                txtmail.Text = "";
                txtsifre.Text = "";
                txttamad.Text = "";
                txtsifretekrar.Text = "";

                MessageBox.Show("Kayıt başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt işlemi başarısız!");

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