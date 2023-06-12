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
    public partial class MesajEkrani : Form
    {
        private FirebaseClient _firebaseClient;
        private UserCredential _userCredential;
        private string _aliciId;

        public MesajEkrani(FirebaseClient firebaseClient, UserCredential userCredential, string aliciId)
        {
            _firebaseClient = firebaseClient;
            _userCredential = userCredential;
            _aliciId = aliciId;
            InitializeComponent();
        }

        private async Task MesajEkrani_LoadAsync(object sender, EventArgs e)
        {
            var gonderenId = _userCredential.User.Uid;
            var aliciId = _aliciId;

            var kullanicilar = await _firebaseClient.Child("Kullanıcılar").OnceAsync<Kullanicisinifi>(); // tüm kullanıcıları çe
        }

      

        private async void msjyollabuton_Click(object sender, EventArgs e)
        {
            var mesajIcerik = mesajyollatxtbx.Text;
            var gonderenId = _userCredential.User.Uid;
            var aliciId = _aliciId;


            var yeniMesaj = new MesajSinifi()
            {
                GonderenId = gonderenId,
                AlanId = aliciId,
                Mesaj = mesajIcerik,
            };

            await _firebaseClient.Child("mesajlar").PostAsync(yeniMesaj);
            mesajyollatxtbx.Text = "";
        }
    }
}
