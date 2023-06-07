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

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            Kullanicisinifi kullanici1 = new Kullanicisinifi();
            kullanici1.displayname = "bercem";
            Kullanicisinifi kullanici2 = new Kullanicisinifi();
            kullanici2.displayname = "seda";

            //await firebaseclient.Child("Kullanıcılar").PutAsync(kullanici1);
            //await firebaseclient.Child("Kullanıcılar").PutAsync(kullanici2);

        }
    }
}
