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
        public float TimeToBuild { get; private set; }
        public int NewTime { get; set; } = 0;
        public float CarbonFiberCostMultiplier { get; private set; }
        public float QuantumGlassCostMultiplier { get; private set; }
        public float HiggsBosonCostMultiplier { get; private set; }               
        public ResourceModel[] Cost { get; private set; }
        public BuildingModel(string name, ResourceModel[] cost, int level, float timeToBuild)
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
        public void SetNewTime(int aiRobotsMultiplier, float naniteFactoryMultiplier, int naniteFactoryLevel)
        {
            naniteFactoryMultiplier = GetNaniteFactoryMultiplier(naniteFactoryLevel);
            this.TimeToBuild = (this.Level / (aiRobotsMultiplier + 1) / naniteFactoryMultiplier);                   
            if (this.TimeToBuild < 1)
            {
                TimeToBuild = 0;
            }            
        }
        public void CutTimeToBuildByHalf(BuildingModel building)
        {
            building.TimeToBuild /= 2;
            if (building.TimeToBuild < 0)
            {
                TimeToBuild = 0;
            }
        }        
        public void ConvertTimeToBuildToInt(BuildingModel building)
        {            
            building.TimeToBuild = (int)building.TimeToBuild;
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
        // just level * level?
        public float GetNaniteFactoryMultiplier(int naniteFactoryLevel)
        {
            float naniteFactoryLevelFloat = naniteFactoryLevel;

            if (naniteFactoryLevelFloat > 0)
            {
                float result = (((naniteFactoryLevelFloat / 2) / naniteFactoryLevelFloat) * 4) * naniteFactoryLevelFloat;

                return result;
            }
            else return 1;        
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
