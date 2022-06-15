using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.Model
{
    public class PlayerModel
    {
        public string Name { get; private set; }

        // Resources
        public ResourceModel CarbonFiber { get; private set; }
        public ResourceModel QuantumGlass { get; private set; }
        public ResourceModel HiggsBoson { get; private set; }
        public ResourceModel SolarEnergy { get; private set; }

        public ResourceModel[] PlayerResources { get; private set; }

        // Resource multipliers

        public Dictionary<BuildingModel, int> Multipliers { get; private set; }

        // Buildings

        public BuildingModel CarbonFiberBuilding { get; private set; }
        public BuildingModel QuantumGlassBuilding { get; private set; }
        public BuildingModel HiggsBosonBuilding { get; private set; }
        public BuildingModel SolarEnergyBuilding { get; private set; }

        // Research

        public ResearchModel FasterBuildingsResearch { get; private set; }
        public ResearchModel MoreResourcesResearch { get; private set; }
        public ResearchModel FasterInnovationResearch { get; private set; }

        public ResearchModel UnlockShipsResearch { get; private set; }
        public ResearchModel FasterShipsResearch { get; private set; }

        // Setting 'starting cost' for each building

        public ResourceModel[] CarbonFiberBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 50),
            new ResourceModel("Quantum Glass", 20),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 5),
        };

        public ResourceModel[] QuantumGlassBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 75),
            new ResourceModel("Quantum Glass", 30),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 10),

        };

        public ResourceModel[] HiggsBosonBuilding_StartingCost =
       {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 50),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 15),
        };

        public ResourceModel[] SolarEnergyBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 75),
            new ResourceModel("Quantum Glass", 75),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        // Setting 'starting cost' for each research

        public ResourceModel[] FasterBuildingsResearch_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 100),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] MoreResourcesResearch_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 150),
            new ResourceModel("Quantum Glass", 150),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] FasterInnovationResearch_StartingCost =
       {
            new ResourceModel("Carbon Fiber", 200),
            new ResourceModel("Quantum Glass", 200),
            new ResourceModel("Higgs Boson", 100),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] UnlockShipsResearch_StartingCost =
     {
            new ResourceModel("Carbon Fiber", 250),
            new ResourceModel("Quantum Glass", 250),
            new ResourceModel("Higgs Boson", 150),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] FasterShipsResearch_StartingCost =
     {
            new ResourceModel("Carbon Fiber", 300),
            new ResourceModel("Quantum Glass", 300),
            new ResourceModel("Higgs Boson", 200),
            new ResourceModel("Solar Energy", 0),
        };

        // Initializing starting values for a new player

        public PlayerModel()
        {
            Name = "Kamil

            PlayerResources = new ResourceModel[]
            {
                new ResourceModel("Carbon Fiber", 500),
                new ResourceModel("Quantum Glass", 500),
                new ResourceModel("Higgs Boson", 0),
                new ResourceModel("Solar Energy", 0),
            };
            Multipliers = new Dictionary<BuildingModel, int>();
            Multipliers.Add(CarbonFiberBuilding, 3);
            Multipliers.Add(QuantumGlassBuilding, 2);
            Multipliers.Add(HiggsBosonBuilding, 1);

            CarbonFiberBuilding = new BuildingModel("Carbon Fiber Building", CarbonFiberBuilding_StartingCost, 0);
            QuantumGlassBuilding = new BuildingModel("Quantum Glass Building", QuantumGlassBuilding_StartingCost, 0);
            HiggsBosonBuilding = new BuildingModel("Higgs Boson Building", HiggsBosonBuilding_StartingCost, 0);
            SolarEnergyBuilding = new BuildingModel("Solar Energy Building", SolarEnergyBuilding_StartingCost, 0);

            FasterBuildingsResearch = new ResearchModel("Faster Buildings", FasterBuildingsResearch_StartingCost, 0);
            MoreResourcesResearch = new ResearchModel("More Resources", MoreResourcesResearch_StartingCost, 0);
            FasterInnovationResearch = new ResearchModel("Faster Innovation", FasterInnovationResearch_StartingCost, 0);
            UnlockShipsResearch = new ResearchModel("Unlock Ships", UnlockShipsResearch_StartingCost, 0);
            FasterShipsResearch = new ResearchModel("Faster Ships", FasterShipsResearch_StartingCost, 0);
        }
            public void upgradeBuilding(BuildingModel building)
            {
                for (int i = 0; i < PlayerResources.Length; i++)
                {
                    this.PlayerResources[i].SubtractFromResources(building.Cost[i].Value);
                    building.SetNewCost(i, Multipliers[building]);
                }
                building.IncreaseLevel();
                Multipliers[CarbonFiberBuilding]++;
            }

        public bool canUpgradeBuilding(BuildingModel building)
        {
            for (int i = 0; i < PlayerResources.Length; i++)
            {
                if (this.PlayerResources[i].Value < building.Cost[i].Value) { return false; }
            }
            return true;
        }

        public void StableResourceIncome()
        {
            this.PlayerResources[0].AddTo(this.Multipliers[CarbonFiberBuilding]);
            this.PlayerResources[1].AddTo(this.Multipliers[QuantumGlassBuilding]);
            this.PlayerResources[2].AddTo(this.Multipliers[HiggsBosonBuilding]);
            this.PlayerResources[3].AddTo(this.Multipliers[SolarEnergyBuilding]);
        }



        }


    }

