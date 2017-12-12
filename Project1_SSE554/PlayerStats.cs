using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_SSE554
{
    public class PlayerStats
    {
        int gold = 50;



        public int getGold()
        {
            return gold;
        }

        public void setGold(int newGold)
        {
            this.gold = newGold;
        }
    }    
}
