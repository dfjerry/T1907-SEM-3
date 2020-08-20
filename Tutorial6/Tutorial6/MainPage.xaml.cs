using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Tutorial6.Models;
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
using static Tutorial6.Models.GetWeatherData;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Tutorial6
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)//sự kiện gọi bất đồng bộ thì cũng phải bđb
        {
            RootObject myWeather = await GetWeatherData.getOpenWeather();// myWeather là root object
            string icon = string.Format("http://openweathermap.org/img/w/{0}.png", myWeather.weather[0].icon);//root object -> weather -> icon
            ResultIconImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));//bitmapimage để hiển thị ảnh ra, urikind.absolut -> lay đường dẫn tuyệt đối
            ResultWeatherTextBlock.Text = myWeather.name + "-"
                + ((int)myWeather.main.temp).ToString();//đổi sang string in ra được bên ngoài    //   + "-" + myWeather.weather[0]

        }
    }
}
