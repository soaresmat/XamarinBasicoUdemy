using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Projeto01.Droid
{
	[Activity (Label = "Projeto01.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        private EditText numero1, numero2;
        private Button btnSomar;
        private TextView resultado;

        protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

            SetContentView(Resource.Layout.Layout01);

            numero1 = FindViewById<EditText>(Resource.Id.txtNumero1);
            numero2 = FindViewById<EditText>(Resource.Id.txtNumero2);
            btnSomar = FindViewById<Button>(Resource.Id.btnSomar);
            resultado = FindViewById<TextView>(Resource.Id.result);

            btnSomar.Click += delegate
            {
                int num1 = Convert.ToInt32(numero1.Text);
                int num2 = Convert.ToInt32(numero2.Text);

                int resultadoSoma = MyClass.Soma(num1, num2);

                resultado.Text = string.Format("O resultado da soma é: {0}", resultadoSoma);
            };       
		}
	}
}