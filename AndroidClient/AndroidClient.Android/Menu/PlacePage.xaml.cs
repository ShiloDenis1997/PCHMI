﻿using AndroidClient.Droid.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidClient.Droid.Menu {

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlacePage : ContentPage {

		public PlaceViewModel ViewModel { get; private set; }

		public PlacePage(PlaceViewModel vm) {
			InitializeComponent();
			ViewModel = vm;
			this.BindingContext = ViewModel;
		}

	}
}