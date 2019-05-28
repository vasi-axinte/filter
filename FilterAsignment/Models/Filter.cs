using System;
using System.Collections.Generic;
using System.Text;

namespace FilterAssignment.Models
{
    public class Filter
    {
        public string NameContains { get; set; }

        public int Age { get; set; }

        public float MaximumHourlyRate { get; set; }

        public IList<int> RequiredSkillList { get; set; }
    }
}
