using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University_Registration.Models;

namespace University_Registration.Controllers
{
    public class mainHomeController : Controller
    {
        ERP_SystemEntities1 db = new ERP_SystemEntities1();

        // GET: mainHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult coarses(int? id)
        {

            if (id == null)
            {
                var course = from m in db.Majors select m;
                return View(course);
            }
            else
            {
                var course = from m in db.Majors where m.Facility_ID == id select m;
                return View(course);
            }
            return View();
        }
        public ActionResult test()
        {
            return View();
        }
    }
}