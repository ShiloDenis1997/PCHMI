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
using AndroidClient.Droid.Models;

namespace AndroidClient.Droid.ViewModels {
	public class PlaceViewModel : ViewModelBase {

		public Place Place { get; private set; }

		public PlaceViewModel() {
			Place = new Place() {
				Description = @"The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus is located in a park in the Trinity Banlieu of the city of Minsk. "
			};
		}

		public string Name {
			get { return Place.Name; }
			set {
				if (Place.Name != value) {
					Place.Name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		public string Description {
			get { return Place.Description; }
			set {
				if (Place.Description != value) {
					Place.Description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		public double? AverageMark {
			get { return Place.AverageMark; }
			set {
				if (Place.AverageMark != value) {
					Place.AverageMark = value;
					OnPropertyChanged("AverageMark");
				}
			}
		}

	}
}