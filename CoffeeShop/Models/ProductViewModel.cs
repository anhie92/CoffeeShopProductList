using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace CoffeeShop.Models
{
	public class ProductViewModel
	{
        [DisplayName("Product ID")]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Product Name")]
        public string? Name { get; set; }

         
        [DisplayName("Product Description")]
        public string? Description { get; set; }

        [Range(0, 20)]
        [DisplayName("Product Price")]
        public double Price { get; set; }

        
        [DisplayName("Product Category")]
        public string Category { get; set; }



        
	}
}

