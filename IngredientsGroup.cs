using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class IngredientsGroup
    {
        public int IngredientsGroupID {  get; private set; }
        public int IngredientID {  get; private set; }
        public int PizzaID {  get; private set; }


        public IngredientsGroup(int ingredientID, int pizzaID)
        {
            IngredientID = ingredientID;
            PizzaID = pizzaID;
        }
        public Pizza Pizza { get; private set; }
        public Ingredient Ingredient { get; private set; }
    }
}
