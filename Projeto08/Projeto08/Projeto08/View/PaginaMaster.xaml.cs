using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto08.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaMaster : MasterDetailPage
    {
        public PaginaMaster()
        {
            InitializeComponent();
        }

        private void OnPagina1Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PaginaConteudo());
            IsPresented = false;
        }

        private void OnPagina2Tapped(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new PaginaConteudo2());
            IsPresented = false;
        }
    }
}