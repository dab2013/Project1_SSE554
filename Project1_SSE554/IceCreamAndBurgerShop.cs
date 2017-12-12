using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_SSE554
{
    public partial class IceCreamAndBurgerShop : Form
    {
        string radioButtonFlavor = "Vanilla";
        double moneyMade = 0.0;
        IceCream order = new Vanilla();
        string[] flavorTypes = { "Vanilla", "Chocolate", "Strawberry", "Cookies n' Cream", "Cotton Candy" };
        string[] toppingTypes = { "Sprinkles", "Gummi Bears", "Oreos", "Strawberries", "Whip Cream", "Cherries","Chocolate Syrup", "Caramel" };
        string[,] customer1, customer2, customer3, customer4, customer5;
        int totalOrders = 0;

        public IceCreamAndBurgerShop()
        {
            InitializeComponent();

            customer1 = cutomerOrder();
            Customer1IceCreamFlavor.Text = customer1[0, 0];
            EffectComponent Damaging = new Effect("Damaging");
            Damaging.addEffect(new EffectItem("posion", 1));
            Customer1IceCreamToppings.Text = Damaging.getAllEffectDescription()[0];

            customer2 = cutomerOrder();
            Customer2IceCreamFlavor.Text = customer2[0, 0];
            Customer2IceCreamToppings.Text = customer2[0, 1];

            customer3 = cutomerOrder();
            Customer3IceCreamFlavor.Text = customer3[0, 0];
            Customer3IceCreamToppings.Text = customer3[0, 1];

            customer4 = cutomerOrder();
            Customer4IceCreamFlavor.Text = customer4[0, 0];
            Customer4IceCreamToppings.Text = customer4[0, 1];

            customer5 = cutomerOrder();
            Customer5IceCreamFlavor.Text = customer5[0, 0];
            Customer5IceCreamToppings.Text = customer5[0, 1];
        }

        private void SubmitOrder_Click(object sender, EventArgs e)
        {
            submitOrder();
            checkOrder();
            totalOrders++;
            if(totalOrders == 5)
            {
                SubmitOrder.Enabled = false;
                MessageBox.Show("You made: $"+ moneyMade + " today");
            }
            //MessageBox.Show(order.getAllOrder());
            //MessageBox.Show(order.totalPrice().ToString());
        }

        private void submitOrder()
        {
            getFlavor();

            List<string> toppings = new List<string>();
            if (Toppings.CheckedIndices.Count != 0)
            {
                foreach (int indexChecked in Toppings.CheckedIndices)
                {
                    if (Toppings.GetItemChecked(indexChecked))
                    {
                        toppings.Add((string)Toppings.Items[indexChecked]);
                    }
                }
                createToppings(toppings);
            }
            else
            {
                order = new None(order);
            }
        }

        private void checkOrder()
        {
            string customer1String = customer1[0, 0] + ", " + customer1[0, 1];
            string customer2String = customer2[0, 0] + ", " + customer2[0, 1];
            string customer3String = customer3[0, 0] + ", " + customer3[0, 1];
            string customer4String = customer4[0, 0] + ", " + customer4[0, 1];
            string customer5String = customer5[0, 0] + ", " + customer5[0, 1];

            if (order.getAllOrder() == customer1String)
            {
                customer5String = "N/A";
                Customer1IceCreamFlavor.Text = "";
                Customer1IceCreamToppings.Text = "";

                moneyMade += order.totalPrice();
            }
            else if (order.getAllOrder() == customer2String)
            {
                customer5String = "N/A";
                Customer2IceCreamFlavor.Text = "";
                Customer2IceCreamToppings.Text = "";

                moneyMade += order.totalPrice();
            }
            else if (order.getAllOrder() == customer3String)
            {
                customer5String = "N/A";
                Customer3IceCreamFlavor.Text = "";
                Customer3IceCreamToppings.Text = "";

                moneyMade += order.totalPrice();
            }
            else if (order.getAllOrder() == customer4String)
            {
                customer5String = "N/A";
                Customer4IceCreamFlavor.Text = "";
                Customer4IceCreamToppings.Text = "";

                moneyMade += order.totalPrice();
            }
            else if (order.getAllOrder() == customer5String)
            {
                customer5String = "N/A";
                Customer5IceCreamFlavor.Text = "";
                Customer5IceCreamToppings.Text = "";

                moneyMade += order.totalPrice();
            }
        }

        private string[,] cutomerOrder()
        {
            System.Threading.Thread.Sleep(500);
            Random rnd1 = new Random();
            int flavorChoice = rnd1.Next(0, 4);
            int numberToppingChoice = rnd1.Next(0, 4);
            List<int> toppingChoices = new List<int>();
            string flavorChoiceString = flavorTypes[flavorChoice];
            List<string> topppingChoiceList = new List<string>();
            string topppingChoiceString = "";

            Random rnd = new Random();
            string[] randomizedChoices = toppingTypes.OrderBy(x => rnd.Next()).ToArray();

            if (numberToppingChoice == 0)
            {
                topppingChoiceString = "None";
            }
            else
            {
                for (int x = 0; x < numberToppingChoice; x++)
                {
                    topppingChoiceList.Add( randomizedChoices[x]);
                    
                }
                topppingChoiceList.Sort();
                for(int x = 0; x < topppingChoiceList.Count(); x++)
                {
                    topppingChoiceString += topppingChoiceList[x];
                    if (x + 1 != topppingChoiceList.Count())
                        topppingChoiceString += ", ";
                }

            }



            string[,] customerOrder = new string[1, 2] { { flavorChoiceString, topppingChoiceString } };
            return customerOrder;

        }

        private string createToppings( List<string> toppings)
        {
            for(int x = 0; x< toppings.Count; x++ )
            {
                getToppings(toppings[x]);
            }


            return "";
        }

        private void getFlavor()
        {
            if(radioButtonFlavor == "vanilla")
            {
                order = new Vanilla();
            }
            else if (radioButtonFlavor == "chocolate")
            {
                order = new Chocolate();
            }
            else if (radioButtonFlavor == "strawberry")
            {
                order = new Strawberry();
            }
            else if (radioButtonFlavor == "cookies n' cream")
            {
                order = new CookiesNCream();
            }
            else if (radioButtonFlavor == "cotton candy")
            {
                order = new CottonCandy();
            }
        }

        private void getToppings(string toppings)
        {    
            if (toppings == "Caramel")
                order = new Caramel(order);
            else if (toppings == "Cherries")
                order = new Cherries(order);
            else if (toppings == "Chocolate Syrup")
                order = new ChocolateSyrup(order);
            else if (toppings == "Gummi Bears")
                order = new GummiBears(order);
            else if (toppings == "Oreos")
                order = new Oreos(order);
            else if (toppings == "Sprinkles")
                order = new Sprinkles(order);
            else if (toppings == "Strawberries")
                order = new Strawberries(order);
            else if (toppings == "Whip Cream")
                order = new WhipCream(order);
        }

        #region buttons
        private void IceCreamFlavors_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFlavor = "vanilla";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChooseGameType again = new ChooseGameType();
            again.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFlavor = "chocolate";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFlavor = "strawberry";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFlavor = "cookies n' cream";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonFlavor = "cotton candy";
        }
        #endregion
    }

    #region Decorator Pattern
    public abstract class IceCream
    {

        public string order = "undecided";
        public abstract String getAllOrder();
        public abstract double totalPrice();

    }

    #region Flavors definition 
    public class Vanilla : IceCream
    {
        public override String getAllOrder()
        {
            return "Vanilla";
        }
        public override double totalPrice()
        {
            return 1.00;
        }
    }

    public class Chocolate : IceCream
    {
        public override String getAllOrder()
        {
            return "Chocolate";
        }
        public override double totalPrice()
        {
            return 1.10;
        }
    }

    public class Strawberry : IceCream
    {
        public override String getAllOrder()
        {
            return "Strawberry";
        }
        public override double totalPrice()
        {
            return 1.05;
        }
    }

    public class CookiesNCream : IceCream
    {
        public override String getAllOrder()
        {
            return "Cookies n' Cream";
        }
        public override double totalPrice()
        {
            return 1.15;
        }
    }

    public class CottonCandy : IceCream
    {
        public override String getAllOrder()
        {
            return "Cotton Candy";
        }
        public override double totalPrice()
        {
            return 1.30;
        }
    }
    #endregion

    #region Toppings definition 
    public abstract class Toppings: IceCream
    {
    }

    public class Sprinkles : Toppings
    {
        IceCream iceCream;
        public Sprinkles(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Sprinkles";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .2;
        }
    }

    public class GummiBears : Toppings
    {
        IceCream iceCream;
        public GummiBears(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Gummi Bears";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .3;
        }
    }

    public class Oreos : Toppings
    {
        IceCream iceCream;
        public Oreos(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Oreos";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .6;
        }
    }

    public class Strawberries : Toppings
    {
        IceCream iceCream;
        public Strawberries(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Strawberries";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .10;
        }
    }

    public class WhipCream : Toppings
    {
        IceCream iceCream;
        public WhipCream(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Whip Cream";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .15;
        }
    }

    public class Cherries : Toppings
    {
        IceCream iceCream;
        public Cherries(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Cherries";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .1;
        }
    }

    public class ChocolateSyrup : Toppings
    {
        IceCream iceCream;
        public ChocolateSyrup(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Chocolate Syrup";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .50;
        }
    }

    public class Caramel : Toppings
    {
        IceCream iceCream;
        public Caramel(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", Caramel";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + .50;
        }
    }

    public class None : Toppings
    {
        IceCream iceCream;
        public None(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }
        public override String getAllOrder()
        {
            return iceCream.getAllOrder() + ", None";
        }
        public override double totalPrice()
        {
            return iceCream.totalPrice() + 0;
        }
    }
    #endregion

    #endregion

    #region Template Pattern

    public abstract class Burger
    {
        public string makeBurger()
        {
            string order = "";
            if (Patty())
            {
                order += addPatty();
            }
            if (Cheese())
            {
                order += addCheese();
            }
            if (Lettuce())
            {
                order += addLettuce();
            }
            if (Tomato())
            {
                order += addTomato();
            }
            if (TofuPatty())
            {
                order += addTofuPatty();
            }
            if (Condiments())
            {
                order += addCondiments();
            }
            if (Bacon())
            {
                order += addBacon();
            }
            if (Pickles())
            {
                order += addPickles();
            }

            return order;
        }

        public abstract string addPatty();
        public abstract string addCheese();
        public abstract string addLettuce();
        public abstract string addTomato();
        public abstract string addTofuPatty();
        public abstract string addCondiments();
        public abstract string addBacon();
        public abstract string addPickles();

        public Boolean Patty() { return true; }
        public Boolean Cheese() { return true; }
        public Boolean Lettuce() { return true; }
        public Boolean Tomato() { return true; }
        public Boolean TofuPatty() { return true; }
        public Boolean Condiments() { return true; }
        public Boolean Bacon() { return true; }
        public Boolean Pickles() { return true; }
    }

    public class RegularBurger : Burger
    {
        String condiments =  "Ketchup Mustard " ;

        new Boolean TofuPatty() { return false; }
        new Boolean Pickles() { return false; }
        new Boolean Bacon() { return false; }

        public override string addPatty() { return "Patty "; }
        public override string addCheese() { return "Cheese "; }
        public override string addLettuce() { return "Lettuce "; }
        public override string addTomato() { return "Tomato "; }
        public override string addCondiments() { return condiments; }

        public override string addTofuPatty() { return ""; }
        public override string addBacon() { return ""; }
        public override string addPickles() { return ""; }
    }

    public class BaconBurger : Burger
    {
        String condiments = "Ketchup Mustard ";

        new Boolean TofuPatty() { return false; }
        new Boolean Pickles() { return false; }

        public override string addPatty() { return "Patty "; }
        public override string addCheese() { return "Cheese "; }
        public override string addLettuce() { return "Lettuce "; }
        public override string addTomato() { return "Tomato "; }
        public override string addCondiments() { return condiments; }
        public override string addBacon() { return "Bacon "; }

        public override string addTofuPatty() { return ""; }
        public override string addPickles() { return ""; }
    }

    public class SpecialBurger : Burger
    {
        String condiments = "Ketchup Mustard ";

        new Boolean TofuPatty() { return false; }

        public override string addPatty() { return "Patty "; }
        public override string addCheese() { return "Cheese "; }
        public override string addLettuce() { return "Lettuce "; }
        public override string addTomato() { return "Tomato "; }
        public override string addCondiments() { return condiments; }
        public override string addBacon() { return "Bacon "; }
        public override string addPickles() { return "Pickles "; }

        public override string addTofuPatty() { return ""; }
    }

    public class VeggieBurger : Burger
    {
        String condiments = "Ketchup Mustard ";

        new Boolean Patty() { return false; }
        new Boolean Cheese() { return false; }
        new Boolean Bacon() { return false; }

        public override string addLettuce() { return "Lettuce "; }
        public override string addTomato() { return "Tomato "; }
        public override string addCondiments() { return condiments; }
        public override string addPickles() { return "Pickles "; }
        public override string addTofuPatty() { return "Tofu Patty "; }

        public override string addPatty() { return ""; }
        public override string addCheese() { return ""; }
        public override string addBacon() { return ""; }
    }

    #endregion
}
