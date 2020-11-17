using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StalkerNeeds.Models
{
    public class ContactInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FileName { get; set; }
        public byte[] Avatar { get; set; }
        public string StreetAddress { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }

    }
}
