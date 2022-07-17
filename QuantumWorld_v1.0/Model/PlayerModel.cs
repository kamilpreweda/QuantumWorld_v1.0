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

        #region Properties
        public ResourceModel CarbonFiber { get; private set; }
        public ResourceModel QuantumGlass { get; private set; }
        public ResourceModel HiggsBoson { get; private set; }
        public ResourceModel SolarEnergy { get; private set; }
        public ResourceModel CarbonFiberCap { get; private set; }
        public ResourceModel QuantumGlassCap { get; private set; }
        public ResourceModel HiggsBosonCap { get; private set; }
        public ResourceModel[] PlayerResources { get; private set; }
        public Dictionary<BuildingModel, float> IncomeMultipliers { get; private set; }
        public Dictionary<BuildingModel, float> CostMultipliers { get; private set; }
        public Dictionary<ResearchModel, float> ResearchMultipliers { get; private set; }
        public List<BuildingModel> PlayerBuildings { get; set; }
        public List<ResearchModel> PlayerResearch { get; set; }
        public List<ShipModel> PlayerShips { get; set; }
        public List<ShipModel> PiratesShips { get; set; }
        public List<ShipModel> OutsidersShips { get; set; }
        public List<ShipModel> RebelsShips { get; set; }
        public List<ShipModel> ArmamentsShips { get; set; }
        public List<ShipModel> DistantsShips { get; set; }
        public List<ShipModel> AncientsShips { get; set; }
        public List<EnemyModel> Enemies { get; set; }
        public BuildingModel CarbonFiberBuilding { get; private set; }
        public BuildingModel QuantumGlassBuilding { get; private set; }
        public BuildingModel HiggsBosonBuilding { get; private set; }
        public BuildingModel SolarEnergyBuilding { get; private set; }
        public BuildingModel Labolatory { get; private set; }
        public BuildingModel CarbonFiberStorage { get; private set; }
        public BuildingModel QuantumGlassStorage { get; private set; }
        public BuildingModel HiggsBosonDetector { get; private set; }
        public BuildingModel SpaceshipFactory { get; private set; }
        public BuildingModel NaniteFactory { get; private set; }
        public ResearchModel AIRobotsResearch { get; private set; }
        public ResearchModel SpaceOrganizing { get; private set; }
        public ResearchModel TheExpanse { get; private set; }
        public ResearchModel ArtOfWar { get; private set; }
        public ResearchModel Hyperdrive { get; private set; }
        public BuildingModel CarbonFiberCostMultiplier { get; private set; }
        public BuildingModel QuantumGlasCostMultiplier { get; private set; }
        public BuildingModel HiggsBosonCostMultiplier { get; private set; }
        public ShipModel LightFighter { get; set; }
        public ShipModel HeavyFighter { get; set; }
        public ShipModel Battleship { get; set; }
        public ShipModel Destroyer { get; set; }
        public ShipModel Dreadnought { get; set; }
        public ShipModel Mothership { get; set; }
        public EnemyModel Pirates { get; set; }
        public ShipModel PiratesLightFighter { get; set; }
        public EnemyModel Outsiders { get; set; }
        public ShipModel OutsidersLightFighter { get; set; }
        public ShipModel OutsidersHeavyFighter { get; set; }
        public EnemyModel Rebels { get; set; }
        public ShipModel RebelsBattleship { get; set; }
        public ShipModel RebelsDestroyer { get; set; }
        public EnemyModel Armaments { get; set; }
        public ShipModel ArmamentsDestroyer { get; set; }
        public ShipModel ArmamentsDreadnought { get; set; }
        public EnemyModel Distants { get; set; }
        public ShipModel DistantsBattleship { get; set; }
        public ShipModel DistantsDestroyer { get; set; }
        public ShipModel DistantsDreadnought { get; set; }
        public EnemyModel Ancients { get; set; }
        public ShipModel AncientsDestroyer { get; set; }
        public ShipModel AncientsDreadnought { get; set; }
        public ShipModel AncientsMothership { get; set; }

        #endregion

        #region StartingCosts

        public ResourceModel[] CarbonFiberBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 50),
            new ResourceModel("Quantum Glass", 20),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 15),
        };

        public ResourceModel[] QuantumGlassBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 70),
            new ResourceModel("Quantum Glass", 30),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 30),
        };

        public ResourceModel[] HiggsBosonBuilding_StartingCost =
       {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 50),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 60),
        };

        public ResourceModel[] SolarEnergyBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 125),
            new ResourceModel("Quantum Glass", 125),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Labolatory_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 50),
            new ResourceModel("Quantum Glass", 50),
            new ResourceModel("Higgs Boson", 25),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] CarbonFiberStorage_StartingCost =
       {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 0),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };
        public ResourceModel[] QuantumGlassStorage_StartingCost =
    {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 50),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };
        public ResourceModel[] HiggsBosonDetector_StartingCost =
    {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 100),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };
        public ResourceModel[] SpaceshipFactory_StartingCost =
    {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 100),
            new ResourceModel("Higgs Boson", 100),
            new ResourceModel("Solar Energy", 0),
        };
        public ResourceModel[] NaniteFactory_StartingCost =
    {
            new ResourceModel("Carbon Fiber", 100),
            new ResourceModel("Quantum Glass", 100),
            new ResourceModel("Higgs Boson", 100),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] AIRobotsResearch_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 50),
            new ResourceModel("Quantum Glass", 40),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] SpaceOrganizing_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 150),
            new ResourceModel("Quantum Glass", 150),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] TheExpanse_StartingCost =
       {
            new ResourceModel("Carbon Fiber", 200),
            new ResourceModel("Quantum Glass", 200),
            new ResourceModel("Higgs Boson", 100),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] ArtOfWar_StartingCost =
     {
            new ResourceModel("Carbon Fiber", 250),
            new ResourceModel("Quantum Glass", 250),
            new ResourceModel("Higgs Boson", 150),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Hyperdrive_StartingCost =
     {
            new ResourceModel("Carbon Fiber", 300),
            new ResourceModel("Quantum Glass", 300),
            new ResourceModel("Higgs Boson", 200),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] LightFighter_Cost =
            {
            new ResourceModel("Carbon Fiber", 300),
            new ResourceModel("Quantum Glass", 100),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] HeavyFighter_Cost =
            {
            new ResourceModel("Carbon Fiber", 1000),
            new ResourceModel("Quantum Glass", 500),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Battleship_Cost =
            {
            new ResourceModel("Carbon Fiber", 2500),
            new ResourceModel("Quantum Glass", 2000),
            new ResourceModel("Higgs Boson", 500),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Destroyer_Cost =
           {
            new ResourceModel("Carbon Fiber", 5000),
            new ResourceModel("Quantum Glass", 4000),
            new ResourceModel("Higgs Boson", 1500),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Dreadnought_Cost =
           {
            new ResourceModel("Carbon Fiber", 8000),
            new ResourceModel("Quantum Glass", 5000),
            new ResourceModel("Higgs Boson", 2000),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Mothership_Cost =
           {
            new ResourceModel("Carbon Fiber", 50000),
            new ResourceModel("Quantum Glass", 50000),
            new ResourceModel("Higgs Boson", 10000),
            new ResourceModel("Solar Energy", 0),
        };

        #endregion

        public PlayerModel()
        {
            Name = "Kamil";

            #region Resources

            PlayerResources = new ResourceModel[]
            {
                CarbonFiber = new ResourceModel("CarbonFiber", 1000, 10000),
                QuantumGlass = new ResourceModel("QuantumGlass", 1000, 10000),
                HiggsBoson = new ResourceModel("HiggsBoson", 0, 10000),
                SolarEnergy= new ResourceModel("SolarEnergy", 0),
            };                                

            #endregion

            #region Buildings

            CarbonFiberBuilding = new BuildingModel("CarbonFiberBuilding", CarbonFiberBuilding_StartingCost, 0, 1);
            QuantumGlassBuilding = new BuildingModel("QuantumGlassBuilding", QuantumGlassBuilding_StartingCost, 0, 2);
            HiggsBosonBuilding = new BuildingModel("HiggsBosonBuilding", HiggsBosonBuilding_StartingCost, 0, 3);
            SolarEnergyBuilding = new BuildingModel("SolarEnergyBuilding", SolarEnergyBuilding_StartingCost, 0, 4);
            Labolatory = new BuildingModel("Labolatory", Labolatory_StartingCost, 0, 5);
            CarbonFiberStorage = new BuildingModel("CarbonFiberStorage", CarbonFiberStorage_StartingCost, 0, 6);
            QuantumGlassStorage = new BuildingModel("QuantumGlassStorage", QuantumGlassStorage_StartingCost, 0, 6);
            HiggsBosonDetector = new BuildingModel("HiggsBosonDetector", HiggsBosonDetector_StartingCost, 0, 6);
            SpaceshipFactory = new BuildingModel("SpaceshipFactory", SpaceshipFactory_StartingCost, 0, 7);
            NaniteFactory = new BuildingModel("NaniteFactory", NaniteFactory_StartingCost, 0, 8);

            PlayerBuildings = new List<BuildingModel>();
            PlayerBuildings.Add(CarbonFiberBuilding);
            PlayerBuildings.Add(QuantumGlassBuilding);
            PlayerBuildings.Add(HiggsBosonBuilding);
            PlayerBuildings.Add(SolarEnergyBuilding);
            PlayerBuildings.Add(Labolatory);
            PlayerBuildings.Add(CarbonFiberStorage);
            PlayerBuildings.Add(QuantumGlassStorage);
            PlayerBuildings.Add(HiggsBosonDetector);
            PlayerBuildings.Add(SpaceshipFactory);
            PlayerBuildings.Add(NaniteFactory);

            IncomeMultipliers = new Dictionary<BuildingModel, float>();
            IncomeMultipliers.Add(CarbonFiberBuilding, 20);
            IncomeMultipliers.Add(QuantumGlassBuilding, 15);
            IncomeMultipliers.Add(HiggsBosonBuilding, 0);
            IncomeMultipliers.Add(SolarEnergyBuilding, 2F);

            CostMultipliers = new Dictionary<BuildingModel, float>();
            CostMultipliers.Add(CarbonFiberBuilding, 1.11F);
            CostMultipliers.Add(QuantumGlassBuilding, 1.12F);
            CostMultipliers.Add(HiggsBosonBuilding, 1.13F);
            CostMultipliers.Add(SolarEnergyBuilding, 1.14F);
            CostMultipliers.Add(Labolatory, 1.2F);
            CostMultipliers.Add(CarbonFiberStorage, 1.2F);
            CostMultipliers.Add(QuantumGlassStorage, 1.2F);
            CostMultipliers.Add(HiggsBosonDetector, 1.2F);
            CostMultipliers.Add(SpaceshipFactory, 1.2F);
            CostMultipliers.Add(NaniteFactory, 1.2F);

            #endregion

            #region Research

            AIRobotsResearch = new ResearchModel("AIRobotsResearch", AIRobotsResearch_StartingCost, 0, 10, 2);
            SpaceOrganizing = new ResearchModel("SpaceOrganizing", SpaceOrganizing_StartingCost, 0, 20, 4);
            TheExpanse = new ResearchModel("TheExpanse", TheExpanse_StartingCost, 0, 30, 6);
            ArtOfWar = new ResearchModel("ArtOfWar", ArtOfWar_StartingCost, 0, 40, 8);
            Hyperdrive = new ResearchModel("Hyperdrive", Hyperdrive_StartingCost, 0, 50, 10);

            PlayerResearch = new List<ResearchModel>();

            PlayerResearch.Add(AIRobotsResearch);
            PlayerResearch.Add(SpaceOrganizing);
            PlayerResearch.Add(TheExpanse);
            PlayerResearch.Add(ArtOfWar);
            PlayerResearch.Add(Hyperdrive);

            ResearchMultipliers = new Dictionary<ResearchModel, float>();
            ResearchMultipliers.Add(AIRobotsResearch, 2F);
            ResearchMultipliers.Add(SpaceOrganizing, 2F);
            ResearchMultipliers.Add(TheExpanse, 2F);
            ResearchMultipliers.Add(ArtOfWar, 2F);
            ResearchMultipliers.Add(Hyperdrive, 2F);

            #endregion

            #region PlayerShips

            LightFighter = new ShipModel("LightFighter", 0, 20, 10, 1, LightFighter_Cost, 2);
            HeavyFighter = new ShipModel("HeavyFighter", 0, 50, 30, 2, HeavyFighter_Cost, 4);
            Battleship = new ShipModel("Battleship", 0, 100, 75, 3, Battleship_Cost, 6);
            Destroyer = new ShipModel("Destroyer", 0, 200, 300, 4, Destroyer_Cost, 8);
            Dreadnought = new ShipModel("Dreadnought", 0, 500, 250, 5, Dreadnought_Cost, 10);
            Mothership = new ShipModel("Mothership", 0, 50000, 50000, 6, Mothership_Cost, 12);

            PlayerShips = new List<ShipModel>();

            PlayerShips.Add(LightFighter);
            PlayerShips.Add(HeavyFighter);
            PlayerShips.Add(Battleship);
            PlayerShips.Add(Destroyer);
            PlayerShips.Add(Dreadnought);
            PlayerShips.Add(Mothership);

            #endregion

            #region Pirates

            Pirates = new EnemyModel("Pirates",
                                    // carbonFiberReward 
                                    5000,
                                    // quantumGlassReward
                                    5000,
                                    // higgsBosonReward
                                    0,
                                    // timeToAttack ( 0 FOR TESTS )
                                    10,
                                    // theExpanseLevelRequirement ( 0 FOR TESTS )
                                    2,
                                    // artOfWarLevelRequirement
                                    0,
                                    // hyperdriveLevelRequirement
                                    0,
                                    // lightFighterCount
                                    10,
                                    // heavtFighterCount
                                    0,
                                    // battleShipCount
                                    0,
                                    // destroyerCount
                                    0,
                                    // dreadnoughtCount
                                    0,
                                    //mothershipCount
                                    0);
            #endregion

            #region Outsiders

            Outsiders = new EnemyModel("Outsiders",
                                    // carbonFiberReward 
                                    15000,
                                    // quantumGlassReward
                                    15000,
                                    // higgsBosonReward
                                    0,
                                    // timeToAttack
                                    20,
                                    // theExpanseLevelRequirement
                                    4,
                                    // artOfWarLevelRequirement
                                    0,
                                    // hyperdriveLevelRequirement
                                    0,
                                    // lightFighterCount
                                    50,
                                    // heavyFighterCount
                                    25,
                                    // battleShipCount
                                    0,
                                    // destroyerCount
                                    0,
                                    // dreadnoughtCount
                                    0,
                                    //mothershipCount
                                    0);
            #endregion

            #region Rebels

            Rebels = new EnemyModel("Rebels",
                                    // carbonFiberReward 
                                    25000,
                                    // quantumGlassReward
                                    25000,
                                    // higgsBosonReward
                                    10000,
                                    // timeToAttack
                                    30,
                                    // theExpanseLevelRequirement
                                    4,
                                    // artOfWarLevelRequirement
                                    4,
                                    // hyperdriveLevelRequirement
                                    0,
                                    // lightFighterCount
                                    0,
                                    // heavtFighterCount
                                    0,
                                    // battleShipCount
                                    50,
                                    // destroyerCount
                                    25,
                                    // dreadnoughtCount
                                    0,
                                    //mothershipCount
                                    0);
            #endregion

            #region Armaments

            Armaments = new EnemyModel("Armaments",
                                    // carbonFiberReward 
                                    50000,
                                    // quantumGlassReward
                                    50000,
                                    // higgsBosonReward
                                    50000,
                                    // timeToAttack
                                    40,
                                    // theExpanseLevelRequirement
                                    6,
                                    // artOfWarLevelRequirement
                                    6,
                                    // hyperdriveLevelRequirement
                                    0,
                                    // lightFighterCount
                                    0,
                                    // heavtFighterCount
                                    0,
                                    // battleShipCount
                                    0,
                                    // destroyerCount
                                    100,
                                    // dreadnoughtCount
                                    50,
                                    //mothershipCount
                                    0);
            #endregion

            #region Distants

            Distants = new EnemyModel("Distants",
                                    // carbonFiberReward 
                                    100000,
                                    // quantumGlassReward
                                    100000,
                                    // higgsBosonReward
                                    100000,
                                    // timeToAttack
                                    50,
                                    // theExpanseLevelRequirement
                                    6,
                                    // artOfWarLevelRequirement
                                    6,
                                    // hyperdriveLevelRequirement
                                    6,
                                    // lightFighterCount
                                    0,
                                    // heavtFighterCount
                                    0,
                                    // battleShipCount
                                    200,
                                    // destroyerCount
                                    150,
                                    // dreadnoughtCount
                                    100,
                                    //mothershipCount
                                    0);
            #endregion

            #region Ancients

            Ancients = new EnemyModel("Ancients",
                                    // carbonFiberReward 
                                    500000,
                                    // quantumGlassReward
                                    500000,
                                    // higgsBosonReward
                                    500000,
                                    // timeToAttack
                                    60,
                                    // theExpanseLevelRequirement
                                    8,
                                    // artOfWarLevelRequirement
                                    8,
                                    // hyperdriveLevelRequirement
                                    8,
                                    // lightFighterCount
                                    0,
                                    // heavtFighterCount
                                    0,
                                    // battleShipCount
                                    0,
                                    // destroyerCount
                                    500,
                                    // dreadnoughtCount
                                    250,
                                    //mothershipCount
                                    1);
            #endregion

            #region Enemies List
            Enemies = new List<EnemyModel>();
            Enemies.Add(Pirates);
            Enemies.Add(Outsiders);
            Enemies.Add(Rebels);
            Enemies.Add(Armaments);
            Enemies.Add(Distants);
            Enemies.Add(Ancients);

            #endregion

            #region EnemyShipsInitialization

            PiratesLightFighter = new ShipModel("PiratesLightFighter", Pirates.LightFighterCount, LightFighter.HealthPoints, LightFighter.AttackPower);
            OutsidersLightFighter = new ShipModel("OutsidersLightFighter", Outsiders.LightFighterCount, LightFighter.HealthPoints, LightFighter.AttackPower);
            OutsidersHeavyFighter = new ShipModel("OutsidersHeavyFighter", Outsiders.HeavyFighterCount, HeavyFighter.HealthPoints, HeavyFighter.AttackPower);
            RebelsBattleship = new ShipModel("RebelsBattleship", Rebels.BattleshipCount, Battleship.HealthPoints, Battleship.AttackPower);
            RebelsDestroyer = new ShipModel("RebelsDestroyer", Rebels.DestroyerCount, Destroyer.HealthPoints, Destroyer.AttackPower);
            ArmamentsDestroyer = new ShipModel("ArmamentsDestroyer", Armaments.DestroyerCount, Destroyer.HealthPoints, Destroyer.AttackPower);
            ArmamentsDreadnought = new ShipModel("ArmamentsDreadnought", Armaments.DreadnoughtCount, Dreadnought.HealthPoints, Dreadnought.AttackPower);
            DistantsBattleship = new ShipModel("DistantsBattleship", Distants.BattleshipCount, Battleship.HealthPoints, Battleship.AttackPower);
            DistantsDestroyer = new ShipModel("DistantsDestroyer", Distants.DestroyerCount, Destroyer.HealthPoints, Destroyer.AttackPower);
            DistantsDreadnought = new ShipModel("DistantsDreadnought", Distants.DreadnoughtCount, Dreadnought.HealthPoints, Dreadnought.AttackPower);
            AncientsDestroyer = new ShipModel("AncientsDestroyer", Ancients.DestroyerCount, Destroyer.HealthPoints, Destroyer.AttackPower);
            AncientsDreadnought = new ShipModel("AncientsDreadnought", Ancients.DreadnoughtCount, Dreadnought.HealthPoints, Dreadnought.AttackPower);
            AncientsMothership = new ShipModel("AncientsMothership", Ancients.MothershipCount, Mothership.HealthPoints, Mothership.AttackPower);

            PiratesShips = new List<ShipModel>();
            PiratesShips.Add(PiratesLightFighter);

            OutsidersShips = new List<ShipModel>();
            OutsidersShips.Add(OutsidersLightFighter);
            OutsidersShips.Add(OutsidersHeavyFighter);

            RebelsShips = new List<ShipModel>();
            RebelsShips.Add(RebelsBattleship);
            RebelsShips.Add(RebelsDestroyer);

            ArmamentsShips = new List<ShipModel>();
            ArmamentsShips.Add(ArmamentsDestroyer);
            ArmamentsShips.Add(ArmamentsDreadnought);

            DistantsShips = new List<ShipModel>();
            DistantsShips.Add(DistantsBattleship);
            DistantsShips.Add(DistantsDestroyer);
            DistantsShips.Add(DistantsDreadnought);

            AncientsShips = new List<ShipModel>();
            AncientsShips.Add(AncientsDestroyer);
            AncientsShips.Add(AncientsDreadnought);
            AncientsShips.Add(AncientsMothership);

            #endregion
        }
        public void upgradeBuilding(BuildingModel building)
        {
            CalculateNewCost(building);
            building.IncreaseLevel();
            building.SetNewTime(AIRobotsResearch.GetLevel(), NaniteFactory.GetNaniteFactoryMultiplier(NaniteFactory.GetLevel()), NaniteFactory.GetLevel());
            building.ConvertTimeToBuildToInt(building);            

            if (building == CarbonFiberBuilding)
            {
                IncreaseCarbonFiberIncome();
            }
            else if (building == QuantumGlassBuilding)
            {
                IncreaseQuantumGlassIncome();
            }
            else if (building == HiggsBosonBuilding)
            {
                IncreaseHiggsBosonIncome();
            }
            else if (building == SolarEnergyBuilding)
            {
                IncreaseEnergy();
            }
            else if (building == Labolatory)
            {
                ReduceResearchTimers();
            }
            else if (building == CarbonFiberStorage)
            {
                IncreaseCarbonFiberCap();
            }
            else if (building == QuantumGlassStorage)
            {
                IncreaseQuantumGlassCap();
            }
            else if (building == HiggsBosonDetector)
            {
                IncreaseHiggsBosonCap();
            }
            else if (building == NaniteFactory)
            {
                ReduceBuildingsAndShipsTimers();            
            }
        }
        public void CalculateNewCost(BuildingModel building)
        {
            for (int i = 0; i < PlayerResources.Length; i++)
            {
                this.PlayerResources[i].SubtractFromResources(building.Cost[i].Value);
                building.SetNewCost(i, CostMultipliers[building]);
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
        private void IncreaseCarbonFiberIncome()
        {
            IncomeMultipliers[CarbonFiberBuilding] += 15;
        }
        private void IncreaseQuantumGlassIncome()
        {
            IncomeMultipliers[QuantumGlassBuilding] += 10;
        }
        private void IncreaseHiggsBosonIncome()
        {
            IncomeMultipliers[HiggsBosonBuilding] += 5;
        }
        private void IncreaseEnergy()
        {
            PlayerResources[3].AddEnergy(IncomeMultipliers[SolarEnergyBuilding]);
            IncomeMultipliers[SolarEnergyBuilding] += 1.2F;
        }
        private void ReduceResearchTimers()
        {
            foreach (var research in PlayerResearch)
            {
                research.CutTimeToBuildByHalf(research);
                research.ConvertTimeToBuildToInt(research);
            }
        }
        private void IncreaseCarbonFiberCap()
        {
            CarbonFiber.Cap *= 2;
        }
        private void IncreaseQuantumGlassCap()
        {
            QuantumGlass.Cap *= 2;
        }
        private void IncreaseHiggsBosonCap()
        {
            HiggsBoson.Cap *= 2;
        }
        private void ReduceBuildingsAndShipsTimers()
        {
            foreach (var playerBuilding in PlayerBuildings)
            {
                playerBuilding.CutTimeToBuildByHalf(playerBuilding);
                playerBuilding.ConvertTimeToBuildToInt(playerBuilding);
            }
            foreach (var ship in PlayerShips)
            {
                ship.CutTimeToBuildByHalf(ship);
                ship.ConvertTimeToBuildToInt(ship);
            }
        }
        public void StableResourceIncome()
        {
            GenerateCarbonFiber();
            GenerateQuantumGlass();
            GenerateHiggsBoson();
        }
        public void upgradeResearch(ResearchModel research)
        {
            for (int i = 0; i < PlayerResources.Length; i++)
            {
                this.PlayerResources[i].SubtractFromResources(research.Cost[i].Value);               
                research.SetNewCost(i, ResearchMultipliers[research]);             
            }
            research.IncreaseLevel();
            research.SetNewTime(Labolatory.GetLabolatoryMultiplier(Labolatory.Level));
            research.ConvertTimeToBuildToInt(research);
            if (research == Hyperdrive)
            {
                foreach (var enemy in Enemies)
                {
                    enemy.TimeToAttack /= 2;
                }
            }
            foreach (var building in PlayerBuildings)
            {
                building.SetNewTime(AIRobotsResearch.GetLevel(), NaniteFactory.GetNaniteFactoryMultiplier(NaniteFactory.GetLevel()), NaniteFactory.GetLevel());
            }            
        }
        public bool canUpgradeResearch(ResearchModel research)
        {
            for (int i = 0; i < PlayerResources.Length; i++)
            {
                if (this.PlayerResources[i].Value < research.Cost[i].Value || !(IsLabRequiredLevel(research)))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsLabRequiredLevel(ResearchModel research)
        {
            if (Labolatory.Level >= research.LabLevelRequirement)
            {
                return true;
            }
            return false;
        }
        public void BuildShip(ShipModel ship, int validatedShipCount)
        {
            for (int j = 0; j < validatedShipCount; j++)
            {
                for (int i = 0; i < PlayerResources.Length; i++)
                {
                    this.PlayerResources[i].SubtractFromResources(ship.Cost[i].Value);
                }

                ship.IncreaseCount();
            }
        }
        public bool canBuildShip(ShipModel ship)
        {
            for (int i = 0; i < PlayerResources.Length; i++)
            {
                if (this.PlayerResources[i].Value < ship.Cost[i].Value || !(IsSpaceshipFactoryRequiredLevel(ship)))
                {
                    return false;
                }
            }
            return true;
        }
        public void Attack(EnemyModel enemy)
        {
            bool continueFight = true;

            int playerTotalHP = GetPlayerTotalHP();
            int playerTotalAP = GetPlayerTotalAP();

            int enemyTotalHP = GetEnemyTotalHP(enemy);
            int enemyTotalAP = GetEnemyTotalAP(enemy);           

            while (continueFight)
            {
                enemyTotalHP = PlayerAttack(playerTotalAP, enemyTotalHP);                 
                DestroyEnemyShips(enemy, playerTotalAP);
                enemyTotalAP = GetEnemyTotalAP(enemy);

                if (enemyTotalHP <= 0)
                {
                    CollectRewards(enemy);
                    SetRewardsToZero(enemy);
                    DestroyEnemyShips(enemy, playerTotalAP);                    
                    continueFight = false;
                    break;
                }
                playerTotalHP = EnemyAttack(enemyTotalAP, playerTotalHP);                
                                        
                if (playerTotalHP <= 0)
                    {
                        DestroyPlayerShips(PlayerShips, enemyTotalAP);                                            
                        continueFight = false;
                        break;
                    }
                else if (playerTotalHP > 0)
                    {                 
                        DestroyPlayerShips(PlayerShips, enemyTotalAP);
                        playerTotalAP = GetPlayerTotalAP();                       
                    }
                }
            }        
        public bool canAttack(EnemyModel enemy)
        {
            if (TheExpanse.Level >= enemy.TheExpanseLevelRequirement && ArtOfWar.Level >= enemy.ArtOfWarLevelRequirement && Hyperdrive.Level >= enemy.HyperdriveLevelRequirement)
            {
                return true;
            }
            return false;
        }
        private int PlayerAttack(int playerAP, int enemyHP)
        {
            enemyHP -= playerAP;
            return enemyHP;
        }
        private int EnemyAttack(int enemyAP, int playerHP)
        {
            playerHP -= enemyAP;
            return playerHP;
        }
        private bool IsSpaceshipFactoryRequiredLevel(ShipModel ship)
        {
            if (SpaceshipFactory.Level >= ship.SpaceshipFactoryLevelRequirement)
            {
                return true;
            }
            return false;
        }
        private void GenerateCarbonFiber()
        {
            if (this.PlayerResources[0].Value < CarbonFiber.Cap)
            {
                this.PlayerResources[0].AddTo(this.IncomeMultipliers[CarbonFiberBuilding]);
            }
        }
        private void GenerateQuantumGlass()
        {
            if (this.PlayerResources[1].Value < QuantumGlass.Cap)
            {
                this.PlayerResources[1].AddTo(this.IncomeMultipliers[QuantumGlassBuilding]);
            }
        }
        private void GenerateHiggsBoson()
        {
            if (this.PlayerResources[2].Value < HiggsBoson.Cap)
            {
                this.PlayerResources[2].AddTo(this.IncomeMultipliers[HiggsBosonBuilding]);
            }
        }
        private int GetPlayerTotalHP()
        {
            int result = 0;

            foreach (var ship in PlayerShips)
            {
                result += ship.Count * ship.HealthPoints;
            }
            return result;
        }
        private int GetPlayerTotalAP()
        {
            int result = 0;

            foreach (var ship in PlayerShips)
            {
                result += ship.Count * ship.AttackPower;
            }
            return result;
        }
        private int GetEnemyTotalHP(EnemyModel enemy)
        {
            int result = 0;

            if (enemy == Pirates)
            {
                foreach (var piratesShip in PiratesShips)
                {
                    result += piratesShip.Count * piratesShip.HealthPoints;
                }
            }
            else if (enemy == Outsiders)
            {
                foreach (var outsidersShip in OutsidersShips)
                {
                    result += outsidersShip.Count * outsidersShip.HealthPoints;
                }
            }
            else if (enemy == Rebels)
            {
                foreach (var rebelsShip in RebelsShips)
                {
                    result += rebelsShip.Count * rebelsShip.HealthPoints;
                }
            }
            else if (enemy == Armaments)
            {
                foreach (var armamentsShip in ArmamentsShips)
                {
                    result += armamentsShip.Count * armamentsShip.HealthPoints;
                }
            }
            else if (enemy == Distants)
            {
                foreach (var distantsShip in DistantsShips)
                {
                    result += distantsShip.Count * distantsShip.HealthPoints;
                }
            }
            else if (enemy == Ancients)
            {
                foreach (var ancientsShip in AncientsShips)
                {
                    result += ancientsShip.Count * ancientsShip.HealthPoints;
                }
            }
            return result;
        }
        private int GetEnemyTotalAP(EnemyModel enemy)
        {
            int result = 0;

            if (enemy == Pirates)
            {
                foreach (var piratesShip in PiratesShips)
                {
                    result += piratesShip.Count * piratesShip.AttackPower;
                }
            }
            else if (enemy == Outsiders)
            {
                foreach (var outsidersShip in OutsidersShips)
                {
                    result += outsidersShip.Count * outsidersShip.AttackPower;
                }
            }
            else if (enemy == Rebels)
            {
                foreach (var rebelsShip in RebelsShips)
                {
                    result += rebelsShip.Count * rebelsShip.AttackPower;
                }
            }
            else if (enemy == Armaments)
            {
                foreach (var armamentsShip in ArmamentsShips)
                {
                    result += armamentsShip.Count * armamentsShip.AttackPower;
                }
            }
            else if (enemy == Distants)
            {
                foreach (var distantsShip in DistantsShips)
                {
                    result += distantsShip.Count * distantsShip.AttackPower;
                }
            }
            else if (enemy == Ancients)
            {
                foreach (var ancientsShip in AncientsShips)
                {
                    result += ancientsShip.Count * ancientsShip.AttackPower;
                }
            }
            return result;
        }
        private void CollectRewards(EnemyModel enemy)
        {
            PlayerResources[0].Value += enemy.CarbonFiberReward;
            PlayerResources[1].Value += enemy.QuantumGlassReward;
            PlayerResources[2].Value += enemy.HiggsBosonReward;
        }
        private void SetRewardsToZero(EnemyModel enemy)
        {
            enemy.CarbonFiberReward = 0;
            enemy.QuantumGlassReward = 0;
            enemy.HiggsBosonReward = 0;
        }       
        private void DestroyPlayerShips(List<ShipModel> playerShips, int enemyDamage)
        {      
            CalculateDestroyedShips(playerShips, enemyDamage);              
        }
        private void DestroyEnemyShips(EnemyModel enemy, int playerDamage)
        {            
                if (enemy == Pirates)
                {
                    CalculateDestroyedShips(PiratesShips, playerDamage);                      
                }
                else if (enemy == Outsiders)
                {
                    CalculateDestroyedShips(OutsidersShips, playerDamage);
                }
                else if (enemy == Rebels)
                {
                    CalculateDestroyedShips(RebelsShips, playerDamage);
                }
                else if (enemy == Armaments)
                {
                    CalculateDestroyedShips(ArmamentsShips, playerDamage);
                }
                else if (enemy == Distants)
                {
                    CalculateDestroyedShips(DistantsShips, playerDamage);
                }
                else if (enemy == Ancients)
                {
                    CalculateDestroyedShips(AncientsShips, playerDamage);
                }
        }
        private void CalculateDestroyedShips(List<ShipModel> ships, int damage)
        {
            int result = 0;

            while (damage > 0)
            {               
                    foreach (var ship in ships)
                    {
                        result = (int)MathF.Round(damage / ship.HealthPoints);

                        if (ship.Count > 0)
                        {
                            {
                                if (result >= ship.Count)
                                {
                                    damage -= ship.Count * ship.HealthPoints;
                                    ship.Count = 0;

                                }
                                else if (result < ship.Count)
                                {
                                    ship.Count -= result;
                                    damage = 0;                                    
                                }
                                else if (result <= 0)
                                {
                                    damage = 0;
                                }
                            }
                        }                        
                    } damage = 0;              
            }
        }        
    }
}

