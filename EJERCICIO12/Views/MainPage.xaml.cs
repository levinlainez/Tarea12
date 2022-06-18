using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EJERCICIO12.Views

{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnMultiplicar_Clicked(object sender, EventArgs e)
        {
            var personas = new Models.Persona
            {
                nombre = txtNombre.Text,
                apellidos = txtApellido.Text,
                edad = Convert.ToInt32(txtEdad.Text),
                correo = txtCorreo.Text,

            };

            var secondPage = new Views.ResultPage();
            secondPage.BindingContext = personas;
            await Navigation.PushAsync(secondPage);
        }
    }
}

