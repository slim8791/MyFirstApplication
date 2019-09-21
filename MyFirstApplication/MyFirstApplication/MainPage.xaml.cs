using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyFirstApplication
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
		    switch (Device.RuntimePlatform)
		    {
                case Device.iOS: 
                    BackgroundColor = Color.Blue;
                    break;
                case Device.Android: 
                    BackgroundColor = Color.BlueViolet;
                    break;
                case Device.UWP:
                    BackgroundColor = Color.Yellow;
                    break;
                default:
                    BackgroundColor = Color.DarkKhaki;
                    break;
            }

			InitializeComponent();
		    slider.Value = 15;

        }

        private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
	    {
	        label.Text = String.Format("Value is {0:F2} ", e.NewValue);

	    }
	}
}
