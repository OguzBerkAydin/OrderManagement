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
			_restaurantTableDal.Add(entity);
		}

		public void TDelete(RestaurantTable entity)
		{
			_restaurantTableDal.Delete(entity);
		}

		public RestaurantTable TGet(int id)
		{
			return _restaurantTableDal.Get(id);
		}

		public List<RestaurantTable> TGetAll()
		{
			return _restaurantTableDal.GetAll();
		}

		public int TTotalTableCount()
		{
			return _restaurantTableDal.TotalTableCount();
		}

		public void TUpdate(RestaurantTable entity)
		{
			_restaurantTableDal.Update(entity);
		}
	}
}
