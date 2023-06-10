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
        private FirebaseClient firebaseistemci;
        private UserCredential kullanicikimligi;
        public anaekran(UserCredential kullanicikimligi)
        {
            InitializeComponent();
            this.kullanicikimligi = kullanicikimligi;
            this.firebaseistemci = new FirebaseClient(
                        "https://chatapplication-cd9f6-default-rtdb.firebaseio.com/",
                        new FirebaseOptions
                        {
                            AuthTokenAsyncFactory = () => kullanicikimligi.User.GetIdTokenAsync()
                            //authtoken'a yetkili kullanıcının token'ınını verdik
                       });


        }

        private void kullanicigoruntulebtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicigoruntule = new Kullanicilar(firebaseistemci, kullanicikimligi);
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
