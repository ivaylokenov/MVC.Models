using System.Web.Mvc;

namespace MVC.SampleProject.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using DatabaseModels;
    using MVC.Models;
    using System;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var list = new List<SampleDatabaseModel>();

            var newList = list
                .AsQueryable()
                .Select(Models
                    .From<SampleDatabaseModel>()
                    .ExcludeTypes(BindingType.Properties)
                    .Category("Short")
                    .Cachable(false)
                    .To<object>());

            return View(newList);
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