using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace chefsndishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        [Range(18,10000, ErrorMessage = "You must be at least 18 years old")]
        public int Age {get;set;}

        public int NumDishes {get;set;}

        public List<Dish> Dishes {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}