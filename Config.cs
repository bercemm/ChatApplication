using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChatApplication
{
    public class Config
    {
        private string _authdomain;
        private string _apikey;
        private string _firebasedomain;
        public Config()
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");
            _authdomain = config.DocumentElement.SelectSingleNode("/FireBase/AuthDomain").InnerText.Trim();
            _apikey = config.DocumentElement.SelectSingleNode("/FireBase/ApiKey").InnerText.Trim();
            _firebasedomain = config.DocumentElement.SelectSingleNode("/FireBase/FireBaseDomain").InnerText.Trim();
        }
        public string AuthDomain
        {
            get { return _authdomain; }
        }
        public string ApiKey
        {
            get { return _apikey; }
        }    

        public string FirebaseDomain
        {
            get { return _firebasedomain; }
        }
    }
}
