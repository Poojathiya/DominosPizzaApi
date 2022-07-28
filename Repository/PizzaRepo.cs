using DominosPizza.Models;

namespace DominosPizza.Repository
{
    public class PizzaRepo : IPizza
    {
        //Step 2
        private readonly DominosDbContext _context;

        public PizzaRepo()
        {

        }
        public PizzaRepo(DominosDbContext context)
        {
            _context = context;
        }


        public Pizza AddNewPizza(Pizza pizza)
        {
            _context.Pizzas.Add(pizza);
            _context.SaveChanges();
            return pizza;
        }

        public void DeletePizza(int PizzaId)
        {
            Pizza pizza = _context.Pizzas.Find(PizzaId);
            _context.Pizzas.Remove(pizza);
            _context.SaveChanges();

        }

        public Pizza Get(int PizzaId)
        {
            Pizza pizza = _context.Pizzas.Find(PizzaId);
            return pizza;
        }

        public List<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }

        public Pizza UpdatePizza(int PizzaId, Pizza pizza)
        {
            Pizza pizza1 = _context.Pizzas.Find(PizzaId);
            pizza1.PizzaName = pizza.PizzaName;
            pizza1.PizzaType = pizza.PizzaType;
            pizza1.Price = pizza.Price;
            _context.Update(pizza1);
            _context.SaveChanges();

            return pizza1;

        }
        public bool PizzaExists(int id)
        {
            return (_context.Pizzas?.Any(e => e.PizzaId == id)).GetValueOrDefault();
        }
    }
}
