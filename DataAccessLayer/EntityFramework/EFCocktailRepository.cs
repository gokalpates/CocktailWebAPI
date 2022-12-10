using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EFCocktailRepository : GenericRepository<Cocktail>, ICocktailDAL
	{
		public override Cocktail? Get(int id)
		{
			return _context.Cocktails.Include(c => c.Color)
				.Include(c => c.Glass)
				.Include(c => c.Ingredients)
				.Include(c => c.Preparation)
				.Include(c => c.Temperature)
				.Single(c => c.CocktailID == id);
		}

		public override List<Cocktail> GetAll() 
		{
			return _context.Cocktails.Include(c => c.Color)
				.Include(c => c.Glass)
				.Include(c => c.Ingredients)
				.Include(c => c.Preparation)
				.Include(c => c.Temperature)
				.ToList();
		}
	}
}
