using EtkinlikYS.Model;
using Microsoft.Data.SqlClient;
using DAL; 

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
                return hlp.ExecuteNonQuery("Insert into tblKullanicilar (Ad, Soyad, TcNo, Email, Telefon, Adres, DTarihi, Cinsiyet, KullaniciAdi, Sifre) values (@Ad, @Soyad, @TcNo, @Email, @Telefon, @Adres, @DTarihi, @Cinsiyet, @KullaniciAdi, @Sifre)", p) > 0;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
