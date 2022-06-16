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
        public int Value { get; set; } // private set?

        public ResourceModel(string name, int value)
        {
            Name = name;
            Value = value;
        }

        /// <summary>
        /// This method calculates new values for resources used to upgrade building
        /// </summary>
        /// <param name="value">Cost that we need to subtract from Resources</param>
        public void SubtractFromResources(int value)
        {
            Value -= value;
        }
        
        public void MultiplyBy(int multiplier)
        {
            Value *= multiplier;
        }

        public void AddTo(int value)
        {
            Value += value;
        }
    }
}
