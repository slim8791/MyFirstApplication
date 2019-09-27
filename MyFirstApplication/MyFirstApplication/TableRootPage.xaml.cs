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
	public partial class TableRootPage : ContentPage
	{
		public TableRootPage ()
		{
			InitializeComponent ();
		}

	    private void Cell_OnTapped(object sender, EventArgs e)
	    {
            var page = new ContactMethods();
	        page.ContactMethod.ItemSelected += (s, args) =>
	        {
	            contactMethodValue.Text = args.SelectedItem.ToString();
	            Navigation.PopAsync();

	        };
	        Navigation.PushAsync(page);


	    }
	}
}