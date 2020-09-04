﻿using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Practical.Models
{
    public class Database
    {
        string path;
        SQLiteConnection conn;
        public Database()
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<Contacts>();
        }

        public void list(ObservableCollection<Contacts> listConTacts)
        {
            var query = conn.Table<Contacts>();
            foreach(var message in query)
            {
                listConTacts.Add(message);
            }
        }
       


        public void insert(Contacts cont)
        {
            conn.Insert(new Contacts()
            {
                Phone = cont.Phone,
                Name = cont.Name
            });
        }
        public void Search(string name, string phone, ObservableCollection<Contacts> listConTacts)
        {
           
                var querrysearch = conn.Query<Contacts>("select * from Contacts where Name = ? and Phone = ?", name, phone);

                foreach (var q in querrysearch)
                {
                    listConTacts.Add(q);
                }
               
           
           
        }
    }
}