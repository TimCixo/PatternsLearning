using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLearning.Patterns
{
    public interface IDoppelganger
    {
        IDoppelganger Clone();
    }

    public class Prototype : IDoppelganger
    {
        private int _id = 0;
        private int _cloneCount = 0;
        private string _name = "prototype";

        public int CloneCount => _cloneCount;

        public Prototype(int id, string name)
        {
            _id = id;
            _name = name;
        }

        private Prototype(Prototype prototype)
        {
            _id = prototype._id;
            _name = prototype._name;
        }

        public string GetInfo()
        {
            return $"Id: {_id}\nName: {_name}\nCloned {_cloneCount} times";
        }

        public IDoppelganger Clone()
        {
            _cloneCount++;
            return new Prototype(this);
        }
    }
}
