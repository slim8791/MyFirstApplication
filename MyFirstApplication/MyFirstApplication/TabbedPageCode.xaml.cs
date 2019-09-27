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
	public partial class TabbedPageCode : TabbedPage
	{
		public TabbedPageCode ()
		{
			InitializeComponent ();
		}
	}
}