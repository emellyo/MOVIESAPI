using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class RepoUser
    {
        public string connectionString;
        private SqlConnection conn;
        private SqlTransaction trans;

        public RepoUser(string connection)
        {
            connectionString = connection;
        }

        public DataTable getUser(string ID)
        {
            try
            {
                DataTable dt = new DataTable();
                conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GETDATAUSER";
                cmd.Parameters.AddWithValue("@ID", string.IsNullOrEmpty(ID) == true ? "" : ID);
                cmd.Connection = conn;
                cmd.CommandTimeout = 0;
                SqlDataAdapter adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;

                adp.Fill(dt);

                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    conn.Dispose();
                    SqlConnection.ClearPool(conn);
                    conn = null;
                }
            }
        }

        public bool createUser(CreateUser param)
        {
            try
            {
                DataTable dt = new DataTable();

                conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                    conn.Open();


                trans = conn.BeginTransaction();

                SqlCommand cmd = new SqlCommand("CREATEUPDATEUSER", conn, trans);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USERID", string.IsNullOrEmpty(param.USERID) == true ? "" : param.USERID);
                cmd.Parameters.AddWithValue("@NAMA", string.IsNullOrEmpty(param.NAMA) == true ? "" : param.NAMA);
                cmd.Parameters.AddWithValue("@NAMA_PANGGILAN", string.IsNullOrEmpty(param.NAMA_PANGGILAN) == true ? "" : param.NAMA_PANGGILAN);
                cmd.Connection = conn;
                cmd.CommandTimeout = 0;
                SqlDataAdapter adp = new SqlDataAdapter();
                cmd.ExecuteNonQuery();

                trans.Commit();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();

                    conn.Dispose();
                    SqlConnection.ClearPool(conn);
                    conn = null;
                }
            }
        }
    }
}
