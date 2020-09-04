using YoutubeAppAPIDemo.Models;
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
using static YoutubeAppAPIDemo.Models.Paper;
using SQLite.Net.Attributes;
using System.Diagnostics;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace YoutubeAppAPIDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        SQLite.Net.SQLiteConnection conn;
        public class BookMark
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string image { get; set; }
            public string date { get; set; }
            public string description { get; set; }
            public string title { get; set; }
        }
        public MainPage()
        {
            this.InitializeComponent();
            string path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<BookMark>();
          
            var query = conn.Table<BookMark>();
            string date = "";
            string title = "";
            string image = "";
            string desc = "";
            foreach(var bookmark in query)
            {
                date = bookmark.date;
                title = bookmark.title;
                image = bookmark.image;
                desc = bookmark.description;
            }
                
        }
        public async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                RootObject myPage = await Paper.GetPaper();
                string image = String.Format(myPage.image);
                ImageResult.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                DateResult.Text = myPage.date;
                TitleResult.Text = myPage.title;
                string description = myPage.content.description;
                ContentResult.Text = description;
            }
            catch (Exception ex)
            {

            }
        }

        public async void Button_Click(object sender, RoutedEventArgs e)
        {
      
            var page = conn.Insert(new BookMark()
            {
                date = DateResult.Text,
                title = TitleResult.Text,
                image = ImageResult.Source.ToString(),
                description = ContentResult.Text,
            });
        }
    }
}