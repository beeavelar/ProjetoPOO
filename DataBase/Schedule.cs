using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Schedule
    {
        private string connString = "";

        /// <summary>
        /// Método construtor da classe Schedule da library DataBase
        /// </summary>
        public Schedule()
        {
            this.connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        #region Métodos
        public int Save(string vehicle, string repair, string mechanic, string client, DateTime startdate, DateTime enddate, DateTime alertdate, string time, string email)
        {
            int _id = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InsertSchedule";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@vehicle", SqlDbType.VarChar);
                cmd.Parameters["@vehicle"].Value = vehicle;

                cmd.Parameters.Add("@repair", SqlDbType.VarChar);
                cmd.Parameters["@repair"].Value = repair;

                cmd.Parameters.Add("@mechanic", SqlDbType.VarChar);
                cmd.Parameters["@mechanic"].Value = mechanic;

                cmd.Parameters.Add("@client", SqlDbType.VarChar);
                cmd.Parameters["@client"].Value = client;

                cmd.Parameters.Add("@startdate", SqlDbType.DateTime);
                cmd.Parameters["@startdate"].Value = startdate;

                cmd.Parameters.Add("@enddate", SqlDbType.DateTime);
                cmd.Parameters["@enddate"].Value = enddate;

                cmd.Parameters.Add("@alertdate", SqlDbType.DateTime);
                cmd.Parameters["@alertdate"].Value = alertdate;

                cmd.Parameters.Add("@time", SqlDbType.VarChar);
                cmd.Parameters["@time"].Value = time;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

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

        public void Update(int id, string vehicle, string repair, string mechanic, string client, DateTime startdate, DateTime enddate, DateTime alertdate, string time, string email)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "Update Schedules set Vehicle = @vehicle, Repair = @repair, Mechanic = @mechanic, Client = @client, Startdate = @startdate, Enddate = @enddate, Alertdate = @alertdate, Time = @time, Email = @email where Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@vehicle", SqlDbType.VarChar);
                cmd.Parameters["@vehicle"].Value = vehicle;

                cmd.Parameters.Add("@repair", SqlDbType.VarChar);
                cmd.Parameters["@repair"].Value = repair;

                cmd.Parameters.Add("@mechanic", SqlDbType.VarChar);
                cmd.Parameters["@mechanic"].Value = mechanic;

                cmd.Parameters.Add("@client", SqlDbType.VarChar);
                cmd.Parameters["@client"].Value = client;

                cmd.Parameters.Add("@startdate", SqlDbType.DateTime);
                cmd.Parameters["@startdate"].Value = startdate;

                cmd.Parameters.Add("@enddate", SqlDbType.DateTime);
                cmd.Parameters["@enddate"].Value = enddate;

                cmd.Parameters.Add("@alertdate", SqlDbType.DateTime);
                cmd.Parameters["@alertdate"].Value = alertdate;

                cmd.Parameters.Add("@time", SqlDbType.VarChar);
                cmd.Parameters["@time"].Value = time;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

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
                string sql = "Delete from Schedules where Id = @id";
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
        public DataTable ScheduleList()
        {
            DataTable _table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Schedules";

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

        public DataTable ScheduleListStartDate(DateTime startdate, DateTime enddate)
        {
            DataTable _table = new DataTable();
            string _startDate = startdate.ToString("yyyy-MM-dd") + " 00:00:00";
            string _endDate = enddate.ToString("yyyy-MM-dd") + " 23:59:59";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Schedules";

                if ((startdate.ToShortDateString() != null))
                {
                    sql += " where Convert(datetime, Startdate, 103) between '" + _startDate + "' and '" + _endDate + "' order by Startdate desc";
                }

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
        public DataTable ScheduleListAlertDate(DateTime alertdate)
        {
            DataTable _table = new DataTable();
            string _alertDate = alertdate.ToString("yyyy-MM-dd") + " 00:00:00";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Schedules";

                if ((alertdate.ToShortDateString() != null))
                {
                    sql += " where Convert(datetime, Alertdate, 103) ='" + _alertDate + "' order by Alertdate asc";
                }

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
