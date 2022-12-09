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
    public class Veteriner_HizmetController : ApiController
    {
        private Veteriner_MVCAPI_ProjesiEntities db = new Veteriner_MVCAPI_ProjesiEntities();

        // GET: api/Veteriner_Hizmet
        public IQueryable<Veteriner_Hizmet> GetVeteriner_Hizmet()
        {
            return db.Veteriner_Hizmet;
        }

        // GET: api/Veteriner_Hizmet/5
        [ResponseType(typeof(Veteriner_Hizmet))]
        public async Task<IHttpActionResult> GetVeteriner_Hizmet(int id)
        {
            Veteriner_Hizmet veteriner_Hizmet = await db.Veteriner_Hizmet.FindAsync(id);
            if (veteriner_Hizmet == null)
            {
                return NotFound();
            }

            return Ok(veteriner_Hizmet);
        }

        // PUT: api/Veteriner_Hizmet/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeteriner_Hizmet(int id, Veteriner_Hizmet veteriner_Hizmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veteriner_Hizmet.HizmetNo)
            {
                return BadRequest();
            }

            db.Entry(veteriner_Hizmet).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Veteriner_HizmetExists(id))
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

        // POST: api/Veteriner_Hizmet
        [ResponseType(typeof(Veteriner_Hizmet))]
        public async Task<IHttpActionResult> PostVeteriner_Hizmet(Veteriner_Hizmet veteriner_Hizmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veteriner_Hizmet.Add(veteriner_Hizmet);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = veteriner_Hizmet.HizmetNo }, veteriner_Hizmet);
        }

        // DELETE: api/Veteriner_Hizmet/5
        [ResponseType(typeof(Veteriner_Hizmet))]
        public async Task<IHttpActionResult> DeleteVeteriner_Hizmet(int id)
        {
            Veteriner_Hizmet veteriner_Hizmet = await db.Veteriner_Hizmet.FindAsync(id);
            if (veteriner_Hizmet == null)
            {
                return NotFound();
            }

            db.Veteriner_Hizmet.Remove(veteriner_Hizmet);
            await db.SaveChangesAsync();

            return Ok(veteriner_Hizmet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Veteriner_HizmetExists(int id)
        {
            return db.Veteriner_Hizmet.Count(e => e.HizmetNo == id) > 0;
        }
    }
}