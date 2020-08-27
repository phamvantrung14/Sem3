﻿using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
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
using Video = YoutubeApi.Model.Video;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace YoutubeApi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private YouTubeService youTubeService = new YouTubeService(new BaseClientService.Initializer
        {
            //ApiKey = "AIzaSyBSj8PzW_ybKeUtGDbnvzjoMnSP5REqkDA",
            ApiKey = "AIzaSyDQDvH9uUsjE8vfXfMY70kU17j8KOG7JrU",
            ApplicationName = "youtube"
        });
        List<Video> ListVideo = new List<Video>();
        private string TokenNextPage = null, TokenPrivPage = null;
        public MainPage()
        {
            this.InitializeComponent();
            GetVideo();
        }
        private async void GetVideo(string PageToken = null)
        {
            try
            {
                if(NetworkInterface.GetIsNetworkAvailable())
                {
                    var Request = youTubeService.Search.List("snippet");
                    Request.ChannelId = "UCsooa4yRKGN_zEE8iknghZA";
                    Request.MaxResults = 25;
                    Request.Type = "video";
                    Request.Order = SearchResource.ListRequest.OrderEnum.Date;
                    Request.PageToken = PageToken;
                    var Result = await Request.ExecuteAsync();
                    if (Result.NextPageToken != null)
                        TokenNextPage = Result.NextPageToken;
                    if (Result.PrevPageToken != null)
                        TokenPrivPage = Result.PrevPageToken;
                    foreach(var item in Result.Items)
                    {
                        ListVideo.Add(new Video
                        {
                            Title = item.Snippet.Title,
                            Id = item.Id.VideoId,
                            Img = item.Snippet.Thumbnails.Default__.Url
                        });
                    }
                    lv.ItemsSource = null;
                    lv.ItemsSource = ListVideo;
                }
                else
                {
                    MessageDialog msg = new MessageDialog("check your internet connection");
                    await msg.ShowAsync();
                }
            }catch
            {

            }
        }
        private void lv_ItemClick(object sender, ItemClickEventArgs e)
        {
            Video video = e.ClickedItem as Video;
            Frame.Navigate(typeof(VideoPage), video);
        }
    }
}