using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestApp.CustomAttributes;

namespace TestApp.Models
{
    public class CreateViewModel
    {
        [Required]
        [Display (Name = "First Name")]
        public string FirstName { get; set; }

        [LastNameNotDavis(ErrorMessage ="Last name can't be Davis.")]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DateBeforeMay2017Only(ErrorMessage = "Date must be before may 2017")]
        [Display(Name = "To")]
        public DateTime ToDate { get; set; }

        [DateBeforeMay2017Only(ErrorMessage = "Date must be before may 2017")]
        [Display(Name = "From")]
        public DateTime FromDate { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Favorite Drink")]
        public string FavoriteDrink { get; set; }
        [Display(Name = "Favorite Number")]
        public decimal FavoriteNumber { get; set; }
    }
}