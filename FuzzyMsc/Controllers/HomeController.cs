﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FuzzyMsc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public JsonResult Kaydet() {
            return Json(new { Sonuc = "asdasd" }, JsonRequestBehavior.AllowGet);
        }
    }
}