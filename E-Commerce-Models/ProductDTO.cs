using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Models
{
    public class ProductDTO
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please enter the name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the description")]
        public string Description { get; set; }
        public bool ShopFavorites { get; set; }
        public bool CustomerFavorites { get; set; }
        public string Autor { get; set; }
        public string ImageUrl { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please Select Category")]
        public int CategoryId { get; set; }        
        public CategoryDTO Category { get; set; }
    }
}
