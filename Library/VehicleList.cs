using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class VehicleList
    {
        public static List<Vehicle> vehicleList;

        public static void SaveInfo(int id, string clientName, string license, string brand, string category, string model, string color, int year)
        {
            Vehicle newVehicle = new Vehicle();
            newVehicle.IdVehicle = id;
            newVehicle.ClientName = clientName;
            newVehicle.LicensePlate= license;
            newVehicle.Brand = brand;
            newVehicle.Category = category;
            newVehicle.Model = model;
            newVehicle.Color = color;
            newVehicle.Year = year;

            vehicleList.Add(newVehicle);

            SaveFile();
        }

        public static void SaveFile()
        {
            string _folder = Directory.GetCurrentDirectory();
            string _fileName = _folder + @"vehicles.txt";

            StreamWriter _file = new StreamWriter(_fileName, false, Encoding.UTF8);

            foreach (Vehicle newVehicle in vehicleList)
            {
                _file.WriteLine(newVehicle.IdVehicle);
                _file.WriteLine(newVehicle.ClientName);
                _file.WriteLine(newVehicle.LicensePlate);
                _file.WriteLine(newVehicle.Brand);
                _file.WriteLine(newVehicle.Category);
                _file.WriteLine(newVehicle.Model);
                _file.WriteLine(newVehicle.Color);
                _file.WriteLine(newVehicle.Year);
            }
            _file.Dispose();
        }

        public static void ReadInfo()
        {
            string _folder = Directory.GetCurrentDirectory();
            string _fileName = _folder + @"vehicles.txt";

            vehicleList = new List<Vehicle>();

            if (File.Exists(_fileName))
            {
                StreamReader _file = new StreamReader(_fileName, Encoding.UTF8);

                while (!_file.EndOfStream)
                {
                    int _id = Convert.ToInt32(_file.ReadLine());
                    string _clientName = _file.ReadLine();
                    string _license = _file.ReadLine();
                    string _brand = _file.ReadLine();
                    string _category= _file.ReadLine();
                    string _model = _file.ReadLine();
                    string _color = _file.ReadLine();
                    int _year = Convert.ToInt32(_file.ReadLine());

                    Vehicle newVehicle = new Vehicle();

                    newVehicle.IdVehicle = _id;
                    newVehicle.ClientName = _clientName;
                    newVehicle.LicensePlate = _license;
                    newVehicle.Brand = _brand;
                    newVehicle.Category = _category;
                    newVehicle.Model = _model;
                    newVehicle.Color = _color;
                    newVehicle.Year = _year;

                    vehicleList.Add(newVehicle);
                }
                _file.Dispose();
            }
        }
    }
}
