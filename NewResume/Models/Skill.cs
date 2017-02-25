using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewResume.Models
{
    public class Skill

    {
        public int SkillId { get; set; }


        [Display(Name = "Skill")]
        public string SkillName { get; set; }

        public string Duration { get; set; }

        [Display(Name = "Proficiency")]
        public string Proficiency { get; set; }



    }
}
