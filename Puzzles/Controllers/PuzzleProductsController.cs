using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Puzzles.Models;

namespace Puzzles.Controllers
{
    public class PuzzleProductsController : Controller
    {
        private PuzzlesContext db = new PuzzlesContext();

        
        // GET: PuzzleProducts
        public ActionResult Start()
        {
            return View(db.PuzzleProducts.ToList());
        }

        // GET: PuzzleProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PuzzleProducts puzzleProducts = db.PuzzleProducts.Find(id);
            if (puzzleProducts == null)
            {
                return HttpNotFound();
            }
            return View(puzzleProducts);
        }

        // GET: PuzzleProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PuzzleProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductId,TypeOfPuzzle,Catagory,Price")] PuzzleProducts puzzleProducts)
        {
            if (ModelState.IsValid)
            {
                db.PuzzleProducts.Add(puzzleProducts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(puzzleProducts);
        }

        // GET: PuzzleProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PuzzleProducts puzzleProducts = db.PuzzleProducts.Find(id);
            if (puzzleProducts == null)
            {
                return HttpNotFound();
            }
            return View(puzzleProducts);
        }

        // POST: PuzzleProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductId,TypeOfPuzzle,Catagory,Price")] PuzzleProducts puzzleProducts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(puzzleProducts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(puzzleProducts);
        }

        // GET: PuzzleProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PuzzleProducts puzzleProducts = db.PuzzleProducts.Find(id);
            if (puzzleProducts == null)
            {
                return HttpNotFound();
            }
            return View(puzzleProducts);
        }

        // POST: PuzzleProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PuzzleProducts puzzleProducts = db.PuzzleProducts.Find(id);
            db.PuzzleProducts.Remove(puzzleProducts);
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
