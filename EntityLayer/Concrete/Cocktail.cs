using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Cocktail
	{
		[Key]
		public int CocktailID { get; set; }
		public string? CocktailName { get; set; }
		public string? CocktailStory { get; set; }
		public Color? Color { get; set; }
		public Glass? Glass { get; set; }
		public List<Ingredient>? Ingredients { get; set; }
		public Preparation? Preparation { get; set; }
		public Temperature? Temperature { get; set; }
	}
}
