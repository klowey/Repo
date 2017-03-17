using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewResume.Models
{
    public class JobDuty
    {
        public int JobDutyId { get; set; }

        [Display(Name ="Job Duties")]
        [DataType(DataType.MultilineText)]
        [StringLength(5000)]
        public string Duty { get; set; }

        public int? JobId { get; set; }

        public Job Job { get; set; }


    }
}
