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
    public class PeopleController : ApiController
    {
        private theBestiolaEntities db = new theBestiolaEntities();

        // GET: api/People
        public IQueryable<PERSON> GetPeople()
        {
            return db.People;
        }

        // GET: api/People/5
        [ResponseType(typeof(PERSON))]
        public IHttpActionResult GetPERSON(int id)
        {
            PERSON pERSON = db.People.Find(id);
            if (pERSON == null)
            {
                return NotFound();
            }

            return Ok(pERSON);
        }

        // PUT: api/People/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPERSON(int id, PERSON pERSON)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pERSON.PERSON_ID)
            {
                return BadRequest();
            }

            db.Entry(pERSON).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PERSONExists(id))
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

        // POST: api/People
        [ResponseType(typeof(PERSON))]
        public IHttpActionResult PostPERSON(PERSON pERSON)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.People.Add(pERSON);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pERSON.PERSON_ID }, pERSON);
        }

        // DELETE: api/People/5
        [ResponseType(typeof(PERSON))]
        public IHttpActionResult DeletePERSON(int id)
        {
            PERSON pERSON = db.People.Find(id);
            if (pERSON == null)
            {
                return NotFound();
            }

            db.People.Remove(pERSON);
            db.SaveChanges();

            return Ok(pERSON);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PERSONExists(int id)
        {
            return db.People.Count(e => e.PERSON_ID == id) > 0;
        }
    }
}