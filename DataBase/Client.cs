using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataBase
{
    public class Client
    {
        private string connString = "";

        /// <summary>
        /// Método construtor da classe Client da library DataBase
        /// </summary>
        public Client()
        {
            //Conexão com o banco de dados
            this.connString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        }

        #region Métodos

        /// <summary>
        /// Método que recebe da camada Business os dados do cliente que devem ser salvos na base de dados
        /// </summary>
        public int Save(string name, string address, string postalCode, string email, int phone, int nif)
        {
            int _id = 0;

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "InsertClient";
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

                cmd.Parameters.Add("@phone", SqlDbType.Int);
                cmd.Parameters["@phone"].Value = phone;

                cmd.Parameters.Add("@nif", SqlDbType.Int);
                cmd.Parameters["@nif"].Value = nif;

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

        /// <summary>
        /// Método que recebe da camada Business os dados do cliente que deve ser atualizado da base de dados
        /// </summary>
        public void Update(int id, string name, string address, string postalCode, string email, int phone, int nif)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "Update Clients set Name = @name, Address = @address, Postalcode = @postalcode, Email = @email, Phone = @phone, Nif = @nif where Id = @id";
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

                cmd.Parameters.Add("@phone", SqlDbType.Int);
                cmd.Parameters["@phone"].Value = phone;

                cmd.Parameters.Add("@nif", SqlDbType.Int);
                cmd.Parameters["@nif"].Value = nif;

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

        /// <summary>
        /// Método que recebe da camada Business a indicação do id do cliente que deve ser eliminado da base de dados
        /// </summary>
        public void Delete(int id)
        {
            //Indicar a conexão que será usada
            using (SqlConnection conn = new SqlConnection(connString))
            {
                //Escrever a query --> Deletar da tabela Clients onde o Id que consta na base de dados é igual ao id mandado pela camada Business
                string sql = "Delete from Clients where Id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Indicar que o @id corresponde ao parâmetro id que foi passado por referência pala camada do Business
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

        /// <summary>
        /// Método que recebe da camada Business a indicação do nome do cliente que deve ser selecionado na base de dados
        /// </summary>
        public DataTable ClientList(string name)
        {
            DataTable _table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string sql = "select * from Clients";

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
