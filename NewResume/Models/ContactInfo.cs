using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace NewResume.Models
{
    public class ContactInfo
    {
        public int ContactInfoId { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Street Address")]
        public string Street { get; set; }

        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "State")]
        public string State { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        public string Zipcode { get; set; }

    }
}
