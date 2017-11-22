using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_SSE554
{
     public class GameResultsClass
    {
        public static UserOutcome getResultsFactory(string user, string computer)
        {
            UserOutcome output = new Empty();
            if (user.Equals("rock"))
            {
                return new Rock(computer);
            }
            else if (user.Equals("paper"))
            {
                return new Paper(computer);
            }
            else if (user.Equals("scissors"))
            {
                return new Scissors(computer);
            }
            else if (user.Equals("lizard"))
            {
                return new Lizard(computer);
            }
            else if (user.Equals("spock"))
            {
                return new Spock(computer);
            }

            return output;
        }
    }

    public abstract class UserOutcome
    {
        private string finalsSaying;
        public void setFinalsSaying(string finals) { finalsSaying = finals; }
        public string getFinalsSaying() { return finalsSaying; }
    }

    class Spock: UserOutcome
    {
        public Spock(string computer)
        {
            string final = "";
            if (computer.Equals("rock"))
                final = "Spock vaporizes rock - You Win";
            else if (computer.Equals("paper"))
                final = "Paper disproves Spock - You Lose";
            else if (computer.Equals("scissors"))
                final = "Spock smashes scissors - You Win";
            else if (computer.Equals("lizard"))
                final = "Lizard poisons Spock - You Lose";
            else if (computer.Equals("spock"))
                final = "How boring a tie";

            setFinalsSaying(final);

        }
    }
    class Lizard : UserOutcome
    {
        public Lizard(string computer)
        {
            string final = "";
            if (computer.Equals("rock"))
                final = "Rock crushes lizard - You Lose";
            else if (computer.Equals("paper"))
                final = "Lizard eats paper - You Win";
            else if (computer.Equals("scissors"))
                final = "Scissors decapitates lizard - You Lose";
            else if (computer.Equals("lizard"))
                final = "How boring a tie";
            else if (computer.Equals("spock"))
                final = "Lizard poisons Spock - You Win";

            setFinalsSaying(final);

        }

    }

    class Paper : UserOutcome
    {
        public Paper(string computer)
        {
            string final = "";
            if (computer.Equals("rock"))
                final = "Paper covers rock - You Win";
            else if (computer.Equals("paper"))
                final = "How boring a tie";
            else if (computer.Equals("scissors"))
                final = "Scissors cuts paper - You Lose";
            else if (computer.Equals("lizard"))
                final = "Lizard eats paper - You Lose";
            else if (computer.Equals("spock"))
                final = "Paper disproves Spock - You Win";

            setFinalsSaying(final);

        }
    }

    class Rock : UserOutcome
{
        public Rock(string computer)
        {
            string final = "";
            if (computer.Equals("rock"))
                final = "How boring a tie";
            else if (computer.Equals("paper"))
                final = "Paper covers rock - You Lose";
            else if (computer.Equals("scissors"))
                final = "Rock crushes scissors - You Win";
            else if (computer.Equals("lizard"))
                final = "Rock crushes lizard - You Win";
            else if (computer.Equals("spock"))
                final = "Spock vaporizes rock - You Lose";

            setFinalsSaying(final);

        }
        
    }

    class Scissors : UserOutcome
    { 
        public Scissors(string computer)
        {
            string final = "";
            if (computer.Equals("rock"))
                final = "Rock crushes scissors - You Lose";
            else if (computer.Equals("paper"))
                final = "Scissors cuts paper - You Win";
            else if (computer.Equals("scissors"))
                final = "How boring a tie";
            else if (computer.Equals("lizard"))
                final = "Scissors decapitates lizard - You Win";
            else if (computer.Equals("spock"))
                final = "Spock smashes scissors - You Lose";

            setFinalsSaying(final);

        }
        
    }

    class Empty : UserOutcome
    {
        public Empty()
        {
            setFinalsSaying("");
        }
    }
}
