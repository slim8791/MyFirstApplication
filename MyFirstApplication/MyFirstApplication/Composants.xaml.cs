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
	public partial class Composants : ContentPage
	{
		public Composants ()
		{
			InitializeComponent ();
		}

	    private void Switch_OnToggled(object sender, ToggledEventArgs e)
	    {
	        

	    }
	}
}