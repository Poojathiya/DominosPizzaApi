using DominosPizza.Models;

namespace DominosPizza.Repository
{
    public interface IPizza
    {
        public List<Pizza> GetAll();
        public Pizza Get(int id);
        public Pizza AddNewPizza(Pizza pizza);
        public void DeletePizza(int PizzaId);
        public Pizza UpdatePizza(int PizzaId, Pizza pizza);
        public bool PizzaExists(int id);

    }
}
