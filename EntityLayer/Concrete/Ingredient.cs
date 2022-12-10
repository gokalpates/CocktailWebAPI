using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Ingredient
	{
		[Key]
		public int IngredientsID { get; set; }
		public string? IngredientsName { get; set; }
		public float? IngredientsAmount { get; set; }
		public float? IngredientsAlcoholPercent { get; set; }
	}
}
