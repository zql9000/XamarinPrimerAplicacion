using PrimerAplicacion.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimerAplicacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            var jugadores = AgregarJugadores();

            lvJugadores.ItemsSource = jugadores;
		}

        private List<Jugador> AgregarJugadores()
        {
            var jugadores = new List<Jugador>();

            jugadores.Add(new Jugador()
            {
                Nombre = "Wilfredo",
                Apellido = "Caballero",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/181440_sq-300_jpg",
                Pais = "Argentina",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/arg"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "Eden",
                Apellido = "Hazard",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/273996_sq-300_jpg",
                Pais = "Bélgica",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/bel"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "James",
                Apellido = "Rodriguez",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/269058_sq-300_jpg",
                Pais = "Colombia",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/col"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "Andrés",
                Apellido = "Iniesta",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/183857_sq-300_jpg",
                Pais = "España",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/esp"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "Guillermo",
                Apellido = "Ochoa",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/215285_sq-300_jpg",
                Pais = "México",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/mex"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "Ahmed",
                Apellido = "Musa",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/344714_sq-300_jpg",
                Pais = "Nigeria",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/nga"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "Luis",
                Apellido = "Advíncula",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/349697_sq-300_jpg",
                Pais = "Perú",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/per"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "Shinwook",
                Apellido = "Kim",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/321745_sq-300_jpg",
                Pais = "Corea del sur",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/kor"
            });

            jugadores.Add(new Jugador()
            {
                Nombre = "Fernando",
                Apellido = "Muslera",
                Foto = "https://api.fifa.com/api/v1/picture/players/2018fwc/229498_sq-300_jpg",
                Pais = "Uruguay",
                Bandera = "https://api.fifa.com/api/v1/picture/flags-fwc2018-4/uru"
            });

            return jugadores;
        }

        private void lvJugadores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DisplayAlert("Jugador seleccionado", e.SelectedItem.ToString(), "Aceptar");
        }
    }
}