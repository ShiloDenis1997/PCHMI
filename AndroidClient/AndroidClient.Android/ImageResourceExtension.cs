using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidClient.Droid {
	[ContentProperty("Source")]
	public class ImageResourceExtension : IMarkupExtension {
		public string Source { get; set; }

		public object ProvideValue(IServiceProvider serviceProvider) {
			if (Source == null) {
				return null;
			}
			// Do your translation lookup here, using whatever method you require
			var imageSource = ImageSource.FromUri(new Uri("https://xamarin.com/content/images/pages/forms/example-app.png"));

			return imageSource;
		}
	}
}