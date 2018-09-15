using Projeto03.Model;
using Projeto03.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Projeto03.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaListaPessoa : ContentPage
    {
        public TelaListaPessoa()
        {
            InitializeComponent();

            BindingContext = new TelaListaPessoaViewModel();
        }

        public void ListView_ItemDetail(object sender, ItemTappedEventArgs e)
        {
            Pessoa pessoa = e.Item as Pessoa;

            Navigation.PushAsync(new TelaPessoa(pessoa));
        }
    }
}