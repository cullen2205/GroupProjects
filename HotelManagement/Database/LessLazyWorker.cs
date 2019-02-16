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
    public static class LessLazyWorker
    {
        static SQLiteConnection connection = DatabaseMiscellaneous.GetConnection();
        public static bool UserExists(string username, string hashed_password)
        {
            return (connection.ExecuteScalar<bool>("select count(1) from Employees " +
                "where Username = @username and Password = @hashed_password",
                new { username, hashed_password })) ;
        }

        public static Employee GetEmployee(string username, string hashed_password)
        {
            return connection.QueryFirstOrDefault<Employee>("select Id, IsAdmin from Employees " + 
                "where Username = @username and Password = @hashed_password",
                new { username, hashed_password });
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

        public static int TotalMoneyOfBill(int billId)
        {
            return connection.ExecuteScalar<int>(
                @"select sum(Services.Price*BillDetails.Count) from BillDetails
                join Services on BillDetails.ServiceId = Services.Id
                where BillDetails.BillId = @billId", 
                new { billId });
        }
        
        public static List<BillDisplay> GetAllBills()
        {
            List<BillDisplay> bills = new List<BillDisplay>();
            
            foreach(BillModel billModel in LazyWorker<BillModel>.GetAll())
            {
                bills.Add(new BillDisplay()
                {
                    Id = billModel.Id,
                    Customer_ = LazyWorker<Customer>.Get
                    (
                        billModel.CustomerId ?? 0
                    ),
                    Employee_ = LazyWorker<Employee>.Get
                    (
                        billModel.EmployeeId ?? 0
                    ),
                    CreatingDay = billModel.CreatingDay
                });
            }

            return bills;
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
