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
    }
    
}
