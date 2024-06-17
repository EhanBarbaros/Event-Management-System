using DAL;
using EtkinlikYS.Model;
using System;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

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
                    new SqlParameter("@Yetki", "user"),
                    new SqlParameter("@ProfilFotografi", user.ProfilFotografi ?? (object)DBNull.Value)
                };

                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("Insert into Kullanicilar (Ad, Soyad, Email, Telefon, Adres, DogumTarihi, Cinsiyet, KullaniciAdi, Sifre,Yetki,ProfilFotografi) values (@Ad, @Soyad, @Email, @Telefon, @Adres, @DTarihi, @Cinsiyet, @KullaniciAdi, @Sifre,@Yetki,@ProfilFotografi)", p) > 0;
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
                        Yetki = dr["Yetki"].ToString(),
                        ProfilFotografi = dr["ProfilFotografi"] as byte[]
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


        public bool KullaniciGuncelle(Kullanici kullanici)
        {
            try
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@KullaniciId", kullanici.Kullaniciid),
                    new SqlParameter("@Ad", kullanici.Ad ?? (object)DBNull.Value),
                    new SqlParameter("@Soyad", kullanici.Soyad ?? (object)DBNull.Value),
                    new SqlParameter("@Email", kullanici.Email ?? (object)DBNull.Value),
                    new SqlParameter("@Telefon", kullanici.Telefon ?? (object)DBNull.Value),
                    new SqlParameter("@Adres", kullanici.Adres ?? (object)DBNull.Value),
                    new SqlParameter("@DTarihi", kullanici.DTarihi ?? (object)DBNull.Value),
                    new SqlParameter("@Cinsiyet", kullanici.Cinsiyet ?? (object)DBNull.Value),
                    new SqlParameter("@ProfilFotografi", kullanici.ProfilFotografi ?? (object)DBNull.Value)
                };

                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("UPDATE Kullanicilar SET Ad=@Ad, Soyad=@Soyad, Email=@Email, Telefon=@Telefon, Adres=@Adres, DogumTarihi=@DTarihi, Cinsiyet=@Cinsiyet, ProfilFotografi=@ProfilFotografi WHERE KullaniciId=@KullaniciId", parameters) > 0;
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
