using MinskForYou.Api.Interfaces.Services;
using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using MinskForYou.Api.Models;

namespace MinskForYou.Api.Services {
	internal class PlaceService : IPlaceService {

		private ORM.MinskForYou db = new ORM.MinskForYou();

		public Place GetById(int id) {

			return db.Places.Find(id);
		}

		public List<Place> Search(string name = null, int type = -1, Sortings order = Sortings.Default) {
			var result = GetAllPlaces()
				.Where(p => (string.IsNullOrEmpty(name) 
				|| p.Name.ToLower().Contains(name.ToLower())
				&& (type < 0 || p.Type == type))).ToList();
			if (order == Sortings.ByName)
				return result.OrderBy(p => p.Name).ToList();
			if (order == Sortings.ByRating)
				return result.OrderBy(p => p.AverageMark).ToList();
			return result;
		}

		private List<Place> GetAllPlaces() {
			return db.Places.ToList();
		}
	}
}