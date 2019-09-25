using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SimpleListView : ContentPage
	{
		public SimpleListView ()
		{
		    InitializeComponent();

            var jours = new List<string>
		    {
		        "Lundi",
		        "Mardi","Mercredi","Jeudi","Vendredi","Samedi","Dimance"
		    };
            List<Employe> employes = new List<Employe>( );
            Employe emp1 = new Employe {Nom = "Slim", Poste = "Enseignant " ,UrlImage = "http://lorempixel.com/100/100/people/1" };
		    Employe emp2 = new Employe { Nom = "Ali", Poste = "Dévelppeur ", UrlImage = "http://lorempixel.com/100/100/people/2" };
		    employes.Add(emp1);
		    employes.Add(emp2);

		    listView.ItemsSource = employes;


		}
	}
}