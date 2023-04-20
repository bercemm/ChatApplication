using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Tablolar // bu class firebase de bi tabloyu temsil eder
{
    public class kullanici //otomatik internal oluyor bunu public olarak değiştirmemiz gerekiyor ki her yerden erişilebilsin
    {
        //aşağıdaki özellikler kullanıcı tablosundaki sütunlara denk gelir.
        public string email { get; set; }
        public string sifre { get; set; }
        public string tamad { get; set; }

    }
}
