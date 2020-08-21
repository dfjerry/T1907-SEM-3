
using MyToolkit.Multimedia;
using System;
using System.Net.NetworkInformation;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using YoutubeDemoApp;
using YoutubeDemoApp.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace YoutubeDemoApp
{
  
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VideoPage : Page
    {
    
        Video video;
        public VideoPage()
        {
            this.InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable())
                {
                    video = e.Parameter as Video;
                    YouTubeUri Url = await YouTube.GetVideoUriAsync(video.Id, YouTubeQuality.Quality1080P, YouTubeQuality.Quality480P);
                   
                    Player.Source = Url.Uri;
                    Player.Play();
                }
                else
                {
                    MessageDialog message = new MessageDialog("You are not connected to Internet");
                    await message.ShowAsync();
                    this.Frame.GoBack();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            base.OnNavigatedTo(e);
        }
        private void btnHomePage_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), new object());
        }
    }
}
