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
	public class ColorManager : IGenericService<Color>
	{
		readonly IColorDAL _colorDAL;

		public ColorManager(IColorDAL colorDAL)
		{
			_colorDAL = colorDAL;
		}

		public void Add(Color color)
		{
			_colorDAL.Add(color);
		}

		public void Delete(Color color)
		{
			_colorDAL.Delete(color);
		}

        public void Delete(int item)
        {
            _colorDAL.Delete(item);
        }

        public Color? Get(int id)
		{
			return _colorDAL.Get(id);
		}

		public List<Color> GetAll()
		{
			return _colorDAL.GetAll();
		}

		public void Update(Color color)
		{
			_colorDAL.Update(color);
		}
	}
}
