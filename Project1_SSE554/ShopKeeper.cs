using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_SSE554
{
    public class ShopKeeper
    {
        ShopKeepState soldOut;
        ShopKeepState outOfMoney;
        ShopKeepState selling;
        int gold =  200;
        int numOfItems = 10;
        ShopKeepState state;

        public ShopKeeper()
        {
            soldOut = new SoldOutState(this);
            outOfMoney = new hasNoMoneyState(this);
            selling = new SellingState(this);

            if(numOfItems < 1){
                state = soldOut;
            }
            else if (gold < 1){
                state = outOfMoney;
            }
            else{
                state = selling;
            }

        }

        public ShopKeepState getState()
        {
            return state;
        }

        public void setState(ShopKeepState newState)
        {
            this.state = newState;
        }

        public int getGold()
        {
            return gold;
        }

        public void setGold(int newGold)
        {
            this.gold = newGold;
        }

        public int getNumOfItems()
        {
            return numOfItems;
        }

        public void setNumOfItems(int newNumOfItems)
        {
            this.numOfItems = newNumOfItems;
        }

        public ShopKeepState getSoldOut() { return soldOut; }
        public ShopKeepState getOutOfMoney() { return outOfMoney; }
        public ShopKeepState getSelling() { return selling; }
    }

    public interface ShopKeepState {
        string purchase();
        string sell();
        string getItem();
    }

    public class SellingState : ShopKeepState
    {
        ShopKeeper shopKeeper;
        PlayerStats player;

        public SellingState(ShopKeeper newShopKeeper)
        {
            this.shopKeeper = newShopKeeper;
        }

        public string getItem()
        {
            if(player.getGold() > 0)
            {
                player.setGold(player.getGold() - 1);
                shopKeeper.setGold(shopKeeper.getGold() + 1);
                shopKeeper.setNumOfItems(shopKeeper.getNumOfItems() - 1);

                if (shopKeeper.getNumOfItems() <= 0)
                    shopKeeper.setState(shopKeeper.getSoldOut());

                return "Player bought the item";
            }
            
            return "Not enough gold";
        }

        public string purchase()
        {
            return "What ya like?";
        }

        public string sell()
        {
            shopKeeper.setState(shopKeeper.getSelling());
            return "What would ya like to sell?";
        }
    }

    public class SoldOutState : ShopKeepState
    {
        ShopKeeper shopKeeper;

        public SoldOutState(ShopKeeper newShopKeeper)
        {
            this.shopKeeper = newShopKeeper;
        }

        public string getItem()
        {
            return "Nothing to sell";
        }

        public string purchase()
        {
            return "Nothing to sell";
        }

        public string sell()
        {
            shopKeeper.setState(shopKeeper.getSelling());
            return "What would ya like to sell?"; 
        }
    }

    public class hasNoMoneyState : ShopKeepState
    {
        ShopKeeper shopKeeper;

        public hasNoMoneyState(ShopKeeper newShopKeeper)
        {
            this.shopKeeper = newShopKeeper;
        }

        public string getItem()
        {
            return "Are you trying to steal?";
        }

        public string purchase()
        {
            shopKeeper.setState(shopKeeper.getSelling());
            return "What ya like?";
        }

        public string sell()
        {
            return "Sorry out of money";
        }
    }

}
