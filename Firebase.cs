using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;
using Firebase.Database;


namespace ChatApplication
{
   public static class Firebase
    {
        public static string Auth = "AIzaSyDLgYzwYJqPcBqMbejSmx8GrcqgYmWDXUw"; // veri tabanına bağlanmak için firbase kimlik bilgisi

        public static FirebaseClient Baglan() 
        {
            return new FirebaseClient(
                "https://chatapplication-cd9f6-default-rtdb.firebaseio.com/",
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(Auth)
                }); 
        }
        public static FirebaseAuthClient FirebaseAuthBaglan()
        {

            var config = new FirebaseAuthConfig
            {
                ApiKey = Auth,
                AuthDomain = "chatapplication-cd9f6.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },

                UserRepository = new FileUserRepository("FirebaseSample")
            };

            var client = new FirebaseAuthClient(config);

            return client;
        }
    }
}
