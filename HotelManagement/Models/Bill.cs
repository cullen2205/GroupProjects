using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper.Contrib.Extensions;

namespace HotelManagement
{
    public class BillBase
    {
        public int Id { get; set; }
        public DateTime CreatingDay { get; set; }
    }

    [Table("Bills")]
    public class BillModel : BillBase
    {
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
    }

    public class BillDisplay : BillBase
    {
        public Customer Customer_ { get; set; }
        public Employee Employee_ { get; set; }
        public int TotalPrice { get; set; }
    }
    
    public class BillDetail
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int BillId { get; set; }
        public int ServiceId { get; set; }
    }

    public class BillWrapper
    {
        public BillBase Bill { get; set; }
        public List<BillDetail> Details { get; set; }
    }
}
