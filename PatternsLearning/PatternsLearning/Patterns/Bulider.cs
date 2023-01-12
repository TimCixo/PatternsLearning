using System;

namespace PatternsLearning.Patterns
{
    public class Sword
    {
        private bool _hasBlade = false;
        private bool _hasGuard = false;
        private bool _hasHandle = false;

        private double _bladeLength = 0;
        private double _bladeWidth = 0;

        private double _guardDiameterA = 0;
        private double _guardDiameterB = 0;

        private double _handleLength = 0;
        private double _handleDiameter = 0;

        private string _name = "sword";

        public string Name => _name;

        public string GetInfo()
        {
            string info = $"Name: {_name}\n";

            if (_hasBlade)
            {
                info += $"Blade length: {_bladeLength}\nBlade width: {_bladeWidth}\n";
            }
            else
            {
                info += "Hasn't a blade\n";
            }

            if (_hasGuard)
            {
                info += $"Guard diameter A: {_guardDiameterA}\nGuard diameter B: {_guardDiameterB}\n";
            }
            else
            {
                info += "Hasn't a guard\n";
            }

            if (_hasHandle)
            {
                info += $"Handle length: {_handleLength}\nHandle diameter: {_handleDiameter}";
            }
            else
            {
                info += "Hasn't a handle";
            }

            return info;
        }

        public bool TryAddBlade(double length, double width)
        {
            if (length > 0 && width > 0)
            {
                _bladeLength = length;
                _bladeWidth = width;

                _hasBlade = true;
            }

            return _hasBlade;
        }

        public bool TryAddGuard(double diameterA, double diameterB)
        {
            if (diameterA > 0 && diameterB > 0)
            {
                _guardDiameterA = diameterA;
                _guardDiameterB = diameterB;

                _hasGuard = true;
            }

            return _hasGuard;
        }

        public bool TryAddHandle(double length, double diameter)
        {
            if (length > 0 && diameter > 0)
            {
                _handleLength = length;
                _handleDiameter = diameter;

                _hasHandle = true;
            }

            return _hasHandle;
        }

        public void SetName(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException("Incorrect name");
            }
            else
            {
                _name = name;
            }
        }
    }

    public static class Bulider
    {
        private static Sword _sword = new Sword();

        public static void AddBlade(double length, double width)
        {
            if (_sword.TryAddBlade(length, width))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Blade has been added.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sowwy but blade hasn't been added.");
            }
            Console.ResetColor();
        }

        public static void AddGuard(double diameterA, double diameterB)
        {
            if (_sword.TryAddGuard(diameterA, diameterB))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Guard has been added.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sowwy but guard hasn't been added.");
            }
            Console.ResetColor();
        }

        public static void AddHandle(double length, double diameter)
        {
            if (_sword.TryAddHandle(length, diameter))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Handle has been added.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sowwy but handle hasn't been added.");
            }
            Console.ResetColor();
        }

        public static void SetName(string name)
        {
            try
            {
                _sword.SetName(name);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Name has been set.");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            Console.ResetColor();
        }

        public static Sword GetSword()
        {
            return _sword;
        }
    }
}
