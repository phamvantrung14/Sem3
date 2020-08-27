using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPSQLLiteDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Database db;
        private ObservableCollection<Customer> lisCust;

        public MainPage()
        {
            this.InitializeComponent();
            db = new Database();
            lisCust = new ObservableCollection<Customer>();


        }

        private void Retrieve_Click(object sender, RoutedEventArgs e)
        {
            
            db.list(lisCust);
            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            db.insert(new Customer()
            {
                Name = textBox.Text,
                Age = textBox1.Text
            });
            Frame.Navigate(typeof(MainPage));
            textBox.Text = "";
            textBox1.Text = "";
        }
    }
}
