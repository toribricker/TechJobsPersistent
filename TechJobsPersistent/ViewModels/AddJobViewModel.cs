using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.Models
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Job is required")]
        public int JobId { get; set;}

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public string Name { get; set; }

        public Job Job { get; set;}

        public List<SelectListItem> Employers { get; set; }

        public List<Skill> Skills { get; set; }

        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            
            foreach(Employer newEmployer in employers){
                Employers.Add(new SelectListItem { Text = newEmployer.Name, Value = newEmployer.Id.ToString() });

            }
            Skills = skills;
        }
        public AddJobViewModel()
        {

        }
    }
}
