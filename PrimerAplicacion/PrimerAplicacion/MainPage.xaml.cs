using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimerAplicacion
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (txtUsuario.Text != null && txtUsuario.Text.Equals("Usuario") &&
                txtPassword.Text != null && txtPassword.Text.Equals("1234"))
            {
                //DisplayAlert("Mensaje", "Hola " + txtUsuario.Text + "!", "OK");
                Navigation.PushAsync(new NuevaPagina(), true);
            }
            else
            {
                DisplayAlert("Mensaje", "Usuario y/o contraseña incorrectos.", "OK");
            }
        }
    }
}
