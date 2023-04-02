using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMaker
{
    public interface InterfaceMakeCoffe
    {
        bool CheckIngredientAvailability();
        string CoffeMaking(int SugarPerSpoon, int CoffeePack);
    }
}
