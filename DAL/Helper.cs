

using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class Helper : IDisposable
    {
        SqlConnection? cn;
        SqlCommand? cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        private static Helper? helper;

        private Helper() { }

        public static Helper SDP
        {
            get
            {
                if (helper == null)
                {
                    helper = new Helper();

                }
                return helper;
            }
        }

        public void DisposeEt()
        {
            if (cn != null)
            {
                cn.Close();
                cn.Dispose();

            }
            if (cmd != null)
            {
                cmd.Dispose();
            }
        }

        public int ExecuteNonQuery(string cmdtext, SqlParameter[]? p = null)
        {
            try
            {
                using (cn = new SqlConnection(cstr))
                {
                    using (cmd = new SqlCommand(cmdtext, cn))
                    {
                        if (p != null)
                        {
                            cmd.Parameters.AddRange(p);
                        }
                        cn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
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

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[]? p = null)
        {
            try
            {
                var cn = new SqlConnection(cstr);
                var cmd = new SqlCommand(cmdtext, cn);

                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();

                return cmd.ExecuteReader(CommandBehavior.CloseConnection);

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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}