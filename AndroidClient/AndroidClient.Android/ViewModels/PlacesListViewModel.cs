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

namespace AndroidClient.Droid.ViewModels {

	public class PlacesListViewModel : ViewModelBase {

		public ObservableCollection<PlaceViewModel> Places { get; set; }

		public INavigation Navigation { get; set; }
		public ICommand BackCommand { protected set; get; }
		PlaceViewModel _selectedPlace;

		public PlacesListViewModel() {
			Places = new ObservableCollection<PlaceViewModel>();
			Places.Add(new PlaceViewModel() { Name = "aaa", Description = "aaaaaaaaaaaaaaaaaaaaaaa" });
			Places.Add(new PlaceViewModel() { Name = "bbb", Description = "bbbbbbbbbbbbbbbbbbbbbbb" });
			Places.Add(new PlaceViewModel() { Name = "ccc", Description = "ccccccccccccccccccccccc" });
			Places.Add(new PlaceViewModel() { Name = "aaa", Description = "aaaaaaaaaaaaaaaaaaaaaaa" });
			Places.Add(new PlaceViewModel() { Name = "bbb", Description = "bbbbbbbbbbbbbbbbbbbbbbb" });
			Places.Add(new PlaceViewModel() { Name = "ccc", Description = "ccccccccccccccccccccccc" });
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
					//Navigation.PushAsync(new FriendPage(tempPlace));
				}
			}
		}

		private void Back() {
			Navigation.PopAsync();
		}

	}
}