using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CGP.Models;

namespace CGP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [ChildActionOnly]
        public ActionResult Menu()
        {
            if (Request.IsAuthenticated)
            {
                var _menu = new Menu();

                // Normally you'd do some data or cache access to build/retrieve the user's menu
                // then you're loop through the results and build the menu object
                // we're hard coding for the sake of simplicity

                var _google = new MenuItem()
                {
                    MenuItemName = "Google",
                    MenuItemPath = "http://google.com/",
                };

                _google.ChildMenuItems.Add(new MenuItem()
                {
                    MenuItemName = "Google Images",
                    MenuItemPath = "http://google.com"
                });

                var _bing = new MenuItem()
                {
                    MenuItemName = "Bing",
                    MenuItemPath = "http://bing.com/"
                };

                _bing.ChildMenuItems.Add(new MenuItem()
                {
                    MenuItemName = "Bing Images",
                    MenuItemPath = "http://bing.com/"
                });

                _menu.Items.Add(_google);
                _menu.Items.Add(_bing);

                return PartialView("_Menu", _menu);
            }
            else
            {
                return PartialView("_Menu", null);
            }
        }
    }
}