using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Job is required")]
        public int JobId { get; set; }

        [Required(ErrorMessage = "Location is required")]
        public int LocationId { get; set; }
    }
}
