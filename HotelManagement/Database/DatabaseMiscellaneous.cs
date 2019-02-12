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

        const string defaultQuery = @"
create table if not exists Employees
(
	Id integer primary key autoincrement,
	Username nvarchar(20) not null,
	Password char(32) not null, 
	IsAdmin integer not null, 
	RealLifeIdNumber char(20), 
	FullName nvarchar(50),
	DateOfBirth date,
	Sex integer,
	Address nvarchar(200),
	Phonenumber nvarchar(20)
);

insert into Employees(Username, Password, IsAdmin) values
	('admin', '21232F297A57A5A743894A0E4A801FC3', 1);

create table if not exists Rooms
(
	Id integer primary key autoincrement,
	RoomName nvarchar(30)
);

insert into Rooms(RoomName) values 
	('Chung cho tất cả các phòng.'),
	('Phòng 101'),
	('Phòng 13'),
	('Phòng 420'),
	('Phòng 4953');

create table if not exists Services
(
	Id integer primary key autoincrement,
	RoomId int,
	ServiceName nvarchar(50),
	Price integer,
	foreign key (RoomId) references Rooms(Id)
);

insert into Services(RoomId, ServiceName, Price) values 
	(1, 'Dọn dẹp', 10000),
	(2, 'Cho thuê', 200000),
	(3, 'Cho thuê', 300000),
	(4, 'Cho thuê', 400000),
	(5, 'Cho thuê', 500000);

create table if not exists Customers
(
	Id integer primary key autoincrement,
	FullName nvarchar(50),
	DateOfBirth date,
	Sex integer,
	RealLifeIdNumber char(20)
);

insert into Customers(FullName, Sex, RealLifeIdNumber) values
	('Nguyễn Văn A', 0, '123456789'),
	('Nga Vân Uyên', 1, '987654321');

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
            string[] tableNames = { "Employees", "Rooms", "Services", "Customers" };
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
