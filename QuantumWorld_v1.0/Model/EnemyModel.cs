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
        public int TimeToAttack { get; set; }
        public int NewTime { get; set; } = 0;
        public float CarbonFiberReward{ get; set; }
        public float QuantumGlassReward { get; set; }
        public float HiggsBosonReward { get; set; }

        public int TheExpanseLevelRequirement { get; private set; }
        public int ArtOfWarLevelRequirement { get; private set; }
        public int HyperdriveLevelRequirement { get; private set; }

        public int LightFighterCount { get; set; }
        public int HeavyFighterCount { get; set; }
        public int BattleshipCount { get; set; }
        public int DestroyerCount { get; set; }
        public int DreadnoughtCount { get; set; }
        public int MothershipCount { get; set; }


        public EnemyModel(string name, float carbonFiberReward, float quantumGlassReward, float higgsBosonReward, int timeToAttack, int theExpanseLevelRequirement, int artOfWarLevelRequirement, int hyperdriveLevelRequirement, int lightFighterCount, int heavyFighterCount, int battleshipCount, int destroyerCount, int dreadnoughtCount, int mothershipCount)
        {
            this.Name = name;
            this.CarbonFiberReward = carbonFiberReward;
            this.QuantumGlassReward = quantumGlassReward;
            this.HiggsBosonReward = higgsBosonReward;
            this.TimeToAttack = timeToAttack;
            this.TheExpanseLevelRequirement = theExpanseLevelRequirement;
            this.ArtOfWarLevelRequirement = artOfWarLevelRequirement;
            this.HyperdriveLevelRequirement = hyperdriveLevelRequirement;
            this.LightFighterCount = lightFighterCount;
            this.HeavyFighterCount = heavyFighterCount;
            this.BattleshipCount = battleshipCount;
            this.DestroyerCount = destroyerCount;
            this.DreadnoughtCount = dreadnoughtCount;
            this.MothershipCount = mothershipCount;
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
