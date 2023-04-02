namespace CoffeMaker
{
    public class StarBucks : InterfaceMakeCoffe
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeMaking(int SugarPerSpoon, int CoffePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarBucks : InterfaceMakeCoffe
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeMaking(int SugarPerSpoon, int CoffePack)
        {
            return "Your Order is Recieved";
        }
    }
    public class FakeStarBucks : InterfaceMakeCoffe
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeMaking(int SugarPerSpoon, int CoffePack)
        {
            return "Your Order is Recieved";
        }
    }
}