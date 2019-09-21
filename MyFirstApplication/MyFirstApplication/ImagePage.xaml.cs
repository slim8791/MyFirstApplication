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
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();
            //image.Source 
            var source = (UriImageSource) ImageSource.FromUri(new Uri("http://lorempixel.com/1920/1080/sports/6/"));
		    source.CachingEnabled = false;
		    source.CacheValidity = TimeSpan.FromDays(1);
		    image.Source = source;


		}
	}
}