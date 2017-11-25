using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AndroidClient.Droid.Menu {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuMaster : ContentPage {
		public ListView ListView;

		public MenuMaster() {
			InitializeComponent();

			BindingContext = new MenuMasterViewModel();
			ListView = MenuItemsListView;
		}

		class MenuMasterViewModel : INotifyPropertyChanged {
			public ObservableCollection<MenuMenuItem> MenuItems { get; set; }

			public MenuMasterViewModel() {
				MenuItems = new ObservableCollection<MenuMenuItem>(new[]
				{
					new MenuMenuItem { Id = 0, Title = "Main" },
					new MenuMenuItem { Id = 1, Title = "Search" },
					new MenuMenuItem { Id = 2, Title = "Favorites" },
					new MenuMenuItem { Id = 3, Title = "Login" },
				});
			}

			#region INotifyPropertyChanged Implementation
			public event PropertyChangedEventHandler PropertyChanged;
			void OnPropertyChanged([CallerMemberName] string propertyName = "") {
				if (PropertyChanged == null)
					return;

				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
			#endregion
		}
	}
}