using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLite.Net.Attributes;
using System.Collections.ObjectModel;
using SQLiteDemo.Model;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SQLiteDemo
{
   
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        private ObservableCollection<Customer> Contacts;
        public MainPage()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path,"db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(),path);
            conn.CreateTable<Customer>();
            //Contacts = new ObservableCollection<Customer>();
            
         
        }

        private void Retrieve_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<Customer>();
            string id = "";
            string name = "";
            string age = "";
            foreach (var message in query)
            {
                id = id + " " + message.Id;
                name = name + " " + message.Name;
                age = age + " " + message.Age;
                textBlock2.Text = "ID: " + id + "\nName: " + name + "\nAge: " + age;
                //br.Text = "-----------\n";
                // Contacts.Add(new Customers {Id = Convert.ToString(message.Id),Name = message.Name,Age=message.Age });
                //Contacts.Add(message);
            }

           
           

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var s=conn.Insert(new Customer()
            {
                Name = TextBox.Text,
                Age = textBox1.Text
            });

        }
    }
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
