using DominosPizza.Models;
using DominosPizza.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DominosPizza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly IPizza _pizzaobj;

        public PizzasController(IPizza pizzaobj)
        {
            _pizzaobj = pizzaobj;
        }

        // GET: api/AutoPizzas
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll()
        {
            return _pizzaobj.GetAll();
        }

        // GET: api/AutoPizzas/5
        [HttpGet("{PizzaId}")]
        public ActionResult<Pizza> Get(int PizzaId)
        {
            Pizza pizza = _pizzaobj.Get(PizzaId);
            return pizza;
        }

        // PUT: api/AutoPizzas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{PizzaId}")]
        public ActionResult PutPizza(int PizzaId, Pizza pizza)
        {
            try
            {
                _pizzaobj.UpdatePizza(PizzaId, pizza);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_pizzaobj.PizzaExists(PizzaId))
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

        // POST: api/AutoPizzas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Pizza> PostPizza(Pizza pizza)
        {
            _pizzaobj.AddNewPizza(pizza);
            return NoContent();
        }

        // DELETE: api/AutoPizzas/5
        [HttpDelete("{PizzaId}")]
        public async Task<IActionResult> DeletePizza(int PizzaId)
        {
            _pizzaobj.DeletePizza(PizzaId);
            return NoContent();
        }
    }
}
