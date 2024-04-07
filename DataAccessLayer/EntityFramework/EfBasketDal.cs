using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
	public class EfBasketDal : GenericRepository<Basket>, IBasketDal
	{
		public EfBasketDal(SignalRContext context) : base(context)
		{
		}

		public List<Basket> GetBasketByRestaurantTableNumber(int id)
		{
			using var context = new SignalRContext();
			var values = context.Baskets.Where(x => x.RestaurantTableId == id).Include(y => y.Product).ToList();
			return values;
		}
	}
}
