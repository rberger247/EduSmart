﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EduSmart.Data;

namespace EduSmart.Controllers
{
    [Produces("application/json")]
    [Route("api/AspNetUsers")]
    public class AspNetUsersController : Controller
    {
        private readonly EduSmartContext _context;

        public AspNetUsersController(EduSmartContext context)
        {
            _context = context;
        }

        // GET: api/AspNetUsers
        [HttpGet]
        public IEnumerable<AspNetUsers> GetAspNetUsers()
        {
            return _context.AspNetUsers;
        }

        // GET: api/AspNetUsers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAspNetUsers([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aspNetUsers = await _context.AspNetUsers.SingleOrDefaultAsync(m => m.Id == id);

            if (aspNetUsers == null)
            {
                return NotFound();
            }

            return Ok(aspNetUsers);
        }

        // PUT: api/AspNetUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAspNetUsers([FromRoute] string id, [FromBody] AspNetUsers aspNetUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aspNetUsers.Id)
            {
                return BadRequest();
            }

            _context.Entry(aspNetUsers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AspNetUsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AspNetUsers
        [HttpPost]
        public async Task<IActionResult> PostAspNetUsers([FromBody] AspNetUsers aspNetUsers)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.AspNetUsers.Add(aspNetUsers);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AspNetUsersExists(aspNetUsers.Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAspNetUsers", new { id = aspNetUsers.Id }, aspNetUsers);
        }

        // DELETE: api/AspNetUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAspNetUsers([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aspNetUsers = await _context.AspNetUsers.SingleOrDefaultAsync(m => m.Id == id);
            if (aspNetUsers == null)
            {
                return NotFound();
            }

            _context.AspNetUsers.Remove(aspNetUsers);
            await _context.SaveChangesAsync();

            return Ok(aspNetUsers);
        }

        private bool AspNetUsersExists(string id)
        {
            return _context.AspNetUsers.Any(e => e.Id == id);
        }
    }
}