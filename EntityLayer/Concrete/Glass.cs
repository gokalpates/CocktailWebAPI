using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Glass
	{
		[Key]
		public int GlassID { get; set; }
		public string? GlassName { get; set; }
	}
}
