using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models
{
    public class User{
        // Basic things a model needs when going into MySQL
        // It needs a key
        [Key]
        public int UserId {get;set;}
        // Add in any attributes we need for our particular model
        [Required]
        [MinLength(2)]
        public string FirstName {get;set;}
        [Required]
        [MinLength(2)]
        public string LastName {get;set;}
        [Required]
        [EmailAddress]
        public string Email {get;set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

        // It also needs a createdAt and UpdatedAt
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        // NotMapped means it will NOT go into our database
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPass {get;set;}
    }
}