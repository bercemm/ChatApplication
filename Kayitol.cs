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
using ChatApplication.Tablolar;

namespace ChatApplication
{
    public partial class Kayitol : Form
    {
        public Kayitol()
        {
            InitializeComponent();
        }
        public async Task KayitolAsync()
        {

            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyDLgYzwYJqPcBqMbejSmx8GrcqgYmWDXUw",
                AuthDomain = "chatapplication-cd9f6.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
             {

        new GoogleProvider().AddScopes("email"),
        new EmailProvider()

             },
                // WPF:
                UserRepository = new FileUserRepository("FirebaseSample")


                UserRepository = new StorageRepository() // persist data into ApplicationDataContainer
            };

            // ...and create your FirebaseAuthClient
            var client = new FirebaseAuthClient(config);
            var userCredential = await client.CreateUserWithEmailAndPasswordAsync("email", "pwd", "Display Name");


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
                var kullanici = new kullanici();
                kullanici.email = txtmail.Text;
                kullanici.sifre = txtsifre.Text;
                kullanici.tamad = txttamad.Text;


                string veri = JsonConvert.SerializeObject(kullanici);
                await Firebase.Baglan().Child("Kullanicilar").PostAsync(veri);


                //MessageBox.Show("Kayıt İşlemi Başarılı");

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