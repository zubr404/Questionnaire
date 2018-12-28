using Questionnaire.Models;
using Questionnaire.Models.TovarikaDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Questionnaire.Controllers
{
    public class HomeController : Controller
    {
        QuestionnaireContext db = new QuestionnaireContext();

        public ActionResult Index()
        {
            SelectList regions = new SelectList(db.Regions, "Id", "Name");
            ViewBag.Regions = regions;

            SelectList cities = new SelectList(db.Cities, "Id", "Name");
            ViewBag.Cities = cities;

            MultiSelectList business_areas = new MultiSelectList(db.BusinessAreas, "Id", "Name");
            ViewBag.BusinessAreas = business_areas;

            return View();
        }

        public ActionResult GetCities(int id)
        {
            return PartialView(db.Cities.Where(c => c.RegionId == id).ToList());
        }
    }
}