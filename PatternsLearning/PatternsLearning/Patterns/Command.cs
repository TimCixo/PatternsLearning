using System;
using System.Collections.Generic;

namespace PatternsLearning.Patterns
{
    public interface IAmogus
    {
        void TellAmogus();
    }

    public class Amogus : IAmogus
    {
        private ConsoleColor _color = ConsoleColor.Red;

        public Amogus(ConsoleColor color)
        {
            _color = color;
        }

        public void TellAmogus()
        {
            Console.ForegroundColor = _color;
            Console.WriteLine("Amogusgus");
            Console.ResetColor();
        }
    }

    public class AmogusCommand : IAmogus
    {
        public List<Amogus> Sugokus = new List<Amogus>();

        public void TellAmogus()
        {
            foreach (Amogus i in Sugokus)
            {
                i.TellAmogus();
            }
        }
    }
}
