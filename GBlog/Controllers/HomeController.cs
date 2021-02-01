using GBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GBlog.Controllers
{
    public class HomeController : Controller
    {
        private GBlogContext db = new GBlogContext();

        // GET: Blogs
        public ActionResult Index()
        {
            return View(db.Blogs.OrderBy(b => b.CreatedOn).FirstOrDefault());
        }

    }
}