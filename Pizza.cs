
namespace PizzeriaClasses
{
    public class Pizza
    {
        public int PizzaID { get; private set; }
        public string Name { get; private set; }
        public double Price {  get; private set; }
        public int SizeID { get; private set; }
        public string Custom {  get; private set; }

        public Pizza(string name, double price, int sizeID, string custom) {
            Name = name;
            Price = price;
            SizeID = sizeID;
            Custom = custom;
        }
        public ICollection<OrderPizza> OrderPizza { get; private set; } 
        public ICollection<IngredientsGroup> IngredientsGroup { get; private set;}
        public Sizes Size { get;private set; }
    }

}
