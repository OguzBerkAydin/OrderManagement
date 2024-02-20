using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
	public class EfProductDal : GenericRepository<Product>, IProductDal
	{
		public EfProductDal(SignalRContext context) : base(context)
		{
		}

		public List<Product> GetProductsWithCategories()
		{
			var context = new SignalRContext();
			var values = context.Products.Include(x => x.Category).ToList();
			return values;
		}

		public int ProductCount()
		{
			using var context = new SignalRContext();
			return context.Products.Count();
		}

		public int ProductCountByCategoryName(string categoryName)
		{
			using var context = new SignalRContext();
			return context.Products.Count(product => product.Category.CategoryName == categoryName);
		}

		public string ProductNameByMaxPrice()
		{
			using var context = new SignalRContext();
			var maxPrice = context.Products.Max(p => p.Price);
			return context.Products.FirstOrDefault(p => p.Price == maxPrice).ProductName;

		}

		public string ProductNameByMinPrice()
		{
			using var context = new SignalRContext();
			var minPrice = context.Products.Min(p => p.Price);
			return context.Products.FirstOrDefault(p => p.Price == minPrice).ProductName;

		}

		public decimal ProductPriceAvg()
		{
			using var context = new SignalRContext();
			return context.Products.Average(product => product.Price);
		}
	}

}
