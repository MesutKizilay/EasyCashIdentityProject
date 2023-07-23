using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CustomerAccountManager : ICustomerAccountService
	{
		private readonly ICustomerAccountDal _customerAccountDal;

		public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
		{
			_customerAccountDal = customerAccountDal;
		}

		public void TAdd(CustomerAccount entity)
		{
			_customerAccountDal.Add(entity);
		}

		public void TDelete(CustomerAccount entity)
		{
			_customerAccountDal.Delete(entity);
		}

		public CustomerAccount TGetById(int id)
		{
			return _customerAccountDal.GetById(id);
		}

		public List<CustomerAccount> TGetList()
		{
			return _customerAccountDal.GetList();
		}

		public void TUpdate(CustomerAccount entity)
		{
			_customerAccountDal.Update(entity);
		}
	}
}