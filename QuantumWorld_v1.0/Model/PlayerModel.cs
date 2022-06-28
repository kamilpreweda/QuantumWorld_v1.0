using QuantumWorld_v1._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace QuantumWorld_v1._0.Model
{
    public class PlayerModel
    {
        public string Name { get; set; }

        DispatcherTimer buildingTimer = new DispatcherTimer();




        // Resources
        public ResourceModel CarbonFiber { get; private set; }
        public ResourceModel QuantumGlass { get; private set; }
        public ResourceModel HiggsBoson { get; private set; }
        public ResourceModel SolarEnergy { get; private set; }

        public ResourceModel[] PlayerResources { get; private set; }

        // Resource multipliers

        public Dictionary<BuildingModel, float> Multipliers { get; private set; }

        public Dictionary<BuildingModel, float> CostMultipliers { get; private set; }

        public Dictionary<ResearchModel, float> ResearchMultipliers { get; private set; }

        // Buildings

        public BuildingModel CarbonFiberBuilding { get; private set; }
        public BuildingModel QuantumGlassBuilding { get; private set; }
        public BuildingModel HiggsBosonBuilding { get; private set; }
        public BuildingModel SolarEnergyBuilding { get; private set; }

        public BuildingModel Labolatory { get; private set; }

        // Research

        public ResearchModel AIRobotsResearch { get; private set; }
        public ResearchModel MoreResourcesResearch { get; private set; }
        public ResearchModel FasterInnovationResearch { get; private set; }

        public ResearchModel UnlockShipsResearch { get; private set; }
        public ResearchModel FasterShipsResearch { get; private set; }

        public BuildingModel CarbonFiberCostMultiplier { get; private set; }
        public BuildingModel QuantumGlasCostMultiplier { get; private set; }
        public BuildingModel HiggsBosonCostMultiplier { get; private set; }

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

        public ResourceModel[] Labolatory_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 500),
            new ResourceModel("Quantum Glass", 500),
            new ResourceModel("Higgs Boson", 250),
            new ResourceModel("Solar Energy", 0),
        };
        // Setting 'starting cost' for each research

        public ResourceModel[] AIRobotsResearch_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 50),
            new ResourceModel("Quantum Glass", 40),
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
            Name = "Kamil";






            PlayerResources = new ResourceModel[]
            {
                new ResourceModel("Carbon Fiber", 500),
                new ResourceModel("Quantum Glass", 500),
                new ResourceModel("Higgs Boson", 0),
                new ResourceModel("Solar Energy", 0),
            };

            CarbonFiberBuilding = new BuildingModel("CarbonFiberBuilding", CarbonFiberBuilding_StartingCost, 0, 2);
            QuantumGlassBuilding = new BuildingModel("QuantumGlassBuilding", QuantumGlassBuilding_StartingCost, 0, 3);
            HiggsBosonBuilding = new BuildingModel("HiggsBosonBuilding", HiggsBosonBuilding_StartingCost, 0, 4);
            SolarEnergyBuilding = new BuildingModel("SolarEnergyBuilding", SolarEnergyBuilding_StartingCost, 0, 5);
            Labolatory = new BuildingModel("Labolatory", Labolatory_StartingCost, 0, 10);


            Multipliers = new Dictionary<BuildingModel, float>();
            Multipliers.Add(CarbonFiberBuilding, 2);
            Multipliers.Add(QuantumGlassBuilding, 1);
            Multipliers.Add(HiggsBosonBuilding, 0);
            Multipliers.Add(SolarEnergyBuilding, 1.1F);


            CostMultipliers = new Dictionary<BuildingModel, float>();
            CostMultipliers.Add(CarbonFiberBuilding, 1.5F);
            CostMultipliers.Add(QuantumGlassBuilding, 1.6F);
            CostMultipliers.Add(HiggsBosonBuilding, 1.7F);
            CostMultipliers.Add(SolarEnergyBuilding, 2F);
            CostMultipliers.Add(Labolatory, 2F);


            AIRobotsResearch = new ResearchModel("AIRobotsResearch", AIRobotsResearch_StartingCost, 0, 1);
            MoreResourcesResearch = new ResearchModel("More Resources", MoreResourcesResearch_StartingCost, 0, 20);
            FasterInnovationResearch = new ResearchModel("Faster Innovation", FasterInnovationResearch_StartingCost, 0, 30);
            UnlockShipsResearch = new ResearchModel("Unlock Ships", UnlockShipsResearch_StartingCost, 0, 40);
            FasterShipsResearch = new ResearchModel("Faster Ships", FasterShipsResearch_StartingCost, 0, 50);


            ResearchMultipliers = new Dictionary<ResearchModel, float>();
            ResearchMultipliers.Add(AIRobotsResearch, 2F);
        }



        public void upgradeBuilding(BuildingModel building)
        {


            for (int i = 0; i < PlayerResources.Length; i++)
            {

                this.PlayerResources[i].SubtractFromResources(building.Cost[i].Value);

                if (building == CarbonFiberBuilding)
                {
                    building.SetNewCost(i, CostMultipliers[CarbonFiberBuilding]);
                }
                else if (building == QuantumGlassBuilding)
                {
                    building.SetNewCost(i, CostMultipliers[QuantumGlassBuilding]);
                }
                else if (building == HiggsBosonBuilding)
                {
                    building.SetNewCost(i, CostMultipliers[HiggsBosonBuilding]);
                }
                else if (building == SolarEnergyBuilding)
                {
                    building.SetNewCost(i, CostMultipliers[SolarEnergyBuilding]);
                }
                else if (building == Labolatory)
                {
                    building.SetNewCost(i, CostMultipliers[Labolatory]);
                }


            }
            building.IncreaseLevel();
            building.SetNewTime();
            if (building == CarbonFiberBuilding)
            {
                Multipliers[CarbonFiberBuilding] += 5;
            }
            else if (building == QuantumGlassBuilding)
            {
                Multipliers[QuantumGlassBuilding] += 4;
            }
            else if (building == HiggsBosonBuilding)
            {
                Multipliers[HiggsBosonBuilding] += 3;
            }
            else if (building == SolarEnergyBuilding)
            {
                // PlayerResources[3] means Solar Energy resource value
                PlayerResources[3].AddEnergy(Multipliers[SolarEnergyBuilding]);
                Multipliers[SolarEnergyBuilding] += 0.1F;
            }
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

        }

        public void upgradeResearch(ResearchModel research)
        {
            for (int i = 0; i < PlayerResources.Length; i++)
            {

                this.PlayerResources[i].SubtractFromResources(research.Cost[i].Value);

                if (research == AIRobotsResearch)
                {
                    research.SetNewCost(i, ResearchMultipliers[AIRobotsResearch]);
                }
            }
            research.IncreaseLevel();
            research.SetNewTime();

        }

        public bool canUpgradeResearch(ResearchModel research)
        {

            for (int i = 0; i < PlayerResources.Length; i++)
            {
                if (this.PlayerResources[i].Value < research.Cost[i].Value) { return false; }
            }
            return true;


        }
    }
}

