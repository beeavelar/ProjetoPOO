using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    public class Mechanic
    {
        #region Propriedades
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public string Email { get; set; }

        public int CC { get; set; }

        public int Phone { get; set; }

        public int Nif { get; set; }

        public string Niss { get; set; }

        #endregion

        #region Métodos
        public void Save()
        {
            if (this.Id > 0)
            {
                new DataBase.Mechanic().Update(this.Id, this.Name, this.Address, this.PostalCode, this.Email, this.CC, this.Phone, this.Nif, this.Niss);
                return;
            }
            this.Id = new DataBase.Mechanic().Save(this.Name, this.Address, this.PostalCode, this.Email, this.CC, this.Phone, this.Nif, this.Niss);
        }

        public void Update()
        {
            if (this.Id > 0)
            {
                new DataBase.Mechanic().Update(this.Id, this.Name, this.Address, this.PostalCode, this.Email, this.CC, this.Phone, this.Nif, this.Niss);
                return;
            }
        }

        public static List<Mechanic> MechanicList()
        {
            return MechanicList(string.Empty);
        }

        public static List<Mechanic> MechanicList(string name)
        {
            var _mechanics = new List<Mechanic>();
            DataTable _mechanicData = new DataBase.Mechanic().MechanicList(name);

            for (int i = 0; i < _mechanicData.Rows.Count; i++)
            {
                _mechanics.Add(new Mechanic()
                {
                    Id = Convert.ToInt32(_mechanicData.Rows[i]["Id"]),
                    Name = _mechanicData.Rows[i]["Name"].ToString(),
                    Address = _mechanicData.Rows[i]["Address"].ToString(),
                    PostalCode = _mechanicData.Rows[i]["Postalcode"].ToString(),
                    Email = _mechanicData.Rows[i]["Email"].ToString(),
                    CC = Convert.ToInt32(_mechanicData.Rows[i]["CC"]),
                    Phone = Convert.ToInt32(_mechanicData.Rows[i]["Phone"]),
                    Nif = Convert.ToInt32(_mechanicData.Rows[i]["Nif"]),
                    Niss = _mechanicData.Rows[i]["Niss"].ToString()
                });
            }
            return _mechanics;
        }

        public static void Delete(int id)
        {
            new DataBase.Mechanic().Delete(id);
        }
        #endregion
    }
}
