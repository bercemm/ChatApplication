using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Database;
using Firebase.Database.Query;

namespace ChatApplication
{
    public partial class Kayitol : Form
    {
        private FirebaseAuthClient client;
        private FirebaseClient firebaseistemci;
        public Kayitol()
        {
            Config ayarlar = new Config();
            var config = new FirebaseAuthConfig
            {
                ApiKey = ayarlar.ApiKey,
                AuthDomain = ayarlar.AuthDomain,
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
            };
            this.client = new FirebaseAuthClient(config);

            this.firebaseistemci = new FirebaseClient(
                "https://chatapplicationn-96e04-default-rtdb.firebaseio.com/",
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(ayarlar.ApiKey)

                });
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

                var sonuc = await client.CreateUserWithEmailAndPasswordAsync(kayitemail, kayitsifre, kayit_tamad);

                Kullanicisinifi kullanici = new Kullanicisinifi
                {
                    KullaniciId = sonuc.User.Uid,
                    Email = kayitemail,
                    TamAd = kayit_tamad
                };

                await firebaseistemci.Child("Kullanıcılar").PostAsync(kullanici);
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
            Girisyap girisekrani = new Girisyap(new Config());
            girisekrani.Show();

        }
    }
}