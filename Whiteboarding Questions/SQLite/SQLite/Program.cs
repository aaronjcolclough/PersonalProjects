using System;
using System.Data.SQLite;

namespace SQLite
{
    class Program
    {
        public static SQLiteConnection m_dbConnection;

        static void Main(string[] args)
        {
            CreateDb();
            ConnectDb();
            CreateTable();
            FillTable();
            QueryDb();
            DropTable();
            m_dbConnection.Close();
        }

        private static void DropTable()
        {
            string sql = "drop table cars";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Name: {reader["name"]} " + $"Year: {reader["year"]}");
            }
        }

        private static void QueryDb()
        {
            string sql = "select * from cars order by year desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"Name: {reader["name"]} " + $"Year: {reader["year"]}");
            }
        }

        private static void FillTable()
        {
            string sql = "insert into cars (name, year) values ('Mustang', 1966)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "insert into cars (name, year) values ('Camaro', 1969)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            sql = "insert into cars (name, year) values ('Corvette', 1972)";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //create table
        private static void CreateTable()
        {
            string sql = "create table cars (name varchar(20), year int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //connect to database
        private static void ConnectDb()
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        //create database
        private static void CreateDb()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
        }
    }
}
