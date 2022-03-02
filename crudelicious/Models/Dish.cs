using System;
using System.ComponentModel.DataAnnotations;

namespace crudelicious.Models
{
    public class Dish
    {
        // This is the primary key for MySql
        [Key]
        public int DishID {get;set;}
        
        //Attributes
        [Required]
        public string Name {get;set;}
        [Required]
        public string Chef {get;set;}
        [Required]
        //use range for integer range(1,5)
        public string Tastiness {get;set;}
        [Required]
        public string Calories {get;set;}
        [Required]
        public string Description {get;set;}
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}