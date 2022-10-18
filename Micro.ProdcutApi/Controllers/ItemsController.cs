using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Micro.ProdcutApi.Data;
using Micro.ProductApi.Models;
using Micro.ProdcutApi.Repository;

namespace Micro.ProdcutApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IUnitOfWork _context;

        public ItemsController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/Items
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _context.Items.All();

            return Ok(items);
        }

        // GET: api/Items/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Item>> GetItem(int id)
        {
            var item = await _context.Items.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }

        // PUT: api/Items/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /*
        [HttpPut("{id}")]
        public async Task<IActionResult> PutItem(int id, Item item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            var checking =_context.Items.Upsert(item);
            if (await checking)
            {
                try
                {
                    await _context.CompleteAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                        throw;
                    
                }
            }

           

            return NoContent();
        }
        */

        // POST: api/Items
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Item>> PostItem(Item item)
        {
            var checking = _context.Items.Upsert(item);
            if (await checking)
            {
                try
                {
                    await _context.CompleteAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                   
                        throw;
                    
                }
            }
           

            return CreatedAtAction("GetItem", new { id = item.Id }, item);
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Items.GetById(id);
            if (item == null)
            {
                return NotFound();
            }

            var x = await _context.Items.Delete(id);
            if (x)
            {
                await _context.CompleteAsync();
                return Ok("Done");
            }

            return NoContent();
        }

     
    }
}
