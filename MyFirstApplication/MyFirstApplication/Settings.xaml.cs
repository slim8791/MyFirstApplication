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
	public partial class Settings : ContentPage
	{
		public Settings ()
		{
			InitializeComponent ();
            var app = Application.Current as App;
            title.Text = app.Title;
            notificationsEnabled.On = app.NotificationEnabled;
		}

        private void notificationsEnabled_OnChanged(object sender, ToggledEventArgs e)
        {
            var app = Application.Current as App;
            app.NotificationEnabled = notificationsEnabled.On;
            
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            var app = Application.Current as App;
            app.Title = title.Text;
            app.NotificationEnabled = notificationsEnabled.On;
        }
    }
}