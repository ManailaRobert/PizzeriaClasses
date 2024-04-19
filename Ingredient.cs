using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Ingredient
    {
        public int IngredientID { get; set; }  
        public string Name {  get; set; }
        public double Price {  get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price} RON";
        }
        public ICollection<IngredientsGroup>IngredientsGroup { get; set; } 
    
    }
}
