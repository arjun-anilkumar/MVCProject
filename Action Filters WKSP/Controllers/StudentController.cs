using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_Filters_WKSP.Controllers
{
   
    public class StudentController : Controller
    {
        [TestActionFilter]
        // GET: Student
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
        //important pls note ,this is a parameter GlobalFilterCollection
    }
}