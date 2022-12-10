using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Preparation
	{
		[Key]
		public int PreparationID { get; set; }
		public String? PreparationDescription { get; set; }
	}
}
