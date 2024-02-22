using EntityLayer.Entities;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
        int TProductCount();
        int TProductCountByCategoryName(string categoryName);
        decimal TProductPriceAvg(string? categoryName = null);
        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
    }
}
