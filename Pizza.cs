
namespace PizzeriaClasses
{
    public class Pizza
    {
        public int PizzaID { get; private set; }
        public string Name { get;  set; }
        public double Price {  get; set; }
        public int SizeID { get; set; }
        public string Custom {  get; private set; }

        public Pizza(string name, double price, int sizeID, string custom) {
            Name = name;
            Price = price;
            SizeID = sizeID;
            Custom = custom;
        }
        public ICollection<OrderPizza> OrderPizza { get; private set; } 
        public ICollection<IngredientsGroup> IngredientsGroup { get; private set;}
        public Sizes Size { get; set; }
        public override string ToString()
        {
            if (String.Equals(Custom.Trim(),"da"))
                return $"(C) {Name}  - {Size} - {Price} RON";
            else return $"{Name} - {Size} - {Price} RON";

        }
    }

}
