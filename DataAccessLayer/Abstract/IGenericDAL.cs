using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IGenericDAL<T> where T : class
	{
		void Add(T item);
		void Delete(T item);
		void Delete(int item);
		void Update(T item);
		List<T> GetAll();
		T? Get(int id);
	}
}
