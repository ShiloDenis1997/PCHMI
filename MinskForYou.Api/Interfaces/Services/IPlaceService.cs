using MinskForYou.Api.Models;
using ORM;
using System.Collections.Generic;

namespace MinskForYou.Api.Interfaces.Services {
	public interface IPlaceService {

		Place GetById(int id);

		List<Place> Search(string name = null, int type = -1, Sortings order = Sortings.Default);

	}
}