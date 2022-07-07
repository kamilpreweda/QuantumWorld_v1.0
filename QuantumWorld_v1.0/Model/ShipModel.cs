using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class ShipModel
    {
        public string Name { get; private set; }
        public int TimeToBuild { get; private set; }
        public int Count { get; private set; }
        public int HealthPoints { get; private set; }
        public int AttackPower { get; private set; }
        public ResourceModel[] Cost { get; private set; }
        public int NewTime { get; set; } = 0;

        public ShipModel(string name, int count, int healthPoints, int attackPower, int timeToBuild, ResourceModel[] cost)
        {
            this.Name = name;
            this.Count = count;
            this.HealthPoints = healthPoints;
            this.AttackPower = attackPower;
            this.TimeToBuild = timeToBuild;
            this.Cost = cost;
        }

        public void SetShip(ShipModel ship)
        {
            this.Name = ship.Name;
            this.TimeToBuild = ship.TimeToBuild;
            this.Count = ship.Count;
            this.HealthPoints = ship.HealthPoints;
            this.AttackPower = ship.AttackPower;
            this.Cost = ship.Cost;
        }

        public void IncreaseCount()
        {
            Count++;
        }
        public void ResetTimer(int time)
        {
            this.TimeToBuild = time;
        }
        public void DecreaseTimer()
        {
            TimeToBuild--;
        }         
    }




}
