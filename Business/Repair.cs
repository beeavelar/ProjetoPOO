using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    public class Repair
    {
        #region Propriedades
        public int Id { get; set; }

        public string Code { get; set; }

        public Decimal Price { get; set; }

        public string Description { get; set; }

        public Decimal LaborPrice { get; set; }

        #endregion

        #region Métodos
        public void Save()
        {
            if (this.Id > 0)
            {
                new DataBase.Repair().Update(this.Id, this.Code, this.Price, this.Description, this.LaborPrice);
                return;
            }

            this.Id = new DataBase.Repair().Save(this.Code, this.Price, this.Description, this.LaborPrice);
        }

        public void Update()
        {
            if (this.Id > 0)
            {
                new DataBase.Repair().Update(this.Id, this.Code, this.Price, this.Description, this.LaborPrice);
                return;
            }
        }

        public static List<Repair> RepairList()
        {
            return RepairList(string.Empty);
        }

        public static List<Repair> RepairList(string description)
        {
            var _repairs = new List<Repair>();
            DataTable _repairData = new DataBase.Repair().RepairList(description);

            for (int i = 0; i < _repairData.Rows.Count; i++)
            {
                _repairs.Add(new Repair()
                {
                    Id = Convert.ToInt32(_repairData.Rows[i]["Id"]),
                    Code = _repairData.Rows[i]["Code"].ToString(),
                    Price = Convert.ToDecimal(_repairData.Rows[i]["Price"].ToString()),
                    Description = _repairData.Rows[i]["Description"].ToString(),
                    LaborPrice = Convert.ToDecimal(_repairData.Rows[i]["LAborprice"].ToString()),
                });
            }
            return _repairs;
        }

        public static void Delete(int id)
        {
            new DataBase.Repair().Delete(id);
        }
        #endregion
    }
}
