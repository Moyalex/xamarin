using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(altura.Text) && !string.IsNullOrEmpty(peso.Text))
            {
                var alt = double.Parse(altura.Text);
                var p = double.Parse(peso.Text);

                var im = p / (alt + alt);
                imc.Text = im.ToString();

                string resultado = "";
                if (im < 18.5)
                {
                    resultado = "Tienes peso bajo";
                }
                else if (im >= 18.5 && im <= 24.9)
                {
                    resultado = "Tu peso es normal";
                }
                else if (im >= 25 && im <= 29.9)
                {
                    resultado = "Tienes sobrepeso";
                }
                else
                {
                    resultado = "Tienes Obesidad, ¡Cuidate!";
                }
                DisplayAlert("Resultado", resultado, "Ok");

            }
            else
            {
                DisplayAlert("Datos Erroneos","Por favor, llena toda la informacion","Ok");
            }
        }
    }
}
