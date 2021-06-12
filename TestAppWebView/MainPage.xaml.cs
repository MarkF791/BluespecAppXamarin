using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestAppWebView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var webView = new WebView
            {
                Source = "http://127.0.0.1:8080/bluespec1/clientindex.php",
                MinimumWidthRequest = 200,
                MinimumHeightRequest = 200,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            var stackLayout = new StackLayout();
            this.Content = stackLayout;
            stackLayout.Children.Add(webView);
            stackLayout.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackLayout.VerticalOptions = LayoutOptions.FillAndExpand;
        }
    }
}
