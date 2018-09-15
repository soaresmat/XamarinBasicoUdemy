using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto06.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();

            var paginaHTML = new HtmlWebViewSource()
            {
                Html = "<html><body>Esta é uma WebView executando HTML local.<body></html>"
            };

            webView.Source = paginaHTML;
        }
    }
}