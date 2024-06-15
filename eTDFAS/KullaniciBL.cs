using EtkinlikYS.Model;
using System.Data.SqlClient;
using DAL;
using System;

namespace EtkinlikYS.BLL
{
    public class KullaniciBL
    {
        public bool KullaniciKayit(Kullanici user)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Ad", user.Ad ?? (object)DBNull.Value),
                    new SqlParameter("@Soyad", user.Soyad ?? (object)DBNull.Value),
                    new SqlParameter("@Email", user.Email ?? (object)DBNull.Value),
                    new SqlParameter("@Telefon", user.Telefon ?? (object)DBNull.Value),
                    new SqlParameter("@Adres", user.Adres ?? (object)DBNull.Value),
                    new SqlParameter("@DTarihi", user.DTarihi ?? (object)DBNull.Value),
                    new SqlParameter("@Cinsiyet", user.Cinsiyet ?? (object)DBNull.Value),
                    new SqlParameter("@KullaniciAdi", user.KullaniciAdi ?? (object)DBNull.Value),
                    new SqlParameter("@Sifre", user.Sifre ?? (object)DBNull.Value)
                };

                var hlp = Helper.SDP;
                string query = "INSERT INTO Kullanicilar (Ad, Soyad, Email, Telefon, Adres, DogumTarihi, Cinsiyet, KullaniciAdi, Sifre) " +
                               "VALUES (@Ad, @Soyad, @Email, @Telefon, @Adres, @DTarihi, @Cinsiyet, @KullaniciAdi, @Sifre)";
                return hlp.ExecuteNonQuery(query, p) > 0;
            }
            catch (SqlException ex)
            {
                throw new Exception("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
