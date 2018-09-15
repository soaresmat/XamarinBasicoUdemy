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
    public partial class TelaPessoa : ContentPage
    {
        public TelaPessoa(Pessoa pessoa)
        {
            InitializeComponent();

            BindingContext = new TelaPessoaViewModel(pessoa);
        }
    }
}