using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class ResourceModel
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        public ResourceModel(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}
