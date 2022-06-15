using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class ResearchModel
    {
        public string Name { get; private set; }
       
        public int Level { get; private set; }

        public ResourceModel[] Cost { get; private set; }

        public ResearchModel(string name, ResourceModel[] cost, int level)
        {
            Name = name;
           
            Level = level;
            Cost = cost;
        }
    }
}
