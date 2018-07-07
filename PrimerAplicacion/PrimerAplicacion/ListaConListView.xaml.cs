using PrimerAplicacion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimerAplicacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaConListView : ContentPage
	{
		public ListaConListView ()
		{
			InitializeComponent ();

            //string[] animales = { "perro", "gato" };

            //lvListaPrincipal.ItemsSource = animales;

            var animales = new List<Animal>();

            animales.Add(new Animal() {
                Tipo = "Mono",
                Nombre = "Capuchino",
                Imagen = "https://www.flickr.com/photos/90047005@N00/3377434548"
            });
            animales.Add(new Animal()
            {
                Tipo = "Mono",
                Nombre = "Titi",
                Imagen = "http://world-beautifulwallpapers.blogspot.com/2013/06/monkey-hd-wallpapers.html"
            });
            animales.Add(new Animal()
            {
                Tipo = "Perro",
                Nombre = "Labrador",
                Imagen = "https://cdn.pixabay.com/photo/2016/12/13/05/15/puppy-1903313_960_720.jpg"
            });
            animales.Add(new Animal()
            {
                Tipo = "Perro",
                Nombre = "Husky",
                Imagen = "https://cdn.pixabay.com/photo/2018/05/07/10/48/husky-3380548_960_720.jpg"
            });

            lvListaPrincipal.ItemsSource = animales;
        }
	}
}