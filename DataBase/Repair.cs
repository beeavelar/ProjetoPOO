using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Repair
    {
        private string connString = "";

        /// <summary>
        /// Método construtor da classe Repair da library DataBase
        /// </summary>
        public Repair()
        {
            this.connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        #region Métodos
        public int Save(string code, decimal price, string description, decimal laborprice)
        {
            int _id = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InsertRepair";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@code", SqlDbType.VarChar);
                cmd.Parameters["@code"].Value = code;

                cmd.Parameters.Add("@price", SqlDbType.Float);
                cmd.Parameters["@price"].Value = price;

                cmd.Parameters.Add("@description", SqlDbType.VarChar);
                cmd.Parameters["@description"].Value = description;

                cmd.Parameters.Add("@laborprice", SqlDbType.Float);
                cmd.Parameters["@laborprice"].Value = laborprice;

                try
                {
                    conn.Open();
                    _id = (int)cmd.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
                return _id;
            }
        }

        public void Update(int id, string code, decimal price, string description, decimal laborprice)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "Update Repairs set Code = @code, Price = @price, Description = @description, Laborprice = @laborprice where Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@code", SqlDbType.VarChar);
                cmd.Parameters["@code"].Value = code;

                cmd.Parameters.Add("@price", SqlDbType.Money);
                cmd.Parameters["@price"].Value = price;

                cmd.Parameters.Add("@description", SqlDbType.VarChar);
                cmd.Parameters["@description"].Value = description;

                cmd.Parameters.Add("@laborprice", SqlDbType.Float);
                cmd.Parameters["@laborprice"].Value = laborprice;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "Delete from Repairs where Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
            }
        }

        public DataTable RepairList(string description)
        {
            DataTable _table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Repairs";

                if (!string.IsNullOrEmpty(description))
                    sql += " where Description like '%" + description + "%'";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    using (SqlDataAdapter a = new SqlDataAdapter(cmd))
                    {
                        a.Fill(_table);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                conn.Close();
                return _table;
            }
        }

        #endregion
    }
}
