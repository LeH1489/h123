using System;
using System.ComponentModel.DataAnnotations;

namespace BigSchool_2.Models
{
	public class Category
	{
		public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}

