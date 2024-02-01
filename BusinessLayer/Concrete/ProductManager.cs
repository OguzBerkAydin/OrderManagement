using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGet(int id)
        {
            return _productDal.Get(id);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
