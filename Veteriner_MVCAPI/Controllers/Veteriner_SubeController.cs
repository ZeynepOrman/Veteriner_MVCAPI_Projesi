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
    public class Veteriner_SubeController : ApiController
    {
        private Veteriner_MVCAPI_ProjesiEntities db = new Veteriner_MVCAPI_ProjesiEntities();

        // GET: api/Veteriner_Sube
        public IQueryable<Veteriner_Sube> GetVeteriner_Sube()
        {
            return db.Veteriner_Sube;
        }

        // GET: api/Veteriner_Sube/5
        [ResponseType(typeof(Veteriner_Sube))]
        public async Task<IHttpActionResult> GetVeteriner_Sube(int id)
        {
            Veteriner_Sube veteriner_Sube = await db.Veteriner_Sube.FindAsync(id);
            if (veteriner_Sube == null)
            {
                return NotFound();
            }

            return Ok(veteriner_Sube);
        }

        // PUT: api/Veteriner_Sube/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeteriner_Sube(int id, Veteriner_Sube veteriner_Sube)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veteriner_Sube.SubeNo)
            {
                return BadRequest();
            }

            db.Entry(veteriner_Sube).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Veteriner_SubeExists(id))
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

        // POST: api/Veteriner_Sube
        [ResponseType(typeof(Veteriner_Sube))]
        public async Task<IHttpActionResult> PostVeteriner_Sube(Veteriner_Sube veteriner_Sube)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veteriner_Sube.Add(veteriner_Sube);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = veteriner_Sube.SubeNo }, veteriner_Sube);
        }

        // DELETE: api/Veteriner_Sube/5
        [ResponseType(typeof(Veteriner_Sube))]
        public async Task<IHttpActionResult> DeleteVeteriner_Sube(int id)
        {
            Veteriner_Sube veteriner_Sube = await db.Veteriner_Sube.FindAsync(id);
            if (veteriner_Sube == null)
            {
                return NotFound();
            }

            db.Veteriner_Sube.Remove(veteriner_Sube);
            await db.SaveChangesAsync();

            return Ok(veteriner_Sube);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Veteriner_SubeExists(int id)
        {
            return db.Veteriner_Sube.Count(e => e.SubeNo == id) > 0;
        }
    }
}