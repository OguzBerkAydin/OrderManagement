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
	public class MoneyCaseManager : IMoneyCaseService
	{
		private readonly IMoneyCaseDal _moneyCaseDal;

		public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
		{
			_moneyCaseDal = moneyCaseDal;
		}

		public void TAdd(MoneyCase entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(MoneyCase entity)
		{
			throw new NotImplementedException();
		}

		public MoneyCase TGet(int id)
		{
			throw new NotImplementedException();
		}

		public List<MoneyCase> TGetAll()
		{
			throw new NotImplementedException();
		}

		public decimal TTotalAmountOfMoneyCase()
		{
			return _moneyCaseDal.TotalAmountOfMoneyCase();
		}

		public void TUpdate(MoneyCase entity)
		{
			throw new NotImplementedException();
		}
	}
}
