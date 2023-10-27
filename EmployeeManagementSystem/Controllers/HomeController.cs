using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using EmployeeManagementSystem.ViewModel;

namespace EmployeeManagementSystem.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController: Controller 
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository= employeeRepository;
            //_employeeRepository = new MockEmployeeRepository();
        }
        // [Route("")]
        // [Route("Home/Index")]
        // [Route("Home/Index/id?")]
        public ViewResult Index()
        {
            var model= _employeeRepository.GetAllEmployees();
            return View(model);
            //return _employeeRepository.GetEmployee(1).Name;
        }
        [Route("/")]
        [Route("/Home")]
        //[Route("[action]")]
        //[Route("Home/Details/{id?}")]
        [Route("{id?}")]
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
            Employee = _employeeRepository.GetEmployee(id??1),
            PageTitle="Employee Details"
           // ViewBag.emp=model;
            };
            return View(homeDetailsViewModel);

        }
    }

    public class viewResult
    {
    }
}