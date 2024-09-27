using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class LocationModel
	{
		[Required]
		public int id { get; set; }
		[Required]
		[MaxLength(100)]
		public string location { get; set; }
		[Required]
		[MaxLength(1000)]
		public string stores { get; set; }
	}
}
