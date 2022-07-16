using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Invoice
    {
        private string connString = "";

        /// <summary>
        /// Método construtor da classe Invoice da library DataBase
        /// </summary>
        public Invoice()
        {
            this.connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        #region Métodos
        public int Save(int serviceorder, string vehicle, string repair, string mechanic, string client, int nif, string paymenttype, DateTime issuedate, Decimal repairprice, Decimal laborprice, Decimal total)
        {
            int _id = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InsertInvoice";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@serviceorder", SqlDbType.Int);
                cmd.Parameters["@serviceorder"].Value = serviceorder;

                cmd.Parameters.Add("@vehicle", SqlDbType.VarChar);
                cmd.Parameters["@vehicle"].Value = vehicle;

                cmd.Parameters.Add("@repair", SqlDbType.VarChar);
                cmd.Parameters["@repair"].Value = repair;

                cmd.Parameters.Add("@mechanic", SqlDbType.VarChar);
                cmd.Parameters["@mechanic"].Value = mechanic;

                cmd.Parameters.Add("@client", SqlDbType.VarChar);
                cmd.Parameters["@client"].Value = client;

                cmd.Parameters.Add("@nif", SqlDbType.Int);
                cmd.Parameters["@nif"].Value = nif;

                cmd.Parameters.Add("@paymenttype", SqlDbType.VarChar);
                cmd.Parameters["@paymenttype"].Value = paymenttype;

                cmd.Parameters.Add("@issuedate", SqlDbType.DateTime);
                cmd.Parameters["@issuedate"].Value = issuedate;

                cmd.Parameters.Add("@repairprice", SqlDbType.Float);
                cmd.Parameters["@repairprice"].Value = repairprice;

                cmd.Parameters.Add("@laborprice", SqlDbType.Float);
                cmd.Parameters["@laborprice"].Value = laborprice;

                cmd.Parameters.Add("@total", SqlDbType.Float);
                cmd.Parameters["@total"].Value = total;

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

        public void Update(int id, int serviceorder, string vehicle, string repair, string mechanic, string client, int nif, string paymenttype, DateTime issuedate, Decimal repairprice, Decimal laborprice, Decimal total)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "Update Invoices set Serviceorder = @serviceorder, Vehicle = @vehicle, Repair = @repair, Mechanic = @mechanic,  Client = @client, Nif = @nif, Paymenttype = @paymenttype, Issuedate = @issuedate, Repairprice = @repairprice, Laborprice = @laborprice, Total = @total  where Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;

                cmd.Parameters.Add("@serviceorder", SqlDbType.Int);
                cmd.Parameters["@serviceorder"].Value = serviceorder;

                cmd.Parameters.Add("@vehicle", SqlDbType.VarChar);
                cmd.Parameters["@vehicle"].Value = vehicle;

                cmd.Parameters.Add("@repair", SqlDbType.VarChar);
                cmd.Parameters["@repair"].Value = repair;

                cmd.Parameters.Add("@mechanic", SqlDbType.VarChar);
                cmd.Parameters["@mechanic"].Value = mechanic;

                cmd.Parameters.Add("@client", SqlDbType.VarChar);
                cmd.Parameters["@client"].Value = client;

                cmd.Parameters.Add("@nif", SqlDbType.Int);
                cmd.Parameters["@nif"].Value = nif;

                cmd.Parameters.Add("@paymenttype", SqlDbType.VarChar);
                cmd.Parameters["@paymenttype"].Value = paymenttype;

                cmd.Parameters.Add("@issuedate", SqlDbType.DateTime);
                cmd.Parameters["@issuedate"].Value = issuedate;

                cmd.Parameters.Add("@repairprice", SqlDbType.Float);
                cmd.Parameters["@repairprice"].Value = repairprice;

                cmd.Parameters.Add("@laborprice", SqlDbType.Float);
                cmd.Parameters["@laborprice"].Value = laborprice;

                cmd.Parameters.Add("@total", SqlDbType.Float);
                cmd.Parameters["@total"].Value = total;

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
                string sql = "Delete from Invoices where Id = @id";
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
        public DataTable InvoiceList()
        {
            DataTable _table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Invoices";

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

        public DataTable InvoiceListIssueDate(DateTime issuedate)
        {
            DataTable _table = new DataTable();
            string _issuedate = issuedate.ToString("yyyy-MM-dd") + " 00:00:00";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Invoices";

                if ((issuedate.ToShortDateString() != null))
                {
                    sql += " where Convert(datetime, Issuedate, 103) ='" + _issuedate + "' order by IssueDate desc";
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
