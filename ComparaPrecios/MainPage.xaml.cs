using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ComparaPrecios
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Precio.Text) && !String.IsNullOrEmpty(PesoCant.Text) && !String.IsNullOrEmpty(PesoOtro.Text))
            {
                double precio = double.Parse(Precio.Text);
                double pesoCantidad = double.Parse(PesoCant.Text);
                double pesoOtro = double.Parse(PesoOtro.Text);
                double precioUnit = pesoOtro * precio / pesoCantidad;
                if (precioUnit.ToString().Contains('\u002e'))
                {
                    PrecioU.Text = "$ " + precioUnit.ToString().Substring(0, precioUnit.ToString().IndexOf(".") + 3);
                }
                else if (precioUnit.ToString().Contains('\u002c'))
                {
                    PrecioU.Text = "$ " + precioUnit.ToString().Substring(0, precioUnit.ToString().IndexOf(",") + 3);
                }
            }
            else
            {
                DisplayAlert("DATOS ERRONEOS", "Por favor ingresa todos los datos", "Ok");
            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            Precio.Text = "";
            PesoCant.Text = "";
            PrecioU.Text = "";
            PesoOtro.Text = "";
        }
    }
}


