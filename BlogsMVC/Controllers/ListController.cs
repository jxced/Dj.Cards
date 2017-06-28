using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogsMVC.Models;
using System.Diagnostics;

namespace BlogsMVC.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            myblogsEntities db = new myblogsEntities();
            //db.bloguser.
            var list= db.blogarticle.Join(db.bloguser, a =>a.AuthorId,u=>u.Id,(a,u)=> new article_exp() {Id=a.Id,Title=a.Title,CnName=u.CnName,Tag=a.Tag, CategoryId=a.CategoryId } ).ToList() ;
            var dlist = db.blogarticlecategory.Select(c=>new { CategoryId = c.Id,Name=c.Name});
            ViewBag.vlist = dlist;/* new SelectList(dlist,"Id","Name",2);*/
            return View(list);
        }
        public ActionResult Submit()
        {
            return View();
        }
        
    }
}