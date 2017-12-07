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
using System.ComponentModel;

namespace AndroidClient.Droid.ViewModels {

	public class ViewModelBase : INotifyPropertyChanged {

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propName) {
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
		}
	}

}