﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider entity)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Slider entity)
        {
            throw new NotImplementedException();
        }

        public Slider TGet(int id)
        {
            throw new NotImplementedException();
        }

        public List<Slider> TGetAll()
        {
            return _sliderDal.GetAll();
        }

        public void TUpdate(Slider entity)
        {
            throw new NotImplementedException();
        }
    }
}
