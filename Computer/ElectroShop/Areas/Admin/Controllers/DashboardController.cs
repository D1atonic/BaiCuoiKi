using HALAShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HALAShop.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        private HALAShopDbContext db = new HALAShopDbContext();
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            ViewBag.CountSlider = db.Sliders.Where(m => m.Status == 1).Count();
            ViewBag.CountProduct = db.Products.Where(m => m.Status == 1).Count();
            ViewBag.CountContactDoneReply = db.Contacts.Where(m => m.Flag == 0).Count();
            ViewBag.CountUser = db.Users.Where(m => m.Status != 0 && m.Access==0).Count();
            return View();
        }
    }
}