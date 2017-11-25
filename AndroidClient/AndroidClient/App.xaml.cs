using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AndroidClient
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			if (Device.RuntimePlatform == Device.Android)
				MainPage = new AndroidClient.Droid.Menu.Menu();
			else
				MainPage = new AndroidClient.MainPage();
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
