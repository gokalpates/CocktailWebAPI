using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDAL<T> where T : class
	{
		protected Context _context = new Context();

		virtual public void Add(T item)
		{
			_context.Add(item);
			_context.SaveChanges();
		}

		virtual public void Delete(T item)
		{
			_context.Remove(item);
			_context.SaveChanges();
		}

		virtual public void Delete(int item)
		{
            _context.Remove(Get(item));
			_context.SaveChanges();
		}

		virtual public T? Get(int id)
		{
			return _context.Set<T>().Find(id);
		}

		virtual public List<T> GetAll()
		{
			return _context.Set<T>().ToList();
		}

		virtual public void Update(T item)
		{
			_context.Update(item);
			_context.SaveChanges();
		}

	}
}
