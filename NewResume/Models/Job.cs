using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewResume.Models
{
    public class Job

    {
        public int JobId { get; set; }

        [Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JobDateFrom { get; set; }

        [Display(Name = "End Date")]
        [DisplayFormat(NullDisplayText = "Present", DataFormatString ="{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? JobDateTo { get; set; }

        public int? EmployerId { get; set; }

        public Employer Employer { get; set; }

    }
}
