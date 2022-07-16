using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    public class User
    {
        #region Propriedades

        public static User UserLogged = null;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Permission { get; set; }

        #endregion

        #region Métodos
        public void Save()
        {
            if (this.Id > 0)
            {
                new DataBase.User().Update(this.Id, this.Name, this.Username, this.Password, this.Email, this.Permission);
                return;
            }

            this.Id = new DataBase.User().Save(this.Name, this.Username, this.Password, this.Email, this.Permission);
        }

        public void Update()
        {
            if (this.Id > 0)
            {
                new DataBase.User().Update(this.Id, this.Name, this.Username, this.Password, this.Email, this.Permission);
                return;
            }
        }
        public static List<User> UserList()
        {
            return UserList(string.Empty);
        }

        public static List<User> UserList(string name)
        {
            var _logins = new List<User>();
            DataTable _loginData = new DataBase.User().UserList(name);

            for (int i = 0; i < _loginData.Rows.Count; i++)
            {
                _logins.Add(new User()
                {
                    Id = Convert.ToInt32(_loginData.Rows[i]["Id"]),
                    Name = _loginData.Rows[i]["Name"].ToString(),
                    Username = _loginData.Rows[i]["Username"].ToString(),
                    Password = _loginData.Rows[i]["Password"].ToString(),
                    Email = _loginData.Rows[i]["Email"].ToString(),
                    Permission = _loginData.Rows[i]["Permission"].ToString()
                });
            }
            return _logins;
        }

        public static bool CheckLoginData(string username, string password)
        {
            var data = new DataBase.User().CheckLoginData(username, password);
            UserLogged = new User();

            for (var i = 0; i < data.Rows.Count; i++)
            {
                UserLogged.Id = Convert.ToInt32(data.Rows[i]["Id"]);
                UserLogged.Name = data.Rows[i]["Name"].ToString();
                UserLogged.Username = data.Rows[i]["Username"].ToString();
                UserLogged.Password = data.Rows[i]["Password"].ToString();
                UserLogged.Email = data.Rows[i]["Email"].ToString();
                UserLogged.Permission = data.Rows[i]["Permission"].ToString();
            }
            return UserLogged.Id > 0;
        }

        public static void Delete(int id)
        {
            new DataBase.User().Delete(id);
        }
        #endregion
    }
}
