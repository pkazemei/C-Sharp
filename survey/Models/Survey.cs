using System;
using System.ComponentModel.DataAnnotations;

namespace survey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name must be a minimum of 2 characters")]
        public string Sname {get;set;}
        
        [Required]
        public string Slocation {get;set;}
        
        [Required]
        public string Slanguage {get;set;}
        
        [Required]
        public string Scomments {get;set;}
    }
}