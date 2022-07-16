using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Client
    {
        public int IdClient { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PostalCode { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

        public int Nif { get; set; }

        public string FullName
        {
            get
            {
                return $"Nome: {FirstName} {LastName}";
            }
        }

        public string ClientData
        {
            get
            {
                return $"{IdClient};{FirstName};{LastName};{Address};{PostalCode};{Phone};{Email};{Nif}";
            }
        }
    }
}
