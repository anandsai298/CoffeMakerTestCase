using CoffeMaker;
using Moq;

namespace CoffeeMakerTestCases
{
    public class Tests
    { 
        //fake
        [Test]
        public void OrderCoffe_ShouldReturn_RecievedMessage()
        {
            //InterfaceMakeCoffe coffee=new FakeStarBucks();
            StarBuckStore store = new StarBuckStore(new FakeStarBucks());
            string order = store.OrderACoffee(2, 4);
            Assert.AreEqual("Your Order is Recieved",order);
        }
        //moq
        [Test]
        public void OrderCoffeMock_ShouldReturn_RecievedMessage()
        {
            var service = new Mock<InterfaceMakeCoffe>();
            service.Setup(x=>x.CheckIngredientAvailability()).Returns(true);
            service.Setup(x => x.CoffeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your Order is Recieved");
            StarBuckStore store = new StarBuckStore(service.Object);
            string order = store.OrderACoffee(2, 4);
            Assert.AreEqual("Your Order is Recieved", order);
        }
        //stub
        [Test]
        public void OrderCoffeStub_ShouldReturn_RecievedMessage()
        {
            //InterfaceMakeCoffe coffee=new StubStarBucks();
            StarBuckStore store = new StarBuckStore(new StubStarBucks());
            string order = store.OrderACoffee(2, 4);
            Assert.AreEqual("Your Order is Recieved", order);
        }
    }
}