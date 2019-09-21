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
	public partial class AbsoluteLayoutPage : ContentPage
	{
		public AbsoluteLayoutPage ()
		{
			InitializeComponent ();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        DisplayAlert("TEK-UP", "Hello world !! ","OK");
	    }
	}
}