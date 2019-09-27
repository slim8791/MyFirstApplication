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
	public partial class EmployeInfo : ContentPage
	{
        public Employe Employe { get; set; }
		public EmployeInfo ()
		{
			InitializeComponent ();
		}
	    public EmployeInfo(Employe _employe)
            
	    {
	        InitializeComponent();
	        this.Employe = _employe;
	        BindingContext = Employe;
	    }
    }
}