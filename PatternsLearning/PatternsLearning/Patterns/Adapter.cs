using System;

namespace PatternsLearning.Patterns
{
    public interface IMakeSound
    {
        void MakeSound();
    }

    public class Worm
    {
        protected readonly string Sound = "AAAAAAAAH";
    }

    public class ScreamingWorm : Worm, IMakeSound
    {
        public void MakeSound()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Sound);
            Console.ResetColor();
        }
    }
}
