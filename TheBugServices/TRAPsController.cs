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
using TheBugServices.Models;

namespace TheBugServices
{
    public class TRAPsController : ApiController
    {
        private theBestiolaEntities db = new theBestiolaEntities();

        // GET: api/TRAPs
        public IQueryable<TRAP> GetTRAPs()
        {
            return db.TRAPs;
        }

        // GET: api/TRAPs/5
        [ResponseType(typeof(TRAP))]
        public IHttpActionResult GetTRAP(int id)
        {
            TRAP tRAP = db.TRAPs.Find(id);
            if (tRAP == null)
            {
                return NotFound();
            }

            return Ok(tRAP);
        }

        // PUT: api/TRAPs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTRAP(int id, TRAP tRAP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tRAP.TRAP_ID)
            {
                return BadRequest();
            }

            db.Entry(tRAP).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TRAPExists(id))
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

        // POST: api/TRAPs
        [ResponseType(typeof(TRAP))]
        public IHttpActionResult PostTRAP(TRAP tRAP)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TRAPs.Add(tRAP);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tRAP.TRAP_ID }, tRAP);
        }

        // DELETE: api/TRAPs/5
        [ResponseType(typeof(TRAP))]
        public IHttpActionResult DeleteTRAP(int id)
        {
            TRAP tRAP = db.TRAPs.Find(id);
            if (tRAP == null)
            {
                return NotFound();
            }

            db.TRAPs.Remove(tRAP);
            db.SaveChanges();

            return Ok(tRAP);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TRAPExists(int id)
        {
            return db.TRAPs.Count(e => e.TRAP_ID == id) > 0;
        }
    }
}