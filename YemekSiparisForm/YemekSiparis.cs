using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSiparisForm
{
    public class YemekSiparis
    {
        public string restoran;
        public string yemekCesitleri;
        public string malzemeler;
        public string icecek;
        public double fiyat;

        public YemekSiparis(string restoran , string yemekCesitleri , string malzemeler, string icecek , double fiyat)
        {
            this.restoran = restoran;
            this.yemekCesitleri = yemekCesitleri;
            this.malzemeler = malzemeler;
            this.icecek = icecek;
            this.fiyat = fiyat;
        }

        public YemekSiparis() { }


    }
}
