using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApplication.Extensions
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell : ViewCell

	{
	    public static readonly BindableProperty TextEnteredProperty =
	        BindableProperty.Create("TextEntered", typeof(string), typeof(DateCell));

	    public string TextEntered
	    {
	        get { return (string) GetValue(TextEnteredProperty); }
	        set
	        {
	            SetValue(TextEnteredProperty,value);
	        }
	    }

	    public DateCell ()
		{
			InitializeComponent ();
		    BindingContext = this;
		}
	}
}