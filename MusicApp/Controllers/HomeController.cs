﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
            // dhkasjfhaskjdashkjfhasjkdhask
            //assdasdas
            //fdsfsd

            //asdasdadasaaaaaaaa

            //324234343243

            //test56

            //test_merge_bojan

            //test_merge_bojan 1  
            //test_merge_bojan 2
            //test_merge_bojan 3

            //test_commit_Goran


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