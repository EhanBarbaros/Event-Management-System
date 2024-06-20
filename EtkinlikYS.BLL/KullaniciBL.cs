using DAL;
using EtkinlikYS.Model;
using System;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Collections.Generic;

namespace EtkinlikYS.BLL
{
    public class KullaniciBL
    {
        public bool KullaniciKayit(Kullanici kullanici)
        {
            if (DateTime.TryParse(kullanici.DTarihi, out DateTime parsedDate))
            {
                kullanici.DTarihi = parsedDate.ToString("yyyy-MM-dd");
            }
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@Ad", kullanici.Ad ?? (object)DBNull.Value),
                    new SqlParameter("@Soyad", kullanici.Soyad ?? (object)DBNull.Value),
                    new SqlParameter("@Email", kullanici.Email ?? (object)DBNull.Value),
                    new SqlParameter("@Telefon", kullanici.Telefon ?? (object)DBNull.Value),
                    new SqlParameter("@Adres", kullanici.Adres ?? (object)DBNull.Value),
                    new SqlParameter("@DTarihi", kullanici.DTarihi ?? (object)DBNull.Value),
                    new SqlParameter("@Cinsiyet", kullanici.Cinsiyet ?? (object)DBNull.Value),
                    new SqlParameter("@KullaniciAdi", kullanici.KullaniciAdi ?? (object)DBNull.Value),
                    new SqlParameter("@Sifre", kullanici.Sifre ?? (object)DBNull.Value),
                    new SqlParameter("@Yetki", "user"),
                    new SqlParameter("@ProfilFotografi", kullanici.ProfilFotografi ?? (object)DBNull.Value),
                    new SqlParameter("@Bakiye", kullanici.Bakiye)
                };

                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("Insert into Kullanicilar (Ad, Soyad, Email, Telefon, Adres, DogumTarihi, Cinsiyet, KullaniciAdi, Sifre,Yetki,ProfilFotografi,Bakiye) values (@Ad, @Soyad, @Email, @Telefon, @Adres, @DTarihi, @Cinsiyet, @KullaniciAdi, @Sifre,@Yetki,@ProfilFotografi,@Bakiye)", p) > 0;
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
                        ProfilFotografi = dr["ProfilFotografi"] as byte[],
                        Bakiye = dr["Bakiye"] != DBNull.Value ? Convert.ToDecimal(dr["Bakiye"]) : 0
                    };
                };
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


        public bool KullaniciGuncelle(Kullanici kullanici, string eskiSifre = null, string yeniSifre = null)
        {
            try
            {
                if (DateTime.TryParse(kullanici.DTarihi, out DateTime parsedDate))
                {
                    kullanici.DTarihi = parsedDate.ToString("yyyy-MM-dd");
                }

                List<SqlParameter> parameters = new List<SqlParameter>
        {
            new SqlParameter("@KullaniciId", kullanici.Kullaniciid),
            new SqlParameter("@Ad", kullanici.Ad ?? (object)DBNull.Value),
            new SqlParameter("@Soyad", kullanici.Soyad ?? (object)DBNull.Value),
            new SqlParameter("@Email", kullanici.Email ?? (object)DBNull.Value),
            new SqlParameter("@Telefon", kullanici.Telefon ?? (object)DBNull.Value),
            new SqlParameter("@Adres", kullanici.Adres ?? (object)DBNull.Value),
            new SqlParameter("@DTarihi", kullanici.DTarihi ?? (object)DBNull.Value),
            new SqlParameter("@Cinsiyet", kullanici.Cinsiyet ?? (object)DBNull.Value),
            new SqlParameter("@ProfilFotografi", kullanici.ProfilFotografi ?? (object)DBNull.Value),
            new SqlParameter("@Bakiye", kullanici.Bakiye)
        };

                string updateQuery = "UPDATE Kullanicilar SET Ad=@Ad, Soyad=@Soyad, Email=@Email, Telefon=@Telefon, Adres=@Adres, DogumTarihi=@DTarihi, Cinsiyet=@Cinsiyet, ProfilFotografi=@ProfilFotografi,Bakiye=@Bakiye";

                if (!string.IsNullOrEmpty(yeniSifre))
                {
                    if (string.IsNullOrEmpty(eskiSifre))
                    {
                        throw new Exception("Eski şifre girilmeden yeni şifre değiştirilemez.");
                    }

                    updateQuery += ", Sifre=@YeniSifre WHERE KullaniciId=@KullaniciId AND Sifre=@EskiSifre";
                    parameters.Add(new SqlParameter("@EskiSifre", eskiSifre));
                    parameters.Add(new SqlParameter("@YeniSifre", yeniSifre));
                }
                else
                {
                    updateQuery += " WHERE KullaniciId=@KullaniciId";
                }



                var helper = new Helper();
                return helper.ExecuteNonQuery(updateQuery, parameters.ToArray()) > 0;
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


        public List<Kullanici> KullanicilariGetir()
        {
            List<Kullanici> kullanicilar = new List<Kullanici>();
            try
            {
                var hlp = Helper.SDP;
                var dr = hlp.ExecuteReader("SELECT * FROM Kullanicilar", null);

                while (dr.Read())
                {
                    Kullanici kullanici = new Kullanici
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
                        ProfilFotografi = dr["ProfilFotografi"] as byte[],
                        Bakiye = dr["Bakiye"] != DBNull.Value ? Convert.ToDecimal(dr["Bakiye"]) : 0
                    };
                    kullanicilar.Add(kullanici);
                }
                dr.Close();
                return kullanicilar;
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
                Helper.SDP.DisposeEt();
            }
        }

        public bool KullaniciSil(int kullaniciId)
        {
            try
            {
                var hlp = Helper.SDP;
                SqlParameter[] p = {
                    new SqlParameter("@KullaniciId", kullaniciId)
                };

                var query = "DELETE FROM Kullanicilar WHERE KullaniciId = @KullaniciId";
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

        public bool KullaniciYetkiGuncelle(int kullaniciId, string yeniYetki)
        {
            try
            {
                var helper = new Helper();
                SqlParameter[] p = {
            new SqlParameter("@KullaniciId", kullaniciId),
            new SqlParameter("@Yetki", yeniYetki)
        };

                string query = "UPDATE Kullanicilar SET Yetki = @Yetki WHERE KullaniciId = @KullaniciId";
                return helper.ExecuteNonQuery(query, p) > 0;
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
