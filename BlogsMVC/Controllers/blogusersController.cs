﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlogsMVC.Models;

namespace BlogsMVC.Controllers
{
    public class blogusersController : Controller
    {
        private myblogsEntities db = new myblogsEntities();

        // GET: blogusers
        public ActionResult Index()
        {
            return View(db.bloguser.ToList());
        }
        public ActionResult login()
        {
            db.bloguser.FirstOrDefault();
            return View();
        }

        // GET: blogusers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bloguser bloguser = db.bloguser.Find(id);
            if (bloguser == null)
            {
                return HttpNotFound();
            }
            return View(bloguser);
        }

        // GET: blogusers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: blogusers/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,LoginName,LoginPwd,CnName,Email,IsLock,IsDel,AddTime,LastLoginTime,LastLoginIp")] bloguser bloguser)
        {
            if (ModelState.IsValid)
            {
                db.bloguser.Add(bloguser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bloguser);
        }

        // GET: blogusers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bloguser bloguser = db.bloguser.Find(id);
            if (bloguser == null)
            {
                return HttpNotFound();
            }
            return View(bloguser);
        }

        // POST: blogusers/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 https://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,LoginName,LoginPwd,CnName,Email,IsLock,IsDel,AddTime,LastLoginTime,LastLoginIp")] bloguser bloguser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bloguser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bloguser);
        }

        // GET: blogusers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bloguser bloguser = db.bloguser.Find(id);
            if (bloguser == null)
            {
                return HttpNotFound();
            }
            return View(bloguser);
        }

        // POST: blogusers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            bloguser bloguser = db.bloguser.Find(id);
            db.bloguser.Remove(bloguser);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
