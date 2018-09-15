using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace _01_Dicas_ServicoCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCEP.Text) && txtCEP.Text.Length == 8)
            {
                lblResultado.Text = await ServicoCEP.BuscaCEP(txtCEP.Text);
            }
            else
            {
                lblResultado.Text = "O CEP digitado é inválido!";
                lblResultado.TextColor = Color.Red;
            }
        }
    }
}
