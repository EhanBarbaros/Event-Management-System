using System;
using System.Collections.Generic;
using System.Text;

namespace EtkinlikYS.Model
{
    public class Etkinlik
    {
        public int EtkinlikID { get; set; }
        public string EtkinlikAdi { get; set; }
        public string Fiyat { get; set; }
        public string EtkinlikTuru { get; set; }
        public int ToplamKontejan { get; set; }
        public int MevcutKontejan { get; set; }
        public DateTime EtkinlikTarihi { get; set; }
        public string EtkinlikYeri { get; set; }
        public string Aciklama { get; set; }
        public byte[] Resim { get; set; }
        public int OlusturanKullaniciID { get; set; }
    }
}
