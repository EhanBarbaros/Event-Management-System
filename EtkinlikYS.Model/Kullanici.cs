using System;

namespace EtkinlikYS.Model
{
    public class Kullanici
    {
        public int? Kullaniciid { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string DTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; } = "user";

        public byte[] ProfilFotografi { get; set; }
    }
}
