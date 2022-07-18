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
        public int TimeToBuild { get; private set; }
        public int NewTime { get; set; } = 0;
        public int TimeMultiplier { get { return 2; } }
        public float CarbonFiberCostMultiplier { get; private set; }
        public float QuantumGlassCostMultiplier { get; private set; }
        public float HiggsBosonCostMultiplier { get; private set; }               
        public ResourceModel[] Cost { get; private set; }
        public BuildingModel(string name, ResourceModel[] cost, int level, int timeToBuild)
        {
            Name = name;
            Cost = cost;
            Level = level;
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
        public void SetBuilding(BuildingModel building)
        {
            this.Name = building.Name;
            this.Cost = building.Cost;
            this.Level = building.Level;
            this.TimeToBuild = building.TimeToBuild;            
        }
        public void SetNewTime(int naniteFactoryLevel)
        {
            this.TimeToBuild = (this.Level + 1) * TimeMultiplier;
            if (naniteFactoryLevel > 0)
            {
                this.TimeToBuild /= (naniteFactoryLevel + 1);
            }
            if (this.TimeToBuild < 1)
            {
                this.TimeToBuild = 0;
            }
        }
        public void CutTimeToBuildByHalf()
        {
            this.TimeToBuild /= 2;
            if (this.TimeToBuild < 1)
            {
                this.TimeToBuild = 0;
            }
        }     
        public void ResetTimer(int time)
        {
            this.TimeToBuild = time;
        }     
        public void DecreaseTimer()
        {
            TimeToBuild--;
        }
        public int GetLevel() {
            return this.Level;
        }       
        public float GetLabolatoryMultiplier(int labolatoryLevel)
        {
            if (labolatoryLevel > 0)
            {
                float result = (float)labolatoryLevel;
                return result;
            }
            else return 1;
        }      
    }
}
