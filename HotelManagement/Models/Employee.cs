using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace HotelManagement
{
    [Table("Employees")]
    public class Employee
    {
        public int Id;
        public string Username;
        public string Password;
        public bool IsAdmin;
        public string RealLifeIdNumber;
        public string FullName;
        public DateTime DateOfBirth;
        public bool Sex;
        public string Address;
        public string Phonenumber;
    }
}
