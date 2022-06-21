using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class BuildingModel
    {
        public int Level { get; private set; }
        public string Name { get; private set; }

        public float CarbonFiberCostMultiplier { get; private set; }
        public float QuantumGlassCostMultiplier { get; private set; }
        public float HiggsBosonCostMultiplier { get; private set; }
 

        public ResourceModel[] Cost { get; private set; }

        public BuildingModel(string name, ResourceModel[] cost, int level)
        {
            Name = name;
            Cost = cost;
            Level = level;
        }

        public void SetNewCost(int index, float multiplier)
        {
            
            Cost[index].MultiplyBy(multiplier);
        }


        public void IncreaseLevel()
        {
            Level++;
        }
        
        public void SetBuilding(BuildingModel building)
{
    this.Name = building.Name;
    this.Cost = building.Cost;
    this.Level = building.Level;
}
}
}
