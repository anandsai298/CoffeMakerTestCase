using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMaker
{
    public class StarBuckStore
    {
        public readonly InterfaceMakeCoffe coffee;
        public StarBuckStore(InterfaceMakeCoffe coffee) 
        {
            this.coffee = coffee;
        }
        public string OrderACoffee(int SugarPerSpoon, int CoffeePack)
        {
            if (coffee.CheckIngredientAvailability())
            {
                return coffee.CoffeMaking(SugarPerSpoon, CoffeePack);
            }
            else
            {
                return "Sorry! Coffee is not available";
            }

        }
    }
}
