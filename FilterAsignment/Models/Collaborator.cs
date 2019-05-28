using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FilterAssignment.Models
{
    public class Collaborator
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Skill> Skills { get; set; }
        public float HourlyRate { get; set; }

        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + Environment.NewLine +
                   "Birthdate: " + BirthDate.ToShortDateString() + Environment.NewLine +
                   "Skills: " + string.Join(',', Skills.Select(s => s.Name)) + Environment.NewLine +  
                   "HourlyRate: " + HourlyRate;
        }
    }
}
