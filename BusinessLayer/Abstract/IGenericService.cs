using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		public void Add(T item);

		public void Delete(T item);

		public void Delete(int item);

		public void Update(T item);

		public List<T> GetAll();

		T? Get(int id);
	}
}
