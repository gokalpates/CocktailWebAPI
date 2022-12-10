using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=HOMEDESKTOP;database=CocktailWebAPIDB;integrated security=true;Encrypt=false");
		}

		public DbSet<Cocktail> Cocktails { get; set; }
		public DbSet<Color> Colors { get; set; }
		public DbSet<Glass> Glasses { get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Preparation> Preparations { get; set; }
		public DbSet<Temperature> Temperatures { get; set; }
	}
}
