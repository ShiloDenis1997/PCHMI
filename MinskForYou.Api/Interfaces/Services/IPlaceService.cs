using ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MinskForYou.Api.Interfaces.Services {
	public interface IPlaceService {

		//List<Place> Search(Expression<Func<Place, bool>> filter, int skip, int take);

		Place GetById(int id);
	}
}