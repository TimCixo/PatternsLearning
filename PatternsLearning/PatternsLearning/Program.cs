using PatternsLearning.Patterns;
using System;

namespace PatternsLearning
{
    internal class Program
    {
        private static void FactoryMethodExample()
        {
            IMonster slime = FactoryMethod.GetMonster(MonsterTypes.Slime);

            Console.WriteLine("=========Factory method=========");

            Console.Write("Monster makes a sound: ");
            slime.MakeSound();
        }

        private static void AbstractFactoryExample()
        {
            IResourceFactory cryoFactory = AbstractFactory.GetFactory(FactoryTypes.Cryo);

            Console.WriteLine("=========Abstract factory=========");

            Console.WriteLine("This factory makes stone and wood");
            Console.Write($"Stone description: {cryoFactory.GetStone().GetDescription()}\n");
            Console.Write($"Wood description: {cryoFactory.GetWood().GetDescription()}\n");
        }

        private static void BuilderExample()
        {
            Sword sword;

            Console.WriteLine("=========Builder/almost Singleton=========");
            Bulider.SetName(null);
            Bulider.AddBlade(60.6, 1);
            Bulider.AddGuard(-3, 1);
            Bulider.AddHandle(30, 3);
            Bulider.SetName("Almost a katana");

            sword = Bulider.GetSword();

            Console.WriteLine(sword.GetInfo());
        }

        private static void PrototypeExample()
        {
            Prototype prototype = new Prototype(0, "zero");
            Prototype prototypeClone = (Prototype)prototype.Clone();

            Console.WriteLine("=========Prototype=========");

            Console.WriteLine($"Prototype:\n{prototype.GetInfo()}\n\nPrototype clone:\n{prototypeClone.GetInfo()}");
        }

        private static void AdapterExample()
        {
            IMakeSound screamingWorm = new ScreamingWorm();

            Console.WriteLine("=========Adapter=========");

            screamingWorm.MakeSound();
        }

        private static void BridgeExample()
        {
            Car car = new Car();
            Bridge bridge = new Bridge(car);

            Console.WriteLine("=========Bridge=========");

            bridge.PowerButton();

            bridge.UpButton();
            bridge.LeftButton();

            bridge.PowerButton();
        }

        private static void CommandExample()
        {
            AmogusCommand command = new AmogusCommand();

            Console.WriteLine("=========Command=========");

            for (int i = 1; i <= 15; i++)
            {
                command.Sugokus.Add(new Amogus((ConsoleColor)i));
            }

            command.TellAmogus();
        }

        private static void Main(string[] args)
        {
            FactoryMethodExample();
            Console.WriteLine();

            AbstractFactoryExample();
            Console.WriteLine();

            BuilderExample();
            Console.WriteLine();

            PrototypeExample();
            Console.WriteLine();

            AdapterExample();
            Console.WriteLine();

            BridgeExample();
            Console.WriteLine();

            CommandExample();

            Console.Read();
        }
    }
}
