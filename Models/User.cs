using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginReg.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Password is Required")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        public DateTime CreateAt { get; set; } = DateTime.Now;//establish current time
        public DateTime UpdatedAt { get; set; } = DateTime.Now;//use current time again
        // Not mapped keeps ConfirmPW out of our SQL tables.
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [Compare("Password")]
        [Display(Name = "Confirm Password: ")]
        [DataType(DataType.Password)]
        public string ConfirmPW { get; set; }
    }
}