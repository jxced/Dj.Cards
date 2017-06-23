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
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var list= db.blogarticle.Join(db.bloguser, a =>a.AuthorId,u=>u.Id,(a,u)=> new article_exp() {Id=a.Id,Title=a.Title,CnName=u.CnName,Tag=a.Tag, CategoryId=a.CategoryId } ).ToList() ;
            var dlist = db.blogarticlecategory.Select(c => new {Id=c.Id,Name=c.Name }).ToList();
            ViewBag.list = new SelectList(dlist,"Id","Name");
            watch.Stop();
            var s = watch.Elapsed;
            return View(list);
        }
        public ActionResult Submit()
        {
            return View();
        }
        
    }
}