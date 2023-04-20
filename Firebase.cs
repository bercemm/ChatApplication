using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;

namespace ChatApplication
{
   public static class Firebase
    {
        public static string Auth = "AIzaSyAsd7CLD9ZmI9Hn61_sAA1b-ZR2a_tUK2c";

        public static FirebaseClient Baglan()
        {
            return new FirebaseClient(
                "https://chatapplicationbercem-default-rtdb.firebaseio.com/",
                new FirebaseOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(Auth)
                }); 
        }
        
    }
}
