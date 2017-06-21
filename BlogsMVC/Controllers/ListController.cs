using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogsMVC.Models;


namespace BlogsMVC.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            myblogsEntities db = new myblogsEntities();
            //db.bloguser.
            List<blogarticle> article = db.blogarticle.ToList().Select(;
            ViewData["bloguserList"]= db.bloguser.ToList();
            return View(article);
        }
        public ActionResult Submit()
        {
            return View();
        }
        
    }
}