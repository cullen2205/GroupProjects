using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace HotelManagement
{
    public class Employee
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string RealLifeIdNumber { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Sex { get; set; }
        public string Address { get; set; }
        public string Phonenumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} {6} {7}", 
                Id, Username, RealLifeIdNumber, FullName, 
                DateOfBirth.ToShortDateString(), Sex ? "Nữ" : "Nam",
                Address, Phonenumber);
        }
    }
}
