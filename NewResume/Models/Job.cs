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

        public string JobTitle { get; set; }


        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime JobDateFrom { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "Present")]
        public DateTime JobDateTo { get; set; }
    }
}
