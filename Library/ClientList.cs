using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ClientList
    {
        public static List<Client> clientList;

        public static void SaveInfo(int id, string firstName, string lastName, string address, string postalCode, int phone, string email, int nif)
        {
            Client newClient = new Client();
            newClient.IdClient = id;
            newClient.FirstName = firstName;
            newClient.LastName = lastName;
            newClient.Address = address;
            newClient.PostalCode = postalCode;
            newClient.Phone = phone;
            newClient.Email = email;
            newClient.Nif = nif;

            clientList.Add(newClient);

            SaveFile();
        }

        public static void SaveFile()
        {
            string _folder = Directory.GetCurrentDirectory();
            string _fileName = _folder + @"clients.txt";

            StreamWriter _file = new StreamWriter(_fileName, false, Encoding.UTF8);

            foreach (Client newClient in clientList)
            {
                _file.WriteLine(newClient.IdClient);
                _file.WriteLine(newClient.FirstName);
                _file.WriteLine(newClient.LastName);
                _file.WriteLine(newClient.Address);
                _file.WriteLine(newClient.PostalCode);
                _file.WriteLine(newClient.Phone);
                _file.WriteLine(newClient.Email);
                _file.WriteLine(newClient.Nif);
            }
            _file.Dispose();
        }

        public static void ReadInfo()
        {
            string _folder = Directory.GetCurrentDirectory();
            string _fileName = _folder + @"clients.txt";

            clientList = new List<Client>();

            if (File.Exists(_fileName))
            {
                StreamReader _file = new StreamReader(_fileName, Encoding.UTF8);

                while (!_file.EndOfStream)
                {
                    int _id = Convert.ToInt32(_file.ReadLine());
                    string _firstName = _file.ReadLine();
                    string _lastName = _file.ReadLine();
                    string _address = _file.ReadLine();
                    string _postalCode = _file.ReadLine();
                    int _phone = Convert.ToInt32(_file.ReadLine());
                    string _email = _file.ReadLine();
                    int _nif = Convert.ToInt32(_file.ReadLine());

                    Client newClient = new Client();

                    newClient.IdClient = _id;
                    newClient.FirstName = _firstName;
                    newClient.LastName = _lastName;
                    newClient.Address = _address;
                    newClient.PostalCode = _postalCode;
                    newClient.Phone = _phone;
                    newClient.Email = _email;
                    newClient.Nif = _nif;

                    clientList.Add(newClient);
                }
                _file.Dispose();
            }
        }
    }
}
