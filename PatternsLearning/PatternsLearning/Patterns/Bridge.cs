using System;

namespace PatternsLearning.Patterns
{
    internal class NotEnoughtConsole
    {
        public static void WriteColoredLine(string value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }

    }

    public class Car
    {
        private bool _turned = false;

        public bool Turned => _turned;

        public void MoveForward()
        {
            NotEnoughtConsole.WriteColoredLine("Move forward", ConsoleColor.Cyan);
        }

        public void MoveBackward()
        {
            NotEnoughtConsole.WriteColoredLine("Move backward", ConsoleColor.Cyan);
        }

        public void TurnRight()
        {
            NotEnoughtConsole.WriteColoredLine("Turn right", ConsoleColor.Cyan);
        }

        public void TurnLeft()
        {
            NotEnoughtConsole.WriteColoredLine("Turn left", ConsoleColor.Cyan);
        }

        public void TurnOn()
        {
            if (_turned)
            {
                throw new Exception("Already turned on");
            }
            else
            {
                NotEnoughtConsole.WriteColoredLine("Turn on", ConsoleColor.Green);

                _turned = true;
            }
        }

        public void TurnOff()
        {
            if (_turned)
            {
                NotEnoughtConsole.WriteColoredLine("Turn off", ConsoleColor.Red);

                _turned = false;
            }
            else
            {
                throw new Exception("Already turned off");
            }
        }
    }

    public class Bridge
    {
        private Car _car;

        public Bridge(Car car)
        {
            _car = car;
        }

        public void UpButton()
        {
            _car.MoveForward();
        }

        public void DownButton()
        {
            _car.MoveBackward();
        }

        public void LeftButton()
        {
            _car.TurnLeft();
        }

        public void RightButton()
        {
            _car.TurnRight();
        }

        public void PowerButton()
        {
            if (_car.Turned)
            {
                _car.TurnOff();
            }
            else
            {
                _car.TurnOn();
            }
        }
    }
}
