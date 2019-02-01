using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using FastMember;

namespace HotelManagement
{
    public static class LazyLoader<T> where T : class, new()
    {
        static SQLiteConnection connection = DatabaseMiscellaneous.GetConnection();
        public static List<T> GetAll()
        {
            return connection.GetAll<T>().ToList();
        }

        public static int Insert(T item)
        {
            return Convert.ToInt32(connection.Insert(item));
        }

        public static bool Update(T item)
        {
            return connection.Update<T>(item);
        }

        public static bool Delete(T item)
        {
            return connection.Delete(item);
        }

        public static T Get(int Id)
        {
            return connection.Get<T>(Id);
        }

        public static DataTable ListToDataTable(List<T> list)
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(list))
                table.Load(reader);

            return table;
        }

        public static T DataRowToObject(DataRow dataRow)
        {
            T item = new T();
            foreach (DataColumn column in dataRow.Table.Columns)
            {
                PropertyInfo property = item.GetType().GetProperty(column.ColumnName);

                if (property != null && dataRow[column] != DBNull.Value)
                {
                    object result = Convert.ChangeType(dataRow[column], property.PropertyType);
                    property.SetValue(item, result, null);
                }
            }
            
            return item;
        }
        
    }
}
