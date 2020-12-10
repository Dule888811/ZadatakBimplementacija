﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZadatakBimplementacija.Models;
using ZadatakBimplementacija.Repository;
using ZadatakBimplementacija.Repository.IRepository;

namespace ZadatakBimplementacija.Controllers
{
    public class ProizvodsController : Controller
    {
        private readonly IProizvodsRepository _proizvodsRepository;

        public ProizvodsController(ProizvodsRepository proizvodsRepository)
        {
            this._proizvodsRepository = proizvodsRepository;
        }

        // GET: Proizvods
        public ActionResult Index()
        {
            if (this._proizvodsRepository.Get() == null)
            {
                return View();
            }
            else {
                return View(this._proizvodsRepository.Get().ToList());
            };

            
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "naziv,opis,kategorija,proizvođač,dobavljač,cena")] Proizvod Proizvod)
        {
          
            if (ModelState.IsValid)
            {
                this._proizvodsRepository.AddProizvod(Proizvod);

                return RedirectToAction("Index", "Proizvods");
            }
            else

                return View(Proizvod);
        }

        // GET: Proizvods/Details/5
        /*      public ActionResult Details(int? id)
              {
                  if (id == null)
                  {
                      return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                  }
                  Proizvod proizvod = db.Proizvods.Find(id);
                  if (proizvod == null)
                  {
                      return HttpNotFound();
                  }
                  return View(proizvod);
              }

              // GET: Proizvods/Create
              public ActionResult Create()
              {
                  return View();
              }

              // POST: Proizvods/Create
              // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
              // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
              [HttpPost]
              [ValidateAntiForgeryToken]
              public ActionResult Create([Bind(Include = "id,naziv,opis,kategorija,proizvođač,dobavljač,cena")] Proizvod proizvod)
              {
                  if (ModelState.IsValid)
                  {
                      db.Proizvods.Add(proizvod);
                      db.SaveChanges();
                      return RedirectToAction("Index");
                  }

                  return View(proizvod);
              }

              // GET: Proizvods/Edit/5
              public ActionResult Edit(int? id)
              {
                  if (id == null)
                  {
                      return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                  }
                  Proizvod proizvod = db.Proizvods.Find(id);
                  if (proizvod == null)
                  {
                      return HttpNotFound();
                  }
                  return View(proizvod);
              }

              // POST: Proizvods/Edit/5
              // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
              // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
              [HttpPost]
              [ValidateAntiForgeryToken]
              public ActionResult Edit([Bind(Include = "id,naziv,opis,kategorija,proizvođač,dobavljač,cena")] Proizvod proizvod)
              {
                  if (ModelState.IsValid)
                  {
                      db.Entry(proizvod).State = EntityState.Modified;
                      db.SaveChanges();
                      return RedirectToAction("Index");
                  }
                  return View(proizvod);
              }

              // GET: Proizvods/Delete/5
              public ActionResult Delete(int? id)
              {
                  if (id == null)
                  {
                      return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                  }
                  Proizvod proizvod = db.Proizvods.Find(id);
                  if (proizvod == null)
                  {
                      return HttpNotFound();
                  }
                  return View(proizvod);
              }

              // POST: Proizvods/Delete/5
              [HttpPost, ActionName("Delete")]
              [ValidateAntiForgeryToken]
              public ActionResult DeleteConfirmed(int id)
              {
                  Proizvod proizvod = db.Proizvods.Find(id);
                  db.Proizvods.Remove(proizvod);
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
              } */
    }
}
