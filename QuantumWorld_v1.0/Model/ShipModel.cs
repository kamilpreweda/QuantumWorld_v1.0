using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class ShipModel
    {
        public string Name { get; }
        public int Count { get; set; }
        public int HealthPoints { get; set; }
        public int AttackPower { get; set; }    
    }
}
