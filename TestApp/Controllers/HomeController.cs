using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = (IndexViewModel)Session["SavedRecords"];
            //var model = new IndexViewModel();
            //model.formRecords.Add(new FormRecord
            //{
            //    Id = 1,
            //    FirstName = "Brian",
            //    LastName = "Chiang",
            //    UserName = "blah",
            //    Password = "blah",
            //    FromDate = DateTime.Now,
            //    ToDate = DateTime.Now,
            //    Email = "blah@blah.com",
            //    Birthday = DateTime.Now,
            //    FavoriteDrink = "Fanta",
            //    FavoriteNumber = 1
            //});
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                int id = 1;
                var currentTable = (IndexViewModel)Session["SavedRecords"];
                if (currentTable != null)
                {
                    id = currentTable.formRecords.Count + 1;
                }
                else
                {
                    currentTable = new IndexViewModel();
                }

                currentTable.formRecords.Add(new FormRecord
                {
                    Id = id,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                    Password = model.Password,
                    FromDate = model.FromDate,
                    ToDate = model.ToDate,
                    Email = model.Email,
                    Birthday = model.Birthday,
                    FavoriteDrink = model.FavoriteDrink,
                    FavoriteNumber = model.FavoriteNumber
                });
                Session["SavedRecords"] = currentTable;
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(CreateViewModel model)
        {
            return View();
        }

        public ActionResult View(int id)
        {
            return View();
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