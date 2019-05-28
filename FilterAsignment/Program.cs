using System;
using System.Collections.Generic;
using FilterAssignment.Models;
using FilterAssignment.Services;

namespace FilterAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var collaborators = GetCollaboratorList();
            var filter = GetFilter();

            var fs = new FilterService();

            // apply filter on collaborators
            // List<Collaborator> filteredCollaborators = fs.Filter();

            DisplayCollaboratorList(collaborators);
        }

        private static Filter GetFilter()
        {
            throw new NotImplementedException();
        }

        private static IList<Collaborator> GetCollaboratorList()
        {
            var skill1 = new Skill{Id = 1, Name = "C#"};
            var skill2 = new Skill{Id = 2, Name = "DevOps"};
            var skill3 = new Skill{Id = 3, Name = "Angular"};
            var skill4 = new Skill{Id = 4, Name = "React"};

            var collaborator1 = new Collaborator
            {
                FirstName = "A",
                LastName = "B",
                BirthDate = DateTime.Now,
                HourlyRate = 50.0f,
                Skills = new List<Skill> { skill1, skill2 }
            };
            var collaborators = new List<Collaborator>{collaborator1};

            return collaborators;
        }

        private static void DisplayCollaboratorList(IList<Collaborator> collaborators)
        {
            foreach (var collaborator in collaborators)
            {
                Console.WriteLine("===================================");
                Console.WriteLine(collaborator);
                Console.WriteLine("===================================");
            }
        }
    }
}
