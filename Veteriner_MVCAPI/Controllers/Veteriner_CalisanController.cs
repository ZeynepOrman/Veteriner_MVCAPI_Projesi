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
    public class Veteriner_CalisanController : ApiController
    {
        private Veteriner_MVCAPI_ProjesiEntities db = new Veteriner_MVCAPI_ProjesiEntities();

        // GET: api/Veteriner_Calisan
        public IQueryable<Veteriner_Calisan> GetVeteriner_Calisan()
        {
            return db.Veteriner_Calisan;
        }

        // GET: api/Veteriner_Calisan/5
        [ResponseType(typeof(Veteriner_Calisan))]
        public async Task<IHttpActionResult> GetVeteriner_Calisan(int id)
        {
            Veteriner_Calisan veteriner_Calisan = await db.Veteriner_Calisan.FindAsync(id);
            if (veteriner_Calisan == null)
            {
                return NotFound();
            }

            return Ok(veteriner_Calisan);
        }

        // PUT: api/Veteriner_Calisan/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeteriner_Calisan(int id, Veteriner_Calisan veteriner_Calisan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veteriner_Calisan.CalisanNo)
            {
                return BadRequest();
            }

            db.Entry(veteriner_Calisan).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Veteriner_CalisanExists(id))
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

        // POST: api/Veteriner_Calisan
        [ResponseType(typeof(Veteriner_Calisan))]
        public async Task<IHttpActionResult> PostVeteriner_Calisan(Veteriner_Calisan veteriner_Calisan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veteriner_Calisan.Add(veteriner_Calisan);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = veteriner_Calisan.CalisanNo }, veteriner_Calisan);
        }

        // DELETE: api/Veteriner_Calisan/5
        [ResponseType(typeof(Veteriner_Calisan))]
        public async Task<IHttpActionResult> DeleteVeteriner_Calisan(int id)
        {
            Veteriner_Calisan veteriner_Calisan = await db.Veteriner_Calisan.FindAsync(id);
            if (veteriner_Calisan == null)
            {
                return NotFound();
            }

            db.Veteriner_Calisan.Remove(veteriner_Calisan);
            await db.SaveChangesAsync();

            return Ok(veteriner_Calisan);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Veteriner_CalisanExists(int id)
        {
            return db.Veteriner_Calisan.Count(e => e.CalisanNo == id) > 0;
        }
    }
}