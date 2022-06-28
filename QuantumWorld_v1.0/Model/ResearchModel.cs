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

        public int TimeToBuild { get; set; }
        public float CarbonFiberCostMultiplier { get; private set; }
        public float QuantumGlassCostMultiplier { get; private set; }
        public float HiggsBosonCostMultiplier { get; private set; }

        public ResourceModel[] Cost { get; private set; }

        public ResearchModel(string name, ResourceModel[] cost, int level, int timeToBuild)
        {
            Name = name;
           
            Level = level;
            Cost = cost;
            TimeToBuild = timeToBuild;
        }

        public void SetNewCost(int index, float multiplier)
        {

            Cost[index].MultiplyBy(multiplier);
        }

        public void IncreaseLevel()
        {
            Level++;
        }

        public void SetResearch(ResearchModel research)
        {
            this.Name = research.Name;
            this.Cost = research.Cost;
            this.Level = research.Level;
            this.TimeToBuild = research.TimeToBuild;
        }
        public void SetNewTime()
        {
            this.TimeToBuild = (this.TimeToBuild + (this.Level + 1) * 2);
        }
    }
}
