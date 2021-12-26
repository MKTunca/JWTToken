using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminJwtToken.Model
{
    public class Panel
    {
		[Required]
		public int Id { get; set; }

		[Required]
		[StringLength(60)]
		[DisplayName("Ev sahibinin adı")]
		public string Name { get; set; }

		[Required]
		[StringLength(3)]
		[DisplayName("Daire Numarası")]
		public string DaireNo { get; set; }
	}
}
