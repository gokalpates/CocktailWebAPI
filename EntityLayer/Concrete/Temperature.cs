using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Temperature
	{
		[Key]
		public int TemperatureID { get; set; }
		public String? TemperatureName { get; set; }
	}
}
