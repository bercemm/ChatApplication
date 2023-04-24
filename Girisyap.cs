using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;

namespace ChatApplication
{
    public partial class Girisyap : Form
    {
        public Girisyap()
        {
            InitializeComponent();
        }


        private async void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtEmail.Text;
            string sifre = txtSifre.Text;


            if (string.IsNullOrEmpty(kullaniciadi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Giris yapilamadi", "Hata!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //yaptıgımız giriş işlemi sonuc değişkenine eşitlendi
                    var sonuc = await Firebase.FirebaseAuthBaglan().SignInWithEmailAndPasswordAsync(kullaniciadi, sifre);
                    if (sonuc.OperationType == OperationType.SignIn)
                    {
                        MessageBox.Show("Giris yapildi", "Basarili!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Bu bilgilerde kullanici bulunamadi");
                }
                catch (Exception E) //try içinde hata varsa buraya geçer
                {
                    MessageBox.Show("Bu bilgilerde kullanici bulunamadi");
                }


            }

        }

        private void btnkayitol_Click(object sender, EventArgs e)
        {
            Kayitol kayitolsayfasi = new Kayitol();
            kayitolsayfasi.Show(); //kayıt ol butonuna tıklandıgında kayıt ol ekranını açar.
            this.Hide(); //kayıt ekranı çıktığında logini gizler. this=logini temsil eder

        }


    }
}
