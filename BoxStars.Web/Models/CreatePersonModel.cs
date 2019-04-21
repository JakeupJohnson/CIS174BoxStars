using System;
using System.ComponentModel.DataAnnotations;

namespace BoxStars.Web.Models
{
    public class CreatePersonModel
    {
        public Guid PersonId { get; set; }
        [Display(Name = "First Name: ")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "Last Name: ")]
        [Required]
        public string LastName { get; set; }
        [Display(Name = "Gender: ")]
        public string Gender { get; set; }
        public DateTime? DateCreated { get; set; }
        [Display(Name = "Email: ")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Phone Number: ")]
        public string PhoneNumber { get; set; }
    }
}