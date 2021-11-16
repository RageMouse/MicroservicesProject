using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderAPI.Data;
using OrderAPI.Models;

namespace OrderAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderServiceContext _context;

        public OrderController(OrderServiceContext context)
        {
            _context = context;
        }

        // GET: /Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TakeAwayOrder>>> GetOrders()
        {
            return await _context.Order.ToListAsync();
        }

        // GET: /Order/4
        [HttpGet("{id}")]
        public async Task<ActionResult<TakeAwayOrder>> GetOrderById(int id)
        {
            var order = await _context.Order.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // POST: /Order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TakeAwayOrder>> CreateOrder([FromBody] TakeAwayOrder order)
        {
            _context.Order.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
        }
    }
}
