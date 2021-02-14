﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;
using Microsoft.EntityFrameworkCore;
using TechJobsPersistent.Data;




// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();
            return View(employers);
        }

        public IActionResult Add()
        {
            Employer employer = new Employer();
            return View(employer);
        }

        [HttpPost]
        public IActionResult AddEmployer(Employer employer)
        {
            if (ModelState.IsValid)
            {
                context.Employers.Add(employer);
                context.SaveChanges();
                return Redirect("/Employer/");
            }
            return View("Add", employer);
        }

        public IActionResult About(int id)
        {
            List<Employer> jobEmployers = context.Employers
                .Where(Employer => Employer.Id == id)
               .Include(Employer => Employer.Name)
               .Include(Employer => Employer.Location)
               .ToList();

            return View(jobEmployers);
        }
    }
}
