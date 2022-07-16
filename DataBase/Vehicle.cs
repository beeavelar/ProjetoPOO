using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Vehicle
    {
        private string connString = "";

        /// <summary>
        /// Método construtor da classe Vehicle da library DataBase
        /// </summary>
        public Vehicle()
        {
            this.connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        #region Métodos
        public int Save(string clientname, string licensePlate, string brand, string category, string model, string color, int vehicleYear)
        {
            int _id = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InsertVehicle";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@clientName", SqlDbType.VarChar);
                cmd.Parameters["@clientName"].Value = clientname;

                cmd.Parameters.Add("@license", SqlDbType.VarChar);
                cmd.Parameters["@license"].Value = licensePlate;

                cmd.Parameters.Add("@brand", SqlDbType.VarChar);
                cmd.Parameters["@brand"].Value = brand;

                cmd.Parameters.Add("@category", SqlDbType.VarChar);
                cmd.Parameters["@category"].Value = category;

                cmd.Parameters.Add("@model", SqlDbType.VarChar);
                cmd.Parameters["@model"].Value = model;

                cmd.Parameters.Add("@color", SqlDbType.VarChar);
                cmd.Parameters["@color"].Value = color;

                cmd.Parameters.Add("@vehicleyear", SqlDbType.Int);
                cmd.Parameters["@vehicleyear"].Value = vehicleYear;

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

        public void Update(int id, string clientname, string licensePlate, string brand, string category, string model, string color, int vehicleYear)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "Update Vehicles set Clientname = @clientName, Licenseplate = @license, Brand = @brand, Category = @category, Model = @model, Color = @color, Vehicleyear = @vehicleYear  where Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@clientName", SqlDbType.VarChar);
                cmd.Parameters["@clientName"].Value = clientname;

                cmd.Parameters.Add("@license", SqlDbType.VarChar);
                cmd.Parameters["@license"].Value = licensePlate;

                cmd.Parameters.Add("@brand", SqlDbType.VarChar);
                cmd.Parameters["@brand"].Value = brand;

                cmd.Parameters.Add("@category", SqlDbType.VarChar);
                cmd.Parameters["@category"].Value = category;

                cmd.Parameters.Add("@model", SqlDbType.VarChar);
                cmd.Parameters["@model"].Value = model;

                cmd.Parameters.Add("@color", SqlDbType.VarChar);
                cmd.Parameters["@color"].Value = color;

                cmd.Parameters.Add("@vehicleyear", SqlDbType.Int);
                cmd.Parameters["@vehicleyear"].Value = vehicleYear;

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
                string sql = "Delete from Vehicles where Id = @id";
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

        public DataTable VehicleList(string licensePlate)
        {
            DataTable _table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Vehicles";

                if (!string.IsNullOrEmpty(licensePlate))
                    sql += " where Licenseplate like '%" + licensePlate + "%'";

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
