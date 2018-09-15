using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _02_Mensagens
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Informativo", "Esta aplicação está na versão Beta!", "OK");

            bool mensagem = await DisplayAlert("Excluir Registro", "Você tem certeza que deseja excluir este registro?", "Sim", "Não");
            lblResultado.Text = mensagem.ToString();
        }

        private async void Button_Clicked_Action(object sender, EventArgs e)
        {
            var resultado = await DisplayActionSheet("Qual é a sua linguagem preferida?", "Cancelar", "Fechar", "C#", "JavaScript", "Phyton", "Ruby", "Java");
            lblResultado.Text = resultado;
        }
    }
}
