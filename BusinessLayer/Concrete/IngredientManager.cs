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
	public class IngredientManager : IGenericService<Ingredient>
	{
		readonly IIngredientDAL _ingredientDAL;

		public IngredientManager(IIngredientDAL ingredientDAL)
		{
			_ingredientDAL = ingredientDAL;
		}

		public void Add(Ingredient ingredient)
		{
			_ingredientDAL.Add(ingredient);
		}

		public void Delete(Ingredient ingredient)
		{
			_ingredientDAL.Delete(ingredient);
		}

        public void Delete(int item)
        {
			_ingredientDAL.Delete(item);
        }

        public Ingredient? Get(int id)
		{
			return _ingredientDAL.Get(id);
		}

		public List<Ingredient> GetAll()
		{
			return _ingredientDAL.GetAll();
		}

		public void Update(Ingredient ingredient)
		{
			_ingredientDAL.Update(ingredient);
		}
	}
}
