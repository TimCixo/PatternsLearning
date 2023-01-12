using System;

namespace PatternsLearning.Patterns
{
    public enum FactoryTypes
    {
        Pyro = 0,
        Cryo = 1,
        Common = 2
    }

    public interface IResource
    {
        string GetDescription();
    }

    public interface IStone : IResource
    {
    }

    public class PyroStone : IStone
    {
        public string GetDescription()
        {
            return "Kinda a burning stone.";
        }
    }

    public class CryoStone : IStone
    {
        public string GetDescription()
        {
            return "It's just an ice. Isn't it?";
        }
    }

    public class Stone : IStone
    {
        public string GetDescription()
        {
            return "Just a stone.";
        }
    }

    public interface IWood : IResource
    {
    }

    public class PyroWood : IWood
    {
        public string GetDescription()
        {
            return "Why hasn't it turned to ashes yet?";
        }
    }

    public class CryoWood : IWood
    {
        public string GetDescription()
        {
            return "S-s-slippery!";
        }
    }

    public class Wood : IWood
    {
        public string GetDescription()
        {
            return "Just a wood.";
        }
    }

    public interface IResourceFactory
    {
        IStone GetStone();
        IWood GetWood();
    }

    public class PyroFactory : IResourceFactory
    {
        public IStone GetStone()
        {
            return new PyroStone();
        }

        public IWood GetWood()
        {
            return new PyroWood();
        }
    }
    public class CryoFactory : IResourceFactory
    {
        public IStone GetStone()
        {
            return new CryoStone();
        }

        public IWood GetWood()
        {
            return new CryoWood();
        }
    }
    public class CommonFactory : IResourceFactory
    {
        public IStone GetStone()
        {
            return new Stone();
        }

        public IWood GetWood()
        {
            return new Wood();
        }
    }

    public static class AbstractFactory
    {
        public static IResourceFactory GetFactory(FactoryTypes factory)
        {
            if (factory == FactoryTypes.Pyro)
            {
                return new PyroFactory();
            }
            else if (factory == FactoryTypes.Cryo)
            {
                return new CryoFactory();
            }
            else if (factory == FactoryTypes.Common)
            {
                return new CommonFactory();
            }
            else
            {
                throw new Exception("Out of range");
            }
        }
    }
}
