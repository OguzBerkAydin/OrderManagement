using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class RestaurantTableManager : IRestaurantTableService
	{
		private readonly IRestaurantTableDal _restaurantTableDal;

		public RestaurantTableManager(IRestaurantTableDal restaurantTableDal)
		{
			_restaurantTableDal = restaurantTableDal;
		}

		public void TAdd(RestaurantTable entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(RestaurantTable entity)
		{
			throw new NotImplementedException();
		}

		public RestaurantTable TGet(int id)
		{
			throw new NotImplementedException();
		}

		public List<RestaurantTable> TGetAll()
		{
			throw new NotImplementedException();
		}

		public int TTotalTableCount()
		{
			return _restaurantTableDal.TotalTableCount();
		}

		public void TUpdate(RestaurantTable entity)
		{
			throw new NotImplementedException();
		}
	}
}
