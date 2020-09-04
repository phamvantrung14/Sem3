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
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Practical
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddContacts : Page
    {
        Database db;
        public AddContacts()
        {
            this.InitializeComponent();
            db = new Database();
            
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           int code = db.insert(new Contacts()
            {
                Name = TxtName.Text,
                Phone = TxtPhone.Text
            });
            if(code ==-1)
            {

                var message = new MessageDialog("Add Contact failed");
                await message.ShowAsync();
            }
            else
            {
                var message = new MessageDialog("Add Contact Seccess");
                await message.ShowAsync();
            }
            
            TxtName.Text = "";
            TxtPhone.Text = "";
        }
    }
}
