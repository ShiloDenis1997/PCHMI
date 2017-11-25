using MinskForYou.Api.Interfaces.Services;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinskForYou.Api.Services {
	internal class PlaceService : IPlaceService {

		private ORM.MinskForYou db = new ORM.MinskForYou();

		public Place GetById(int id) {

			return db.Places.Find(id);
		}
	}
}