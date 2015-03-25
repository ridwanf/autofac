using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAutofac.Models;
using TestAutofac.Repository;

namespace TestAutofac.Controllers
{
    public class StudentController : Controller
    {

        private IStudentRepository _repository;

        public StudentController(StudentRepository repository)
        {
            _repository = repository;
        }
        // GET: Student
        public ActionResult Index()
        {
            var model = _repository.GetStudents();
            return View(model);
        }

       
    }
}