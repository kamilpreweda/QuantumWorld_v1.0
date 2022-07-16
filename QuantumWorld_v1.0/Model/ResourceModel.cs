using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class ResourceModel
    {
        public string Name { get;  set; }
        public float Value { get;  set; }

        public float Cap { get;  set; }

        public ResourceModel(string name, float value)
        {
            Name = name;
            Value = value;
        }

        public ResourceModel(string name, float value, float cap)
        {
            Name = name;
            Value = value;
            Cap = cap;
        }

        public void SetValue(float value)
        {
            this.Value = value;
        }

        public void SetCap(float cap)
        {
            this.Cap = cap;
        }

        public void SubtractFromResources(float value)
        {
            Value -= value;
        }
        
        public void MultiplyBy(float multiplier)
        {
            Value *= multiplier;
        }

        public void AddTo(float value)
        {
            Value += value;
        }

        public void AddEnergy(float multiplier)
        {
            Value += (100 * multiplier);
            
        }

    }
}
