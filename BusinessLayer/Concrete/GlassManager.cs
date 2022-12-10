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
	public class GlassManager : IGenericService<Glass>
	{
		readonly IGlassDAL _glassDAL;

		public GlassManager(IGlassDAL glassDAL)
		{
			_glassDAL = glassDAL;
		}

		public void Add(Glass glass)
		{
			_glassDAL.Add(glass);
		}

		public void Delete(Glass glass)
		{
			_glassDAL.Delete(glass);
		}

        public void Delete(int item)
        {
            _glassDAL.Delete(item);
        }

        public Glass? Get(int id)
		{
			return _glassDAL.Get(id);
		}

		public List<Glass> GetAll()
		{
			return _glassDAL.GetAll();
		}

		public void Update(Glass glass)
		{
			_glassDAL.Update(glass);
		}
	}
}
