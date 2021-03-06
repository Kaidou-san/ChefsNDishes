using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set;}
        [Required]
        public string DishName {get; set;}
        [Required]
        [Range(1,10000)]
        public int Calories {get; set;}
        [Required]
        public string Description {get; set;}
        [Required]
        [Range(1,5)]
        public int Tastiness {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public int ChefId {get; set;}
        public Chef PreparedBy {get; set;}

        

    }
}