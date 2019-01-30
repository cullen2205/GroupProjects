using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;

namespace HotelManagement
{
    public static class LazyWorker
    {
        public static bool UserExists(string username, string hashed_password)
        {
            var connection = DatabaseMiscellaneous.GetConnection();
            return (connection.ExecuteScalar<bool>("select count(1) from Employees " +
                "where Username = @username and Password = @hashed_password",
                new { username = username, hashed_password = hashed_password })) ;
        }
    }
}
