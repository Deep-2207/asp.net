using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{

    //[Route("Home")]
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            //_employeeRepository = employeeRepository;
            _employeeRepository = new MockEmployeeRepository();
        }

        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //[Route("Index")]
        //[Route("[action]")]
        //[Route("~/")]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);

        }



        //[Route("Home/Details/{id?}")]
        //[Route("Details/{id?}")]
        //[Route("[action]/{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(id??1),
                PageTitle = "Employee Details"
            };
           
            return View(homeDetailsViewModel);

        }
    }
}
