using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RealEstate.Models;

namespace RealEstate.Controllers.v1
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
        public async Task<IHttpActionResult> GetProperty(int id)
        {
            Property property = await db.Properties.SingleOrDefaultAsync(p => p.LocationId == id);
            if (property == null)
            {
                return NotFound();
            }

            return Ok(property);
        }

        // PUT: api/Properties/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutProperty(int id, Property property)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != property.Id)
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
                if (PropertyExists(property.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = property.Id }, property);
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

        private bool PropertyExists(int id)
        {
            return db.Properties.Count(e => e.Id == id) > 0;
        }
    }
}