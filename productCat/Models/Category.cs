using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace productCat.Models
{
    public class Category
    {
        [Key]
        public int CategoryId {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        public List<Association> AssociatedBy {get;set;}
    }
}