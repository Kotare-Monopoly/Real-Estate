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
using RealEstate.Models;

namespace RealEstate.Controllers
{
    public class PropertiesController : ApiController
    {
        private RealEstateDbContext db = new RealEstateDbContext();

        // GET: api/Properties
        public IQueryable<Property> GetProperties()
        {
            return db.Properties;
        }

        // GET: api/Properties/5
        [ResponseType(typeof(Property))]
        public async Task<IHttpActionResult> GetProperty(string id)
        {
            Property property = await db.Properties.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }

            return Ok(property);
        }

        // PUT: api/Properties/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProperty(string id, Property property)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != property.Name)
            {
                return BadRequest();
            }

            db.Entry(property).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropertyExists(id))
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

        // POST: api/Properties
        [ResponseType(typeof(Property))]
        public async Task<IHttpActionResult> PostProperty(Property property)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Properties.Add(property);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PropertyExists(property.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = property.Name }, property);
        }

        // DELETE: api/Properties/5
        [ResponseType(typeof(Property))]
        public async Task<IHttpActionResult> DeleteProperty(string id)
        {
            Property property = await db.Properties.FindAsync(id);
            if (property == null)
            {
                return NotFound();
            }

            db.Properties.Remove(property);
            await db.SaveChangesAsync();

            return Ok(property);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PropertyExists(string id)
        {
            return db.Properties.Count(e => e.Name == id) > 0;
        }
    }
}