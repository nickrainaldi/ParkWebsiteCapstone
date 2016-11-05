using Capstone.Web.DAL;
using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Web.Controllers
{

    public class SurveyController : Controller
    {

        private ISurveyDAL surveyDAL;

        public SurveyController(ISurveyDAL surveyDAL)
        {
            this.surveyDAL = surveyDAL;
        }

        public ActionResult SurveyForm()
        {
            ViewBag.ActivityOptions = ActivityOptions;
            ViewBag.ParkOptions = ParkOptions;
            return View("SurveyForm", new Survey());
        }

        [HttpPost]
        public ActionResult SurveyForm(Survey survey)
        {
            if (ModelState.IsValid)
            {

                surveyDAL.SaveNewSurvey(survey);
                return RedirectToAction("SurveyResult");
            }
            else 
            {
                ViewBag.ActivityOptions = ActivityOptions;
                ViewBag.ParkOptions = ParkOptions;
                return View("SurveyForm", survey);
            }          
        }


        public ActionResult SurveyResult()
        {
            List<SurveyResult> result = surveyDAL.SurveyResults();
            return View("SurveyResult", result);
        }
        //private IParkDAL parkDAL;
        //private List<Park> parks = parkDAL.GetAllParks();



        private List<SelectListItem> ParkOptions = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Glacier National Park", Value="GNP" },
            new SelectListItem() { Text = "Everglades National Par", Value = "ENP" },
            new SelectListItem() { Text = "Grand Canyon National Park", Value = "GCNP" },
            new SelectListItem() { Text = "Cuyahoga Valley National Park", Value = "CVNP" },
            new SelectListItem() { Text = "Grand Teton National Park", Value = "GTNP" },
            new SelectListItem() { Text = "Mount Ranier National Park", Value = "MRNP" },
            new SelectListItem() { Text = "Rocky Mountain National Park", Value = "RMNP" },
            new SelectListItem() { Text = "Yellowstone National Park", Value = "YNP" },
            new SelectListItem() { Text = "Yosemite National Park", Value = "YNP2" },

        };


        private List<SelectListItem> ActivityOptions = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Inactive", Value="Inactive" },
            new SelectListItem() { Text = "Sedentary", Value = "Sedentary" },
            new SelectListItem() { Text = "Active", Value = "Active" },
            new SelectListItem() { Text = "Extremely Active", Value = "Extremely Active" },
           
        };

    }
}