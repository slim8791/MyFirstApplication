using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace MyFirstApplication
{
	public partial class App : Application
	{
	    public const string TitleKey="Title" ;
	    public const string NotificationEnabledKey= "NotificationEnabled";
	    public string Title { get; set; }
	    public bool NotificationEnabled { get; set; }
        public App ()
		{
			InitializeComponent();

			MainPage = new NavigationPage( new TableRootPage());

        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
