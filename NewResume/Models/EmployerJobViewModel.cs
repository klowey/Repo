using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewResume.Models.EmployerJobViewModel
{
    public class EmployerJobViewModel


    {
        public int Id { get; set; }

        public Employer Employer { get; set; }
        
        public IEnumerable<Job> Jobs { get; set; }

        public IEnumerable<JobDuty> JobDuties { get; set; }
        }
}

