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
using WebApp3.Models;

namespace WebApp3.Controllers
{
    public class NotesController : ApiController
    {
        private WebApp3Context db = new WebApp3Context();

        // GET: api/Notes
        public IQueryable<Notes> GetNotes()
        {
			//return db.Notes

			//.Include(b => b.Category).Include(c => c.User);

			//var category = from c in db.Notes
						 // select new UserDTO()
						  // {
							  // Id = c.Id
							  // Email = c.User.Email
							
						//};

			return category;

		}



		// GET: api/Notes/5
		[ResponseType(typeof(Notes))]
        public async Task<IHttpActionResult> GetNotes(int id)
        {
            Notes notes = await db.Notes.FindAsync(id);
            if (notes == null)
            {
                return NotFound();
            }

            return Ok(notes);
        }

        // PUT: api/Notes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutNotes(int id, Notes notes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != notes.Id)
            {
                return BadRequest();
            }

            db.Entry(notes).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NotesExists(id))
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

        // POST: api/Notes
        [ResponseType(typeof(Notes))]
        public async Task<IHttpActionResult> PostNotes(Notes notes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Notes.Add(notes);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = notes.Id }, notes);
        }

        // DELETE: api/Notes/5
        [ResponseType(typeof(Notes))]
        public async Task<IHttpActionResult> DeleteNotes(int id)
        {
            Notes notes = await db.Notes.FindAsync(id);
            if (notes == null)
            {
                return NotFound();
            }

            db.Notes.Remove(notes);
            await db.SaveChangesAsync();

            return Ok(notes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NotesExists(int id)
        {
            return db.Notes.Count(e => e.Id == id) > 0;
        }
    }
}