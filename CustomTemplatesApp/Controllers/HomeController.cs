/*
Шаблоны представлений, создаваемых с помощью пункта контекстного меню "Add view..." хранятся в директории:
D:\Microsoft\Visual Studio 14.0\Common7\IDE\Extensions\Microsoft\Web\Mvc\Scaffolding\Templates\MvcView
Менять шаблоны в этой директории не рекомендуется. Измененные шаблоны рекомендуется размещать в папке
проекта CodeTemplates.
*/
using CustomTemplatesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomTemplatesApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult MyTemplate()
        {
            return View();
        }

        public ActionResult Edit()
        {
            Book book = new Book { Name = "Война и мир", Id = 1, Price = 23.8m };
            return View(book);
        }

        public ActionResult Display()
        {
            Book book = new Book { Name = "Война и мир", Id = 1, Price = 23.8m };
            return View(book);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}