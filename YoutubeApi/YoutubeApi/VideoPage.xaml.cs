using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using MyToolkit.Multimedia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.WindowsRuntime;
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
using YoutubeApi.Model;
using static MyToolkit.Multimedia.YouTube;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace YoutubeApi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VideoPage : Page
    {
        Google.Apis.YouTube.v3.Data.Video video;
        public VideoPage()
        {
            this.InitializeComponent();
        }
       
        public object Youtube { get; private set; }

        protected override async  void OnNavigatedTo(NavigationEventArgs e)
        {
            string YouTubeId = "eVkO-vbcKOs";
           
           
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    video = e.Parameter as Google.Apis.YouTube.v3.Data.Video;
                    
                    YouTubeUri url = await YouTube.GetVideoUriAsync(video.Id, YouTubeQuality.Quality480P);
                    MediaElt.Source = url.Uri;
                    MediaElt.Play();
                    
                   
                }
                else
                {
                    MessageDialog message = new MessageDialog("You are not connected to Internet");
                    await message.ShowAsync();
                    this.Frame.GoBack();
                }
            }
            catch { }
            base.OnNavigatedTo(e);
        }
        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new object());
        }
    }
}
