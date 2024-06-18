using DAL;
using EtkinlikYS.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EtkinlikYS.BLL
{
    public class EtkinlikBL
    {
            public bool EtkinlikKayit(Etkinlik etkinlik)
            {
                try
                {
                    SqlParameter[] p = {
                    new SqlParameter("@EtkinlikAdi", etkinlik.EtkinlikAdi ?? (object)DBNull.Value),
                    new SqlParameter("@Fiyat", etkinlik.Fiyat ?? (object)DBNull.Value),
                    new SqlParameter("@EtkinlikTuru", etkinlik.EtkinlikTuru ?? (object)DBNull.Value),
                    new SqlParameter("@ToplamKontejan", etkinlik.ToplamKontejan),
                    new SqlParameter("@MevcutKontejan", etkinlik.MevcutKontejan),
                    new SqlParameter("@EtkinlikTarihi", etkinlik.EtkinlikTarihi),
                    new SqlParameter("@EtkinlikYeri", etkinlik.EtkinlikYeri ?? (object)DBNull.Value),
                    new SqlParameter("@Aciklama", etkinlik.Aciklama ?? (object)DBNull.Value),
                    new SqlParameter("@Resim", etkinlik.Resim ?? (object)DBNull.Value),
                    new SqlParameter("@OlusturanKullaniciID", etkinlik.OlusturanKullaniciID)
                };

                    var hlp = Helper.SDP;
                    return hlp.ExecuteNonQuery("Insert into Etkinlikler (EtkinlikAdi, Fiyat, EtkinlikTuru, ToplamKontejan, MevcutKontejan, EtkinlikTarihi, EtkinlikYeri, Aciklama, Resim, OlusturanKullaniciID) values (@EtkinlikAdi, @Fiyat, @EtkinlikTuru, @ToplamKontejan, @MevcutKontejan, @EtkinlikTarihi, @EtkinlikYeri, @Aciklama, @Resim, @OlusturanKullaniciID)", p) > 0;
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


        public List<Etkinlik> EtkinlikleriGetir()
        {
            List<Etkinlik> etkinlikler = new List<Etkinlik>();
            try
            {
                SqlParameter[] p = { };

                var hlp = Helper.SDP;
                var dr = hlp.ExecuteReader("SELECT * FROM Etkinlikler", p);

                while (dr.Read())
                {
                    Etkinlik etkinlik = new Etkinlik
                    {
                        EtkinlikID = Convert.ToInt32(dr["EtkinlikID"]),
                        EtkinlikAdi = dr["EtkinlikAdi"].ToString(),
                        Fiyat = dr["Fiyat"].ToString(),
                        EtkinlikTuru = dr["EtkinlikTuru"].ToString(),
                        ToplamKontejan = Convert.ToInt32(dr["ToplamKontejan"]),
                        MevcutKontejan = Convert.ToInt32(dr["MevcutKontejan"]),
                        EtkinlikTarihi = Convert.ToDateTime(dr["EtkinlikTarihi"]),
                        EtkinlikYeri = dr["EtkinlikYeri"].ToString(),
                        Aciklama = dr["Aciklama"].ToString(),
                        Resim = dr["Resim"] as byte[],
                        OlusturanKullaniciID = Convert.ToInt32(dr["OlusturanKullaniciID"])
                    };
                    etkinlikler.Add(etkinlik);
                }
                dr.Close();
                return etkinlikler;
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

        public List<Etkinlik> KullaniciEtkinlikleriGetir(int kullaniciID)
        {
            List<Etkinlik> etkinlikler = new List<Etkinlik>();
            try
            {
                SqlParameter[] p = { new SqlParameter("@OlusturanKullaniciID", kullaniciID) };

                var hlp = Helper.SDP;
                var dr = hlp.ExecuteReader("SELECT * FROM Etkinlikler WHERE OlusturanKullaniciID = @OlusturanKullaniciID", p);

                while (dr.Read())
                {
                    Etkinlik etkinlik = new Etkinlik
                    {
                        EtkinlikID = Convert.ToInt32(dr["EtkinlikID"]),
                        EtkinlikAdi = dr["EtkinlikAdi"].ToString(),
                        Fiyat = dr["Fiyat"].ToString(),
                        EtkinlikTuru = dr["EtkinlikTuru"].ToString(),
                        ToplamKontejan = Convert.ToInt32(dr["ToplamKontejan"]),
                        MevcutKontejan = Convert.ToInt32(dr["MevcutKontejan"]),
                        EtkinlikTarihi = Convert.ToDateTime(dr["EtkinlikTarihi"]),
                        EtkinlikYeri = dr["EtkinlikYeri"].ToString(),
                        Aciklama = dr["Aciklama"].ToString(),
                        Resim = dr["Resim"] as byte[],
                        OlusturanKullaniciID = Convert.ToInt32(dr["OlusturanKullaniciID"])
                    };
                    etkinlikler.Add(etkinlik);
                }
                dr.Close();
                return etkinlikler;
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


        public bool EtkinlikGuncelle(Etkinlik etkinlik)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@EtkinlikID", etkinlik.EtkinlikID),
                    new SqlParameter("@EtkinlikAdi", etkinlik.EtkinlikAdi ?? (object)DBNull.Value),
                    new SqlParameter("@Fiyat", etkinlik.Fiyat ?? (object)DBNull.Value),
                    new SqlParameter("@EtkinlikTuru", etkinlik.EtkinlikTuru ?? (object)DBNull.Value),
                    new SqlParameter("@ToplamKontejan", etkinlik.ToplamKontejan),
                    new SqlParameter("@EtkinlikTarihi", etkinlik.EtkinlikTarihi),
                    new SqlParameter("@EtkinlikYeri", etkinlik.EtkinlikYeri ?? (object)DBNull.Value),
                    new SqlParameter("@Aciklama", etkinlik.Aciklama ?? (object)DBNull.Value),
                    new SqlParameter("@Resim", etkinlik.Resim ?? (object)DBNull.Value)
                };

                var hlp = Helper.SDP;
                return hlp.ExecuteNonQuery("UPDATE Etkinlikler SET EtkinlikAdi = @EtkinlikAdi, Fiyat = @Fiyat, EtkinlikTuru = @EtkinlikTuru, ToplamKontejan = @ToplamKontejan, EtkinlikTarihi = @EtkinlikTarihi, EtkinlikYeri = @EtkinlikYeri, Aciklama = @Aciklama, Resim = @Resim WHERE EtkinlikID = @EtkinlikID", p) > 0;
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


        public bool EtkinligeKatilimEkle(Etkinlik etkinlik, Kullanici kullanici)
        {
            try
            {
                SqlParameter[] p = {
                    new SqlParameter("@EtkinlikID", etkinlik.EtkinlikID),
                    new SqlParameter("@KullaniciID", kullanici.Kullaniciid)
                };

                var hlp = Helper.SDP;
                bool result = hlp.ExecuteNonQuery("INSERT INTO EtkinlikKatilim (EtkinlikID, KullaniciID) VALUES (@EtkinlikID, @KullaniciID)", p) > 0;

                if (result)
                {
                    result = hlp.ExecuteNonQuery("UPDATE Etkinlikler SET MevcutKontejan = MevcutKontejan + 1 WHERE EtkinlikID = @EtkinlikID", new SqlParameter[] { new SqlParameter("@EtkinlikID", etkinlik.EtkinlikID) }) > 0;
                }

                return result;
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
