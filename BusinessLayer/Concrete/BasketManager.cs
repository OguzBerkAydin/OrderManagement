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
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void TAdd(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public void TDelete(Basket entity)
        {
             _basketDal.Delete(entity);
        }

        public Basket TGet(int id)
        {
            return _basketDal.Get(id);
        }

        public List<Basket> TGetAll()
        {
            throw new NotImplementedException();
        }

        public List<Basket> TGetBasketByRestaurantTableNumber(int id)
        {
            return _basketDal.GetBasketByRestaurantTableNumber(id);
        }

        public void TUpdate(Basket entity)
        {
            throw new NotImplementedException();
        }
    }
}
