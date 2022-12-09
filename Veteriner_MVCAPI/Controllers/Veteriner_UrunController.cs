using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Veteriner_MVCAPI.Models;

namespace Veteriner_MVCAPI.Controllers
{
    public class Veteriner_UrunController : ApiController
    {
        private Veteriner_MVCAPI_ProjesiEntities db = new Veteriner_MVCAPI_ProjesiEntities();

        // GET: api/Veteriner_Urun
        public IQueryable<Veteriner_Urun> GetVeteriner_Urun()
        {
            return db.Veteriner_Urun;
        }

        // GET: api/Veteriner_Urun/5
        [ResponseType(typeof(Veteriner_Urun))]
        public async Task<IHttpActionResult> GetVeteriner_Urun(int id)
        {
            Veteriner_Urun veteriner_Urun = await db.Veteriner_Urun.FindAsync(id);
            if (veteriner_Urun == null)
            {
                return NotFound();
            }

            return Ok(veteriner_Urun);
        }

        // PUT: api/Veteriner_Urun/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeteriner_Urun(int id, Veteriner_Urun veteriner_Urun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veteriner_Urun.UrunNo)
            {
                return BadRequest();
            }

            db.Entry(veteriner_Urun).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Veteriner_UrunExists(id))
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

        // POST: api/Veteriner_Urun
        [ResponseType(typeof(Veteriner_Urun))]
        public async Task<IHttpActionResult> PostVeteriner_Urun(Veteriner_Urun veteriner_Urun)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veteriner_Urun.Add(veteriner_Urun);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = veteriner_Urun.UrunNo }, veteriner_Urun);
        }

        // DELETE: api/Veteriner_Urun/5
        [ResponseType(typeof(Veteriner_Urun))]
        public async Task<IHttpActionResult> DeleteVeteriner_Urun(int id)
        {
            Veteriner_Urun veteriner_Urun = await db.Veteriner_Urun.FindAsync(id);
            if (veteriner_Urun == null)
            {
                return NotFound();
            }

            db.Veteriner_Urun.Remove(veteriner_Urun);
            await db.SaveChangesAsync();

            return Ok(veteriner_Urun);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Veteriner_UrunExists(int id)
        {
            return db.Veteriner_Urun.Count(e => e.UrunNo == id) > 0;
        }
    }
}