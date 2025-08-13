using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project
                {
                    ImgPath = Url.Content("~/Content/Images/minZepto.png"),
                    IsBlog = false,
                    Title = "10MinZepto",
                    Description = "E-Commerce Website built with .NET MVC...",
                    GhLink = "https://github.com/imayushsri/10MinZepto/tree/main/MyProject"
                },
                new Project
                {
                    ImgPath = Url.Content("~/Content/Images/RideMate.png"),
                    IsBlog = false,
                    Title = "RideMate",
                    Description = "A Cab Booking website built with MERN and Tailwind css...",
                    GhLink = "https://github.com/imayushsri/RideMate"
                },
                new Project
                {
                    ImgPath = Url.Content("~/Content/Images/RecruiteX.png"),
                    IsBlog = false,
                    Title = "RecruiteX",
                    Description = "A Job Portal website built with MERN stack...",
                    GhLink = "https://github.com/imayushsri/MERN_Project"
                },
                new Project
                {
                    ImgPath = Url.Content("~/Content/Images/iNoteBook.png"),
                    IsBlog = false,
                    Title = "iNoteBook",
                    Description = "A web app to manage your personal notes built with MERN stack...",
                    GhLink = "https://github.com/imayushsri/iNoteBook"
                },
                new Project
                {
                    ImgPath = Url.Content("~/Content/Images/TextUtils.png"),
                    IsBlog = false,
                    Title = "TextUtils",
                    Description = "A website to manipulate the text built with React...",
                    GhLink = "https://github.com/imayushsri/TextUtils"
                },

            };

            return View(projects);
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }
    }
}