using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_Practical.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Practical
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShowContacts : Page
    {
        Database db;
        private ObservableCollection<Contacts> listContact;

        public ShowContacts()
        {
            this.InitializeComponent();
            db = new Database();
            listContact = new ObservableCollection<Contacts>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //db.list(listContact);
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = TxtName.Text;
            string phone = TxtPhone.Text;
            try
            {
                db.Search(name, phone, listContact);

            }catch(Exception ex)
            {
                var message = new MessageDialog(" failed");
                await message.ShowAsync();
            }


        }

      
    }
}
