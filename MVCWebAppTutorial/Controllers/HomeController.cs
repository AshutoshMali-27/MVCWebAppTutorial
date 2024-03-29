﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCWebAppTutorial.Models;

namespace MVCWebAppTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["message"] = "Message from View Data !!";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] Fruits = { "Apple", "banana", "Grapes", "Oranges" };
            ViewData["FruitsArray"] = Fruits;
            ViewData["Sportslist"] = new List<string>()
            {
                "Cricket",
                "Hockey",
                "Football",
                "volley Ball"
            };

            clsViewData Ashutosh = new clsViewData();
            Ashutosh.EmpID = 11;
            Ashutosh.EmpName = "Ashutosh Mali";
            Ashutosh.EmpDesignation = "Developer";

            ViewData["clsViewData"] = Ashutosh;

            ViewBag.Message1 = "Message From View Bag !!" ;
            ViewBag.CurrentDate1 = DateTime.Now.ToLongDateString();
            string[] fruits1 = { "apple", "Banana", "Grapes", "Oranges" };
            ViewBag.FruitArray1 = fruits1;
            ViewBag.SportsList1 = new List<string>()
            {
                 "Cricket",
                "Hockey",
                "Football",
                "volley Ball"
            };

            ClsViewBag Ashutosh1 = new ClsViewBag();
            Ashutosh1.EmpID1 = 11;
            Ashutosh1.EmpName1 = "Ashutosh Mali";
            Ashutosh1.EmpDesignation1 = "Developer";

            ViewBag.ClsViewBag = Ashutosh1;

            ViewData["Var1"] = "Message From View Data 1";
            ViewBag.var2 = "message from view bag 2";
            TempData["var3"] = "Message From temp Data";

            ClsViewBag emp1 = new ClsViewBag();
            emp1.EmpID1 = 11;
            emp1.EmpDesignation1 = "Manager";
            emp1.EmpName1 = "Ashutosh Mali";


            return View(emp1);
        
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}