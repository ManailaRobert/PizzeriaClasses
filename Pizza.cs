
namespace PizzeriaClasses
{
    public class Pizza:IBuyable
    {
        public int PizzaID { get; private set; }
        private string name;
        public double Price {  get; set; }
        public int SizeID { get; set; }
        public string Custom {  get; private set; }


        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value) == false)
                {
                    if(value.Length >0 && value.Length<= 50)
                    name = value;
                    else throw new Exception("Invalid name. The name should be greated then 0 and smaller or equal to 50.");

                }
                else throw new Exception("Invalid name. Name is empty.");
            }
        }
        public Pizza(string name, double price, int sizeID, string custom) {
            Name = name;
            Price = price;
            SizeID = sizeID;
            Custom = custom;
        }
        public Pizza() { }
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
