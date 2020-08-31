using Bai_Nhom_01.Model;
using DataAccesLibrary;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

using static Bai_Nhom_01.Model.NetWork;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Bai_Nhom_01
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            sourceImage.Visibility = Visibility.Collapsed;
        }

       

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Root myNetwork = await NetWork.GetNetwork();
            string image = String.Format(myNetwork.image);
            ResultImage.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
            TemTextBlock.Text = myNetwork.title;
            sourceImage.Text = myNetwork.image;
            DescriptionTextBlock.Text = Convert.ToString(myNetwork.content.description);
            LocationTextBlock.Text = myNetwork.date;

        }

        private async void AddBormarks_Click(object sender, RoutedEventArgs e)
        {
           
            
                   Class1.AddData(sourceImage.Text);
           
            
        }
    }
}
