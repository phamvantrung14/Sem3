using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSQLLiteDemo
{
    public class Database
    {
        string path;
        SQLiteConnection conn;
        public Database()
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn =new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<Customer>();
        }
        
        public void list(ObservableCollection<Customer> lisCus)
        {
            var query = conn.Table<Customer>();
            foreach (var message in query)
            {
                lisCus.Add(message);
            }
        }

        public void insert(Customer cust)
        {
            conn.Insert(new Customer()
            {
                Name = cust.Name,
                Age = cust.Age
            });
        }

       
    }
}
