using DAL;
using EtkinlikYS.Model;
using System;
using System.Data.SqlClient;

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
                    new SqlParameter("@Sifre", user.Sifre ?? (object)DBNull.Value),
                    new SqlParameter("@Yetki", "user")
                };

                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("Insert into Kullanicilar (Ad, Soyad, Email, Telefon, Adres, DogumTarihi, Cinsiyet, KullaniciAdi, Sifre,Yetki) values (@Ad, @Soyad, @Email, @Telefon, @Adres, @DTarihi, @Cinsiyet, @KullaniciAdi, @Sifre,@Yetki)", p) > 0;
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


        public Kullanici KullaniciBul(string kullaniciAdi, string sifre)
        {
            var hlp = Helper.SDP;
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@KullaniciAdi", kullaniciAdi),
                    new SqlParameter("@Sifre", sifre)
                };

                var dr = hlp.ExecuteReader("SELECT * FROM Kullanicilar WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", p);
                Kullanici kullanici = null;
                if (dr.Read())
                {
                    kullanici = new Kullanici
                    {
                        Kullaniciid = Convert.ToInt32(dr["KullaniciId"]),
                        Ad = dr["Ad"].ToString(),
                        Soyad = dr["Soyad"].ToString(),
                        Email = dr["Email"].ToString(),
                        Telefon = dr["Telefon"].ToString(),
                        Adres = dr["Adres"].ToString(),
                        DTarihi = dr["DogumTarihi"].ToString(),
                        Cinsiyet = dr["Cinsiyet"].ToString(),
                        KullaniciAdi = dr["KullaniciAdi"].ToString(),
                        Sifre = dr["Sifre"].ToString(),
                        Yetki = dr["Yetki"].ToString()
                    };
                }
                dr.Close();
                return kullanici;
            }
            catch (SqlException ex)
            {
                throw new Exception("Veritabanı hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                hlp.DisposeEt();
            }
        }





    }
}
