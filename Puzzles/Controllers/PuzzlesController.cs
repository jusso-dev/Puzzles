using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Puzzles.Models;

namespace Puzzles.Controllers
{
    public class PuzzlesController : ApiController
    {
        private PuzzlesContext db = new PuzzlesContext();

        // GET: api/WebApiPuzzle
        public IQueryable<PuzzleProducts> GetPuzzleProducts()
        {
            return db.PuzzleProducts;
        }

        // GET: api/WebApiPuzzle/5
        [ResponseType(typeof(PuzzleProducts))]
        public IHttpActionResult GetPuzzleProducts(int id)
        {
            PuzzleProducts puzzleProducts = db.PuzzleProducts.Find(id);
            if (puzzleProducts == null)
            {
                return NotFound();
            }

            return Ok(puzzleProducts);
        }

        // PUT: api/WebApiPuzzle/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPuzzleProducts(int id, PuzzleProducts puzzleProducts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != puzzleProducts.ProductId)
            {
                return BadRequest();
            }

            db.Entry(puzzleProducts).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PuzzleProductsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/WebApiPuzzle
        [ResponseType(typeof(PuzzleProducts))]
        public IHttpActionResult PostPuzzleProducts(PuzzleProducts puzzleProducts)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PuzzleProducts.Add(puzzleProducts);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = puzzleProducts.ProductId }, puzzleProducts);
        }

        // DELETE: api/WebApiPuzzle/5
        [ResponseType(typeof(PuzzleProducts))]
        public IHttpActionResult DeletePuzzleProducts(int id)
        {
            PuzzleProducts puzzleProducts = db.PuzzleProducts.Find(id);
            if (puzzleProducts == null)
            {
                return NotFound();
            }

            db.PuzzleProducts.Remove(puzzleProducts);
            db.SaveChanges();

            return Ok(puzzleProducts);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PuzzleProductsExists(int id)
        {
            return db.PuzzleProducts.Count(e => e.ProductId == id) > 0;
        }
    }
}