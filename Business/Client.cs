using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    /*Esse sistema esta dividido em 3 camadas: Database, Business (Regra de Negócio) e UI (User Interface). 
     A camada da Database tem a estrutura de conexão e as querys para fazer os selects, deletes e updates da base de dados criada no SQL Server. 
    Ela está conectada diretamente com a camada Business e indiretamente com a camada UI. A camada Bussiness é uma camada intermediária entre a 
    DataBase e a UI e é ela que faz o elo entre essas duas camadas porque ela está conectada diretamente com a camada DataBase e com a camada UI. 
    Essa camada contém tudo que for lógica e regras de negócio, faz verificações e validações dos dados que vem e vão para a base de dados. 
    E por último temos a camada de interface com o usuário (UI) que é onde exibimos informações e coletamos dados do usuário através dos forms.
    */
    public class Client
    {
        #region Propriedades 
        //Propriedades do objeto Client
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public int Nif { get; set; }

        #endregion

        #region Métodos

        /// <summary>
        /// Método que recebe os dados vindos da camada de UI e envia para o método Salvar() da camada DataBase para serem salvos na base de dados
        /// </summary>
        public void Save()
        {
            if (this.Id > 0) //Verifica se o Id é maior do que 0, pois para fazer update o Id precisa ser maior do que 0, ou seja, existir na base de dados
            {
                //Se o id é maior que 0, recebe os valores vindos da camada de UI, atribui eles as propriedades e passa eles para o método Update() da camada DataBase
                new DataBase.Client().Update(this.Id, this.Name, this.Address, this.PostalCode, this.Email, this.Phone, this.Nif);
                return;
            }
            //Recebe os valores vindos da camada de UI, atribui eles as propriedades e passa eles para o método Save() da camada DataBase
            this.Id = new DataBase.Client().Save(this.Name, this.Address, this.PostalCode, this.Email, this.Phone, this.Nif);
        }

        /// <summary>
        /// Método que recebe os novos dados vindos da camada de UI e envia para o método Update() da camada DataBase para serem salvos na base de dados
        /// </summary>
        public void Update()
        {
            if (this.Id > 0) //Verifica se o Id é maior do que 0, pois para fazer update o Id precisa ser maior do que 0, ou seja, existir na base de dados
            {
                //Se o id é maior que 0, recebe os valores vindos da camada de UI, atribui eles as propriedades e passa eles para o método Update() da camada DataBases
                new DataBase.Client().Update(this.Id, this.Name, this.Address, this.PostalCode, this.Email, this.Phone, this.Nif);
                return;
            }
        }

        public static List<Client> ClientList()
        {
            return ClientList(string.Empty);
        }

        /// <summary>
        /// Método que adiciona o novo cliente na lista de clientes e indica em qual coluna cada dado vai ser salvo
        /// </summary>
        public static List<Client> ClientList(string name)
        {
            var _clients = new List<Client>();
            DataTable _clientData = new DataBase.Client().ClientList(name);

            for (int i = 0; i < _clientData.Rows.Count; i++)
            {
                _clients.Add(new Client()
                {
                    Id = Convert.ToInt32(_clientData.Rows[i]["Id"]),
                    Name = _clientData.Rows[i]["Name"].ToString(),
                    Address = _clientData.Rows[i]["Address"].ToString(),
                    PostalCode = _clientData.Rows[i]["Postalcode"].ToString(),
                    Email = _clientData.Rows[i]["Email"].ToString(),
                    Phone = Convert.ToInt32(_clientData.Rows[i]["Phone"]),
                    Nif = Convert.ToInt32(_clientData.Rows[i]["Nif"])
                });
            }
            return _clients;
        }

        /// <summary>
        /// Método que manda eliminar um cliente da tabela da base de dados. O cliente é identificado pelo seu id.
        /// </summary>
        public static void Delete(int id)
        {
            new DataBase.Client().Delete(id);
        }
        #endregion
    }
}
