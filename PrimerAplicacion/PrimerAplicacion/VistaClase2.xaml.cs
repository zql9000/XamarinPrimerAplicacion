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
	public partial class VistaClase2 : ContentPage
	{
		public VistaClase2 ()
		{
			InitializeComponent ();

            var estilo = new Style(typeof(Label))
            {
                //Setters = new Setter() {
                //    Property = Label.TextColorProperty,
                //    Value = Color.Yellow
                //}
            };

            for (int i = 0; i < 50; i++)
            {
                slPrincipal.Children.Add(new Label()
                {
                    Text = "Elemento " + i.ToString(),
                    TextColor = Color.Red,
                    Style = estilo
                });
            }
        }
	}
}