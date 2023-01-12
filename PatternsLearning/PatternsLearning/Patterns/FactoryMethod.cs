using System;

namespace PatternsLearning.Patterns
{
    public enum MonsterTypes
    {
        Slime = 0,
        Zombie = 1,
        Skeleton = 2
    }

    public interface IMonster
    {
        void MakeSound();
    }

    public class Slime : IMonster
    {
        public void MakeSound()
        {
            Console.WriteLine("*Plop*");
        }
    }

    public class Zombie : IMonster
    {
        public void MakeSound()
        {
            Console.WriteLine("*Growl*");
        }
    }

    public class Skeleton : IMonster
    {
        public void MakeSound()
        {
            Console.WriteLine("*Rattle*");
        }
    }

    public static class FactoryMethod
    {
        public static IMonster GetMonster(MonsterTypes monster)
        {
            if (monster == MonsterTypes.Slime)
            {
                return new Slime();
            }
            else if (monster == MonsterTypes.Zombie)
            {
                return new Zombie();
            }
            else if (monster == MonsterTypes.Skeleton)
            {
                return new Skeleton();
            }
            else
            {
                throw new Exception("Out of range");
            }
        }
    }
}
