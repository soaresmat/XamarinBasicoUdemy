using Projeto02.Lógica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projeto02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BtnSoma.Clicked += delegate
            {
                int num1 = int.Parse(Numero1.Text);
                int num2 = int.Parse(Numero2.Text);

                Resultado.Text = "O resultado da soma é: " + Matematica.Soma(num1, num2).ToString();
            };
        }
    }
}
