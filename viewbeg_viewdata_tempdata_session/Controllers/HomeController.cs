using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace viewbeg_viewdata_tempdata_session.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = " viewbeg example--------";

            ViewBag.name = "ashkeen";
            ViewBag.id = 1;
            ViewBag.num = 12.3;
            ViewBag.date = DateTime.Now;




            return View();
        }

        public ActionResult About()
        {

            ViewBag.Message = " viewdata example--------";

            ViewData["s_name"] = "suhail";
            ViewData["s_id"] = 2;
            ViewData["marks"] = 23.2;
            ViewData["subject"] = new List<string>()
            {
               "math",
               "science",
               "english"
            };
            ViewData["date"] = DateTime.Now;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "TempData example------";
            TempData["name"] = "fazal";
            TempData["age"] = 20;
            TempData["address"] = "sambhal";
            TempData["email"] = "fazal@gmail.com";
            TempData["date"] = DateTime.Now;
            return View();
        }
        public ActionResult Fourth()
        {
            ViewBag.Message = "session example------";
            Session["name"] = "nitin";
            Session["age"] = 20;
            Session["marks"] = 70;
            Session["email"] = "nitin@gmail.com";
            Session["date"] = DateTime.Now;

            return View();
        }
    }
}









