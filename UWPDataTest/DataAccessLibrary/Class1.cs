using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Windows.Storage;

namespace DataAccessLibrary
{
    public class Class1
    {
        public async static void InittializeDatabase()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("sqliteSample.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqliteSample.db");
            using (SqliteConnection db =
        new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS MyTable (Primary_Key INTEGER PRIMARY KEY, " +
                    "Text_Entry NVARCHAR(2048) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
        public static void AddData(string inputText)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqliteSample.db");
            using(SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand insertComand = new SqliteCommand();
                insertComand.Connection = db;

                insertComand.CommandText = "INSERT INTO MyTable VALUES(NULL, @Entry);";
                insertComand.Parameters.AddWithValue("@Entry",inputText);
                insertComand.ExecuteReader();
                db.Close();
            }
        }

        public static List<String> GetData()
        {
            List<string> entries = new List<string>();
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqliteSample.db");
            using (SqliteConnection db = new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                SqliteCommand selectCommand = new SqliteCommand("SELECT Text_Entry from MyTable", db);
                SqliteDataReader query = selectCommand.ExecuteReader();
                while(query.Read())
                {
                    entries.Add(query.GetString(0));
                }
                db.Close();
            }
            return entries;
        }
    }
}
