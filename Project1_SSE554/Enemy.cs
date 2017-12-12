using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_SSE554
{
    class Enemy
    {
    }

    public interface enemyStats
    {
        int punch();
        int health();
        int healthleft(int health, int damage);
    }

    public class Zombie : enemyStats
    {
        Random randomGenerator = new Random();

        public int health()
        {
            return randomGenerator.Next(1, 11);
        }

        public int healthleft(int health, int damage)
        {
            return health - damage;
        }

        public int punch()
        {
            return randomGenerator.Next(1, 11);
        }
    }

    public class Golem : enemyStats
    {
        Random randomGenerator = new Random();

        public int health()
        {
            return randomGenerator.Next(1, 51);
        }

        public int healthleft(int health, int damage)
        {
            return health - damage;
        }

        public int punch()
        {
            return randomGenerator.Next(1, 11);
        }
    }

    public class Skeleton
    {
        Random randomGenerator = new Random();

        public int respawnTime()
        {
            return randomGenerator.Next(5, 11);
        }

        public int respawnTimeLeft(int time)
        {
            return time-1;
        }

        public int shoots()
        {
            return randomGenerator.Next(1, 11);
        }
    }

    public class SkeletonAdapter : enemyStats
    {
        Skeleton skeleton;

        public SkeletonAdapter(Skeleton newSkeleton)
        {
            skeleton = newSkeleton;
        }

        public int health()
        {
            return skeleton.respawnTime();
        }

        public int healthleft(int health, int damage)
        {
            return skeleton.respawnTimeLeft(health);
        }

        public int punch()
        {
            return skeleton.shoots();
        }
    }

}
