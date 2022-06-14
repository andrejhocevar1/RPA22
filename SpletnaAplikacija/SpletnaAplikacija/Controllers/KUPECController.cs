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
using SpletnaAplikacija.Models;

namespace SpletnaAplikacija.Controllers
{
    public class KUPECController : ApiController
    {
        private BazaZaVajeEntities db = new BazaZaVajeEntities();

        // GET: api/KUPEC
        public IQueryable<KUPEC> GetKUPEC()
        {
            return db.KUPEC;
        }

        // GET: api/KUPEC/5
        [ResponseType(typeof(KUPEC))]
        public IHttpActionResult GetKUPEC(int id)
        {
            KUPEC kupec = db.KUPEC.Find(id);
            if (kupec == null)
            {
                return NotFound();
            }

            return Ok(kupec);
        }

        // PUT: api/KUPEC/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutKUPEC(int id, KUPEC kupec)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != kupec.KUP_KODA)
            {
                return BadRequest();
            }

            db.Entry(kupec).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KUPECExists(id))
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

        // POST: api/KUPEC
        [ResponseType(typeof(KUPEC))]
        public IHttpActionResult PostKUPEC(KUPEC kupec)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.KUPEC.Add(kupec);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (KUPECExists(kupec.KUP_KODA))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = kupec.KUP_KODA }, kupec);
        }

        // DELETE: api/KUPEC/5
        [ResponseType(typeof(KUPEC))]
        public IHttpActionResult DeleteKUPEC(int id)
        {
            KUPEC kupec = db.KUPEC.Find(id);
            if (kupec == null)
            {
                return NotFound();
            }

            db.KUPEC.Remove(kupec);
            db.SaveChanges();

            return Ok(kupec);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KUPECExists(int id)
        {
            return db.KUPEC.Count(e => e.KUP_KODA == id) > 0;
        }
    }
}