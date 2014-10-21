using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class StockController : Controller
    {


        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Create()
        {


            throw new NotImplementedException();
        }
	}
}