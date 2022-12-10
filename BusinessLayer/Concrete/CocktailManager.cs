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
	public class CocktailManager : IGenericService<Cocktail>
	{
		readonly ICocktailDAL _cocktailDAL;

		public CocktailManager(ICocktailDAL cocktailDAL)
		{
			_cocktailDAL = cocktailDAL;
		}

		public void Add(Cocktail cocktail)
		{
			_cocktailDAL.Add(cocktail);
		}

		public void Delete(Cocktail cocktail)
		{
			_cocktailDAL.Delete(cocktail);
		}

        public void Delete(int item)
        {
			_cocktailDAL.Delete(item);
        }

        public Cocktail? Get(int id)
		{
			return _cocktailDAL.Get(id);
		}

		public List<Cocktail> GetAll()
		{
			return _cocktailDAL.GetAll();
		}

		public void Update(Cocktail item)
		{
			_cocktailDAL.Update(item);
		}
	}
}
