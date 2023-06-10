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
    public partial class anaekran : Form
    {
        private FirebaseClient _firebaseistemci;
        private UserCredential _kullanicikimligi;
        public anaekran(UserCredential kullanicikimligi)
        {
            Config config = new Config();
            InitializeComponent();
            _kullanicikimligi = kullanicikimligi;
            _firebaseistemci = new FirebaseClient(
                        config.FirebaseDomain,
                        new FirebaseOptions
                        {
                            AuthTokenAsyncFactory = () => kullanicikimligi.User.GetIdTokenAsync()
                            //authtoken'a yetkili kullanıcının token'ınını verdik
                       });


        }

        private void kullanicigoruntulebtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicigoruntule = new Kullanicilar(_firebaseistemci, _kullanicikimligi);
            kullanicigoruntule.Show();
            this.Hide();
        }

        private void cikisyapbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Girisyap giris = new Girisyap(new Config());
            giris.Show();
        }
    }
}
