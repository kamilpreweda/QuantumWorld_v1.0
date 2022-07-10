using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class EnemyModel
    {
        public string Name { get; private set; }
        public int TimeToAttack { get; private set; }
        public int NewTime { get; set; } = 0;
        public float CarbonFiberReward{ get; set; }
        public float QuantumGlassReward { get; set; }
        public float HiggsBosonReward { get; set; }

        public int TheExpanseLevelRequirement { get; private set; }
        public int ArtOfWarLevelRequirement { get; private set; }
        public int HyperdriveLevelRequirement { get; private set; }


        public EnemyModel(string name, float carbonFiberReward, float quantumGlassReward, float higgsBosonReward, int timeToAttack, int theExpanseLevelRequirement, int artOfWarLevelRequirement, int hyperdriveLevelRequirement)
        {
            this.Name = name;
            this.CarbonFiberReward = carbonFiberReward;
            this.QuantumGlassReward = quantumGlassReward;
            this.HiggsBosonReward = higgsBosonReward;
            this.TimeToAttack = timeToAttack;
            this.TheExpanseLevelRequirement = theExpanseLevelRequirement;
            this.ArtOfWarLevelRequirement = artOfWarLevelRequirement;
            this.HyperdriveLevelRequirement = hyperdriveLevelRequirement;
        }
        public void SetEnemy(EnemyModel enemy)
        {
            this.Name = enemy.Name;
            this.CarbonFiberReward = enemy.CarbonFiberReward;
            this.QuantumGlassReward = enemy.QuantumGlassReward;
            this.HiggsBosonReward = enemy.HiggsBosonReward;
            this.TimeToAttack = enemy.TimeToAttack;
            this.TheExpanseLevelRequirement = enemy.TheExpanseLevelRequirement;
            this.ArtOfWarLevelRequirement = enemy.ArtOfWarLevelRequirement;
            this.HyperdriveLevelRequirement = enemy.HyperdriveLevelRequirement;
        }    
        public void CutTimeToAttackByHalf()
        {
            this.TimeToAttack /= 2;
            if (this.TimeToAttack < 0)
            {
                TimeToAttack = 0;
            }
        }

        public void ResetTimer(int time)
        {
            this.TimeToAttack = time;
        }

        public void DecreaseTimer()
        {
            TimeToAttack--;
        }
    }
}
