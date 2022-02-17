using Microsoft.AspNetCore.Mvc;
using Order.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ApplicationContext context;

        public OrderController(ApplicationContext context)
        {
            this.context = context;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Models.Order> Get()
        {
            return context.Orders.ToList();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Models.Order Get(int id)
        {
            return context.Orders.FirstOrDefault(a => a.Id == id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post([FromBody] Models.Order value)
        {
            context.Orders.Add(value);
            context.SaveChanges();
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.Order value)
        {
            var order = context.Orders.FirstOrDefault(a => a.Id == id);

            order = value;

            context.Orders.Update(order);

            context.SaveChanges();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var order = context.Orders.FirstOrDefault(a => a.Id == id);

            context.Orders.Remove(order);

            context.SaveChanges(true);
        }
    }
}
