using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Cart
    {
        public List<Pizza> PizzasList { get; set; }
        public List<Beverage>BeveragesList;
        public double cartPrice { get; private set; }
        public Cart() {
            PizzasList = new List<Pizza>();
            BeveragesList = new List<Beverage>();   
        }

        public void Add(IBuyable item)
        {
            if (item is Pizza pizza)
            {
                PizzasList.Add(pizza);
                cartPrice += pizza.Price;
            }
            else if (item is Beverage beverage)
            {
                BeveragesList.Add(beverage);
                cartPrice += beverage.Price;
            }
            else throw new Exception("Unsuported type for cart.");
        }
        public void Remove(IBuyable item)
        {
            if (item is Pizza pizza)
            {
                PizzasList.Remove(pizza);
                cartPrice -= pizza.Price;
            }
            else if (item is Beverage beverage)
            {
                BeveragesList.Remove(beverage);
                cartPrice -= beverage.Price;
            }
        }
        public int Count
        {
            get { return PizzasList.Count + BeveragesList.Count; }
        }

        public List<IBuyable> ToList()
        {
            List<IBuyable > list = new List<IBuyable>();
            list.AddRange(PizzasList);
            list.AddRange(BeveragesList);
            return list;
        }
    }
}
