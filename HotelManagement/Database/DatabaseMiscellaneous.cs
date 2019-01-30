using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data.SQLite;
using Dapper;
using System.Configuration;

namespace HotelManagement
{
    public static class DatabaseMiscellaneous
    {
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection
            (
                ConfigUtilities.GetDefaultConfig("ConnectionString")
            );
        }

        static string defaultQuery = @"
            create table Employees(
                Id integer primary key autoincrement,
                Username nvarchar(20) not null,
                Password char(32) not null, 
                IsAdmin integer not null, 
                RealLifeIdNumber char(20), 
                FullName nvarchar(50),
                DateOfBirth date,
                Sex integer,
                Address text,
                Phonenumber text
            );
            
            insert into Employees(Username, Password, IsAdmin) values(
                'admin', 
                '21232F297A57A5A743894A0E4A801FC3',
                1);
        ";

        static bool TableExists(String tableName, SQLiteConnection connection)
        {
            return connection.ExecuteScalar<bool>(
                "SELECT COUNT(*) AS QtRecords FROM sqlite_master " +
                "WHERE type = 'table' AND name = @tableName", 
                new { tableName });
        }

        public static bool DatabaseIsValid(SQLiteConnection connection)
        {
            string[] tableNames = { "Employees" };
            foreach(string tableName in tableNames)
                if (!TableExists(tableName, connection))
                    return false;
            
            return true;
        }

        public static void CreateIfNotExistsOrInvalid()
        {
            string fileName = ConfigUtilities.GetDefaultConfig("DatabaseFileName");
            if(!File.Exists(fileName))
            {
                SQLiteConnection.CreateFile(fileName);
            }


            SQLiteConnection connection = GetConnection();
            if (!DatabaseIsValid(connection))
                connection.QueryMultiple(defaultQuery);
        }
    }
}
