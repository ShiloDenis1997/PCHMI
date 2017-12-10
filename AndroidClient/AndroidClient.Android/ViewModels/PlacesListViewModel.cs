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
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Windows.Input;
using AndroidClient.Droid.Menu;

namespace AndroidClient.Droid.ViewModels {

	public class PlacesListViewModel : ViewModelBase {

		public ObservableCollection<PlaceViewModel> Places { get; set; }

		public INavigation Navigation { get; set; }
		public ICommand BackCommand { protected set; get; }
		PlaceViewModel _selectedPlace;

		public PlacesListViewModel() {
			Places = new ObservableCollection<PlaceViewModel>();
			Places.Add(new PlaceViewModel() { Name = "National Opera and Ballet",
				AverageMark = 4.5,
				Description = "The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus"
			});
			Places.Add(new PlaceViewModel() { Name = "National Opera and Ballet",
				AverageMark = 5,
				Description = "The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus"
			});
			Places.Add(new PlaceViewModel() { Name = "National Opera and Ballet",
				AverageMark = 4.8,
				Description = "The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus"
			});
			Places.Add(new PlaceViewModel() { Name = "National Opera and Ballet",
				AverageMark = 4.5,
				Description = "The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus"
			});
			Places.Add(new PlaceViewModel() { Name = "National Opera and Ballet",
				AverageMark = 4.5,
				Description = "The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus"
			});
			Places.Add(new PlaceViewModel() { Name = "National Opera and Ballet",
				AverageMark = 4.5,
				Description = "The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus"
			});
			OnPropertyChanged("Places");
			BackCommand = new Command(Back);
		}

		public PlaceViewModel SelectedPlace {
			get { return _selectedPlace; }
			set {
				if (_selectedPlace != value) {
					PlaceViewModel tempPlace = value;
					_selectedPlace = null;
					OnPropertyChanged("SelectedPlace");
					Navigation.PushAsync(new PlacePage(tempPlace));
				}
			}
		}

		private void Back() {
			Navigation.PopAsync();
		}

	}
}