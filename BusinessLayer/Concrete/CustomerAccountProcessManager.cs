using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CustomerAccountProcessManager : ICustomerAccountProcessService
	{
		private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

		public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
		{
			_customerAccountProcessDal = customerAccountProcessDal;
		}

		public void TAdd(CustomerAccountProcess entity)
		{
			_customerAccountProcessDal.Add(entity);
		}

		public void TDelete(CustomerAccountProcess entity)
		{
			_customerAccountProcessDal.Delete(entity);
		}

		public CustomerAccountProcess TGetById(int id)
		{
			return _customerAccountProcessDal.GetById(id);
		}

		public List<CustomerAccountProcess> TGetList()
		{
			return _customerAccountProcessDal.GetList();
		}

		public void TUpdate(CustomerAccountProcess entity)
		{
			_customerAccountProcessDal.Update(entity);
		}
	}
}