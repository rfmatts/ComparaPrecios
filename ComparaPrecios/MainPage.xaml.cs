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
            if (!String.IsNullOrEmpty(Precio.Text) && !String.IsNullOrEmpty(Peso.Text))
            {
                double precio = double.Parse(Precio.Text);
                double cantidad = double.Parse(Peso.Text);
                double precioUnit = 100 * precio / cantidad;
                PrecioU.Text = "$ " + precioUnit.ToString();
            }
            else
            {
                DisplayAlert("DATOS ERRONEOS", "Por favor ingresa todos los datos", "Ok");
            }
        }

        private void Limpiar(object sender, EventArgs e)
        {
            Precio.Text = "";
            Peso.Text = "";
            PrecioU.Text = "";
        }
    }
}


