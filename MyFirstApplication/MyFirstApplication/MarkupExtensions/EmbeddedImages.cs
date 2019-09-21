using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApplication.MarkupExtensions
{
    [ContentProperty("ResourceId")]
    public class EmbeddedImages: IMarkupExtension
    {
        public string ResourceId { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if(!string.IsNullOrEmpty(ResourceId))
            return ImageSource.FromResource( ResourceId);
            return null;
        }
    }
}
