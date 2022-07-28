using System.ComponentModel.DataAnnotations;

namespace DominosPizza.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public float Price { get; set; }
        public string PizzaType { get; set; }

    }
}
