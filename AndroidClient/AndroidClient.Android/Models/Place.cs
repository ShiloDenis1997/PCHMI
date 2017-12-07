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

namespace AndroidClient.Droid.Models
{
	public partial class Place {
		
		public Place() {
			//Comments = new HashSet<Comment>();
			//Favorites = new HashSet<Favorite>();
		}

		public int ID { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public int Type { get; set; }

		public double? AverageMark { get; set; }

		public double? Latitude { get; set; }

		public double? Longitude { get; set; }

		//public virtual ICollection<Comment> Comments { get; set; }

		//public virtual ICollection<Favorite> Favorites { get; set; }
	}
}