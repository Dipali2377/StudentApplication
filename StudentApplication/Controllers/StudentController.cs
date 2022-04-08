using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentApplication.Models;

namespace StudentApplication.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/
        public ActionResult Index()
        {
            return View();
        }
	}
}