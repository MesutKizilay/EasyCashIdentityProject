using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		public void Add(T entity)
		{
			using var context = new Context();
			context.Set<T>().Add(entity);
			context.SaveChanges();
		}

		public void Delete(T entity)
		{
			using var context = new Context();
			context.Set<T>().Remove(entity);
			context.SaveChanges();
		}

		public T GetById(int id)
		{
			using var context =new Context();
			return context.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			using var context = new Context();
			return context.Set<T>().ToList();
		}

		public void Update(T entity)
		{
			using var context = new Context();
			context.Set<T>().Update(entity);
			context.SaveChanges();
		}
	}
}