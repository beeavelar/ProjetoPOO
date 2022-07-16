using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Vehicle
    {
        public int IdVehicle { get; set; }

        public string ClientName { get; set; }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public string VehicleData
        {
            get
            {
                return $"{IdVehicle};{ClientName};{LicensePlate};{Brand};{Category};{Model};{Color};{Year}";
            }
        }

        public string VehicleInfo
        {
            get
            {
                return $"{IdVehicle} - {LicensePlate}";
            }
        }

    }
}
