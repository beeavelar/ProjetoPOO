using System;
using System.Collections.Generic;
using System.Data;

namespace Business
{
    public class Vehicle
    {
        #region Prpriedades
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int VehicleYear { get; set; }

        #endregion

        #region Métodos
        public void Save()
        {
            if (this.Id > 0)
            {
                new DataBase.Vehicle().Update(this.Id, this.ClientName, this.LicensePlate, this.Brand, this.Category, this.Model, this.Color, this.VehicleYear);
                return;
            }

            this.Id = new DataBase.Vehicle().Save(this.ClientName, this.LicensePlate, this.Brand, this.Category, this.Model, this.Color, this.VehicleYear);
        }

        public void Update()
        {
            if (this.Id > 0)
            {
                new DataBase.Vehicle().Update(this.Id, this.ClientName, this.LicensePlate, this.Brand, this.Category, this.Model, this.Color, this.VehicleYear);
                return;
            }
        }

        public static List<Vehicle> VehicleList()
        {
            return VehicleList(string.Empty);
        }

        public static List<Vehicle> VehicleList(string licensePlate)
        {
            var _vehicles = new List<Vehicle>();
            DataTable _vehicleData = new DataBase.Vehicle().VehicleList(licensePlate);

            for (int i = 0; i < _vehicleData.Rows.Count; i++)
            {
                _vehicles.Add(new Vehicle()
                {
                    Id = Convert.ToInt32(_vehicleData.Rows[i]["Id"]),
                    ClientName = _vehicleData.Rows[i]["Clientname"].ToString(),
                    LicensePlate = _vehicleData.Rows[i]["Licenseplate"].ToString(),
                    Brand = _vehicleData.Rows[i]["Brand"].ToString(),
                    Category = _vehicleData.Rows[i]["Category"].ToString(),
                    Model = _vehicleData.Rows[i]["Model"].ToString(),
                    Color = _vehicleData.Rows[i]["Color"].ToString(),
                    VehicleYear = Convert.ToInt32(_vehicleData.Rows[i]["Vehicleyear"])
                });
            }
            return _vehicles;
        }

        public static void Delete(int id)
        {
            new DataBase.Vehicle().Delete(id);
        }
        #endregion
    }
}
