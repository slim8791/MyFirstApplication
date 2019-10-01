using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyFirstApplication
{
    public partial class App : Application
    {
        public const string TitleKey = "Title";
        public const string NotificationEnabledKey = "NotificationEnabled";
        public string Title
        {
            get
            {
                if (Application.Current.Properties.ContainsKey(TitleKey))
                    return Application.Current.Properties[TitleKey].ToString();
                return "";
            }
            
            set { Application.Current.Properties[TitleKey] = value; }
        }
        public bool NotificationEnabled
        {
            get
            {
                if (Application.Current.Properties.ContainsKey(TitleKey))
                    return (bool) Application.Current.Properties[NotificationEnabledKey];
                return false;
            }

            set { Application.Current.Properties[NotificationEnabledKey] = value; }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StylesExample());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
