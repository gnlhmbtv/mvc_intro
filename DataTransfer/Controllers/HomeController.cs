using DataTransfer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var view = new ViewResult();
            //view.ViewName = "Index";
            //ViewBag.Name = "Lorem";
            //List<Student> stu = new List<Student>
            //{
            //    new Student{Id=1,Name="Gunel",Age=19},
            //    new Student{Id=2,Name="Kamran", Age=3},
            //    new Student{Id=3,Name="Sabina",Age=27}
            //};
            //ViewBag.Students = stu;
            //ViewData["students"] = stu;

            ViewBag.Name = "gnl";
            ViewData["LastName"] = "hmbtv";
            TempData["Age"] = 19;
            return RedirectToAction(nameof(About));
        }
        public IActionResult About()
        {
            //ViewBag.Name = "gnl";
            //ViewData["LastName"] = "hmbtv";
            //TempData["Age"] = 19;
            return View();
        }
        public IActionResult GetFile()
        {
            return File("~/img/image.png", "image/png");
        }
        public IActionResult Test()
        {
            return View();
        }

    }
}
