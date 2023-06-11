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
using Firebase.Database;
using Firebase.Database.Query;

namespace ChatApplication
{
    public partial class Kullanicilar : Form
    {
        private FirebaseClient _firebaseclient;
        private UserCredential _kullanicikimligi;

        public Kullanicilar(FirebaseClient firebaseClient, UserCredential kullanicikimligi)
        {
            _firebaseclient = firebaseClient;
            _kullanicikimligi = kullanicikimligi;
            InitializeComponent();
        }

        private void Kullanicilar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            anaekran anaekran = new anaekran(_kullanicikimligi);
            anaekran.Show();
        }

        //sayfa acıldıgında
        private async void Kullanicilar_Load(object sender, EventArgs e)
        {

            var kullanicilar = await _firebaseclient.Child("Kullanıcılar").OrderByKey().OnceAsync<Kullanicisinifi>();

            DataTable kullanicilarTablosu = new DataTable();
            kullanicilarTablosu.Columns.Add("Id");
            kullanicilarTablosu.Columns.Add("AdSoyad");

            foreach(var kullanici in kullanicilar)
            {
                if(kullanici.Object.KullaniciId == _kullanicikimligi.User.Uid) // giriş yapan kullanıcıyı 
                {
                    continue;
                }

                kullanicilarTablosu.Rows.Add(kullanici.Object.KullaniciId, kullanici.Object.TamAd);
            }

            cbkullanicilar.ValueMember = "Id";
            cbkullanicilar.DisplayMember = "AdSoyad";
            cbkullanicilar.DataSource = kullanicilarTablosu;
        }

        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            MesajEkrani mesaj = new MesajEkrani();
            mesaj.Show();
            this.Hide();
        }
    }
}
