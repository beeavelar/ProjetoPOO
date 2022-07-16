using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Mechanic
    {
        private string connString = "";

        /// <summary>
        /// Método construtor da classe Mechanic da library DataBase
        /// </summary>
        public Mechanic()
        {
            this.connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        #region Métodos
        public int Save(string name, string address, string postalCode, string email, int cc, int phone, int nif, string niss)
        {
            int _id = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InsertMechanic";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;

                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = address;

                cmd.Parameters.Add("@postalcode", SqlDbType.VarChar);
                cmd.Parameters["@postalcode"].Value = postalCode;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@cc", SqlDbType.Int);
                cmd.Parameters["@cc"].Value = cc;

                cmd.Parameters.Add("@phone", SqlDbType.Int);
                cmd.Parameters["@phone"].Value = phone;

                cmd.Parameters.Add("@nif", SqlDbType.Int);
                cmd.Parameters["@nif"].Value = nif;

                cmd.Parameters.Add("@niss", SqlDbType.VarChar);
                cmd.Parameters["@niss"].Value = niss;

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

        public void Update(int id, string name, string address, string postalCode, string email, int cc, int phone, int nif, string niss)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "Update Mechanics set Name = @name, Address = @address, Postalcode = @postalcode, Email = @email, CC = @cc, Phone = @phone, Nif = @nif, Niss = @niss where Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@name", SqlDbType.VarChar);
                cmd.Parameters["@name"].Value = name;

                cmd.Parameters.Add("@address", SqlDbType.VarChar);
                cmd.Parameters["@address"].Value = address;

                cmd.Parameters.Add("@postalcode", SqlDbType.VarChar);
                cmd.Parameters["@postalcode"].Value = postalCode;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@cc", SqlDbType.Int);
                cmd.Parameters["@cc"].Value = cc;

                cmd.Parameters.Add("@phone", SqlDbType.Int);
                cmd.Parameters["@phone"].Value = phone;

                cmd.Parameters.Add("@nif", SqlDbType.Int);
                cmd.Parameters["@nif"].Value = nif;

                cmd.Parameters.Add("@niss", SqlDbType.VarChar);
                cmd.Parameters["@niss"].Value = niss;

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
                string sql = "Delete from Mechanics where Id = @id";
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

        public DataTable MechanicList(string name)
        {
            DataTable _table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Mechanics";

                if (!string.IsNullOrEmpty(name))
                    sql += " where Name like '%" + name + "%'" + "order by Name asc";

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
