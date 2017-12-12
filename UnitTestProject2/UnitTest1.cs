using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1_SSE554;
using System.Collections.Generic;
using System.Diagnostics;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEndless()
        {
            GameType game = new GameType();
            int num = game.setGameType("Endless-RPS");
            Assert.IsTrue(num == 0);
        }

        [TestMethod]
        public void TestFirstToTwo()
        {
            GameType game = new GameType();
            int num = game.setGameType("FirstToTwo-RPS");
            Assert.IsTrue(num == 1);
        }

        [TestMethod]
        public void TestGuessTheNumber()
        {
            GameType game = new GameType();
            int num = game.setGameType("GuessTheNumber");
            Assert.IsTrue(num == 2);
        }

        [TestMethod]
        public void TestRange()
        {
            GameType game = new GameType();
            string range = "1-10";
            int[] numberRange = game.numberRangeChosen(range);
            Assert.IsTrue(numberRange[0] == 1 && numberRange[1] == 10);
        }

        [TestMethod]
        public void TestCommandPattern()
        {
            controls newXboxController = getcontrollerLayoutXbox.getButton();
            pressA aCommand = new pressA(newXboxController);
            XboxButton aPressed = new XboxButton(aCommand);
            Assert.IsTrue(aPressed.press() == "Attack Down");

            pressB bCommand = new pressB(newXboxController);
            XboxButton bPressed = new XboxButton(bCommand);
            Assert.IsTrue(bPressed.press() == "Attack Right");

            pressX xCommand = new pressX(newXboxController);
            XboxButton xPressed = new XboxButton(xCommand);
            Assert.IsTrue(xCommand.press() == "Attack Left");

            pressY yCommand = new pressY(newXboxController);
            XboxButton yPressed = new XboxButton(yCommand);
            Assert.IsTrue(yCommand.press() == "Attack Up");
        }

        [TestMethod]
        public void TestDecoratorPattern()
        {
            IceCream order = new Vanilla();
            order = new Oreos(order);
            order = new Cherries(order);
            order = new WhipCream(order);
            Assert.IsTrue(order.getAllOrder() == "Vanilla, Oreos, Cherries, Whip Cream");
        }

        [TestMethod]
        public void TestObserverPattern()
        {
            Librarian librarian = new Librarian();
            LibrarianObserver lo = new LibrarianObserver(librarian);

            librarian.setBookName("Head First Design Patterns");
            librarian.setDate(11.21);
            List<string>  test = librarian.setStatus("checked out");

            Assert.IsTrue(test[0] == "Head First Design Patterns was checked out");

        }

        [TestMethod]
        public void TestFactoryPattern()
        {
            var results = GameResultsClass.getResultsFactory("rock", "paper");
            Assert.IsTrue(results.getFinalsSaying() == "Paper covers rock - You Lose");

            results = GameResultsClass.getResultsFactory("spock", "lizard");
            Assert.IsTrue(results.getFinalsSaying() == "Lizard poisons Spock - You Lose");

            results = GameResultsClass.getResultsFactory("scissors", "scissors");
            Assert.IsTrue(results.getFinalsSaying() =="How boring a tie");
        }

        [TestMethod]
        public void TestAdapterPattern()
        {
            Skeleton skelly = new Skeleton();
            SkeletonAdapter skeleton = new SkeletonAdapter(skelly);

            Assert.IsTrue(skeleton.health() <= 10 && skeleton.health() >= 5);
        }

        [TestMethod]
        public void TestStatePattern()
        {
            ShopKeeper shopKeep = new ShopKeeper();
            SellingState state = new SellingState(shopKeep);
            Assert.IsTrue(shopKeep.getState().ToString() == state.ToString());
        }

        [TestMethod]
        public void TestCompositePattern()
        {
            EffectComponent Damaging = new Effect("Damaging");
            Damaging.addEffect(new EffectItem("posion", 1));
            Assert.IsTrue(Damaging.getAllEffectDescription()[0] == "Damaging - The potion is poison and lasts for 1 turn(s)");
        }

        [TestMethod]
        public void TestTemplatePattern()
        {
            RegularBurger customer1 = new RegularBurger();
            Assert.IsTrue(customer1.makeBurger() == "Patty Cheese Lettuce Tomato Ketchup Mustard ");
        }
    }
}
