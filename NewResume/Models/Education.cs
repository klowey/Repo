using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewResume.Models
{
    public class Education
    {

        [Required]
        public int EducationId { get; set; }

        [Required]
        [Display(Name = "School")]
        public string SchoolName { get; set; }

        [Display(Name = "Graduation Date")]
        public DateTime? GraduationDate { get; set; }

        [Display(Name = "Degree")]
        public string Degree { get; set; }

    }
}
