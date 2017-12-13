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
				Description = @"The National Academic Grand Opera and Ballet Theatre of the Republic of Belarus is located in a park in the Trinity Banlieu of the city of Minsk. Local people call it the "
					+ "Opierny Teatr (Belarusian) or the Opera and Ballet Theatre. It opened on 15 May 1933 but it first did not have its own venue for presentations at the Belarusian Drama Theatre building until 1938."

					+ "The first permanent theatre was founded in Belarus in 1933 on the basis of the Belarusian opera and ballet school,"
					+ "the organizer of the studio being the famous Russian Opera singer Anton Bonachich(Bonatschitsch)(ru: Антон Петрович Боначич).He was the first head of the new theatre.But he stayed in this position for a very short time, dying in 1933."

					+ "current theatre building was opened in 1939.It was designed by the Belarus architect from Leningrad, Iosif Langbard, whose original design was only partially implemented and some design details were omitted yielding to financial and other problems; the theatre has reliefs done by Zair Azgur."
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