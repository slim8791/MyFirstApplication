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
	public partial class MasterDetailCode : MasterDetailPage
    {
		public MasterDetailCode ()
		{
			InitializeComponent ();
		    IsPresented = true;
		    var masterDetailsItems = new List<MasterDetailItem>
		    {
		        new MasterDetailItem
		        {
		            Title = "Stack Layout Page", TargetType = typeof(StackLayoutPage), IconSource = "number_one.png"
		        },
		        new MasterDetailItem
		        {
		            Title = "Grid Page", TargetType = typeof(GridPage), IconSource = "number_two.png"
		        },
		        new MasterDetailItem
		        {
		            Title = "Absolute Layout Page", TargetType = typeof(AbsoluteLayoutPage), IconSource = "number_three.png"
		        },
		        new MasterDetailItem
		        {
		            Title = "Relative Layout Page", TargetType = typeof(RelativeLayoutPage), IconSource = "number_four.png"
		        }
		    };
		    menuList.ItemsSource = masterDetailsItems;
		    Detail = new NavigationPage((Page) Activator.CreateInstance(typeof(StackLayoutPage)) );

		}

        private void MenuList_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var sel = e.SelectedItem as MasterDetailItem;

            if (sel != null)
            {

                Detail = new NavigationPage((Page)Activator.CreateInstance(sel.TargetType));
                menuList.SelectedItem = false;
                IsPresented = false;
            }

        }
    }
}