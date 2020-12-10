using System;
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

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Proizvod Proizvod = this._proizvodsRepository.GetById((int)id);
            
            if (Proizvod == null)
            {
                return HttpNotFound();
            }
            return View(Proizvod);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,naziv,opis,kategorija,proizvođač,dobavljač,cena")] Proizvod Proizvod)
        {
           

            if (ModelState.IsValid)
            {
                this._proizvodsRepository.EditDocument(Proizvod);
                return RedirectToAction("Index");
            }
            return View(Proizvod);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this._proizvodsRepository.Dispose();
            }
            base.Dispose(disposing);
        }

     
    }
}
