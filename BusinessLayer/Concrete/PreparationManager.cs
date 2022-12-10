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
	public class PreparationManager : IGenericService<Preparation>
	{
		readonly IPreparationDAL _preparationDAL;

		public PreparationManager(IPreparationDAL preparationDAL)
		{
			_preparationDAL = preparationDAL;
		}

		public void Add(Preparation preparation)
		{
			_preparationDAL.Add(preparation);
		}

		public void Delete(Preparation preparation)
		{
			_preparationDAL.Delete(preparation);
		}

        public void Delete(int item)
        {
			_preparationDAL.Delete(item);
        }

        public Preparation? Get(int id)
		{
			return _preparationDAL.Get(id);
		}

		public List<Preparation> GetAll()
		{
			return _preparationDAL.GetAll();
		}

		public void Update(Preparation preparation)
		{
			_preparationDAL.Update(preparation);
		}
	}
}
