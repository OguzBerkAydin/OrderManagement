﻿using EntityLayer.Entities;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCount();
        int ProductCountByCategoryName(string categoryName);
        decimal ProductPriceAvg(string? categoryName = null);
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
    }
}
