using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;

namespace HotelManagement
{
    public static class LazyLoader
    {
        static SQLiteConnection connection = DatabaseMiscellaneous.GetConnection();
        public static bool UserExists(string username, string hashed_password)
        {
            return (connection.ExecuteScalar<bool>("select count(1) from Employees " +
                "where Username = @username and Password = @hashed_password",
                new { username = username, hashed_password = hashed_password })) ;
        }

        public static Employee GetEmployee(string username, string hashed_password)
        {
            return connection.QueryFirstOrDefault<Employee>("select Id, IsAdmin from Employees " + 
                "where Username = @username and Password = @hashed_password",
                new { username = username, hashed_password = hashed_password });
        }

        public static List<ServiceDisplay> GetAllServices()
        {
            return connection.Query<ServiceDisplay, Room, ServiceDisplay>(
                "select s.Id, s.ServiceName, s.Price, r.Id, r.RoomName " +
                "from Services s left join Rooms r on s.RoomId = r.Id", 
                (service, room) => 
                {
                    service.BelongToRoom = room;
                    return service;
                }).AsList();
        }

        public static void SetColumnsOrder(DataTable table, 
            params String[] columnNames)
        {
            int columnIndex = 0;
            foreach (var columnName in columnNames)
            {
                table.Columns[columnName].SetOrdinal(columnIndex);
                columnIndex++;
            }
        }
    }
}
