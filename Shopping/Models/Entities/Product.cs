using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shopping.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter product name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please enter product's quantities")]
        public string Quantity { get; set; }

        [Required(ErrorMessage ="Please enter product's price")]
        public string Price { get; set; }

        [Required(ErrorMessage ="Please give product's description")]
        public string Description { get; set; }
    }
}