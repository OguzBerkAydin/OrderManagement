using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;

namespace BusinessLayer.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal dicountDal)
        {
            _discountDal = dicountDal;
        }

        public void TAdd(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public Discount TGet(int id)
        {
            return (_discountDal.Get(id));
        }

        public List<Discount> TGetAll()
        {
            return _discountDal.GetAll();
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
