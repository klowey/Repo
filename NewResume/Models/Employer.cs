using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewResume.Models
{
    public class Employer
    {

        public int EmployerId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string EmployerName { get; set; }

        
        [RegularExpression(@"^[\d|A-Z]+[a-zA-Z''-'\s]*$")]
        [Display(Name = "Street Address")]
        public string EmployerStreet { get; set; }

        [Display(Name = "City")]
        public string EmployerCity { get; set; }

        [Display(Name = "State")]
        public string EmployerState { get; set; }

        [Display(Name ="Zip Code")]           
        public string EmployerZip { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Entered phone format is not valid.")]
        public string EmployerPhone { get; set; }

        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmployerEmail { get; set; }

       
        [Display(Name = "Website")]
        [Url(ErrorMessage = "Invalid Url")]
        public string EmployerWebsite { get; set; }

      
       

    }
}
