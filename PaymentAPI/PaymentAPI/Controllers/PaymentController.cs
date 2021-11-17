using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PaymentAPI.Data;
using PaymentAPI.Models;

namespace PaymentAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : Controller
    {
        private readonly PaymentServiceContext _context;

        public PaymentController(PaymentServiceContext context)
        {
            _context = context;
        }

        // GET: /Payment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetOrders()
        {
            return await _context.Payment.ToListAsync();
        }

        // GET: /Payment/4
        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetOrderById(int id)
        {
            var Payment = await _context.Payment.FindAsync(id);
            if (Payment == null)
            {
                return NotFound();
            }

            return Payment;
        }

        // POST: /Payment
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payment>> CreateOrder([FromBody] Payment Payment)
        {
            _context.Payment.Add(Payment);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrderById), new { id = Payment.Id }, Payment);
        }
    }
}
