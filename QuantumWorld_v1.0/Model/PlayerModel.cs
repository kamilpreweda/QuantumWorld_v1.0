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

        public ResourceModel CarbonFiber { get; private set; }
        public ResourceModel QuantumGlass { get; private set; }
        public ResourceModel HiggsBoson { get; private set; }
        public ResourceModel SolarEnergy { get; private set; }
        public ResourceModel CarbonFiberCap { get; private set; }
        public ResourceModel QuantumGlassCap { get; private set; }
        public ResourceModel HiggsBosonCap { get; private set; }

        public ResourceModel[] PlayerResources { get; private set; }

        public Dictionary<BuildingModel, float> Multipliers { get; private set; }

        public Dictionary<BuildingModel, float> CostMultipliers { get; private set; }

        public Dictionary<ResearchModel, float> ResearchMultipliers { get; private set; }

        public List<ShipModel> PlayerShips { get; set; }

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

        public ResourceModel[] CarbonFiberBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 5),
            new ResourceModel("Quantum Glass", 2),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 5),
        };

        public ResourceModel[] QuantumGlassBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 7),
            new ResourceModel("Quantum Glass", 3),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 10),
        };

        public ResourceModel[] HiggsBosonBuilding_StartingCost =
       {
            new ResourceModel("Carbon Fiber", 10),
            new ResourceModel("Quantum Glass", 5),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 15),
        };

        public ResourceModel[] SolarEnergyBuilding_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 7),
            new ResourceModel("Quantum Glass", 7),
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
            new ResourceModel("Carbon Fiber", 10),
            new ResourceModel("Quantum Glass", 0),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };
        public ResourceModel[] QuantumGlassStorage_StartingCost =
    {
            new ResourceModel("Carbon Fiber", 10),
            new ResourceModel("Quantum Glass", 5),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };
        public ResourceModel[] HiggsBosonDetector_StartingCost =
    {
            new ResourceModel("Carbon Fiber", 10),
            new ResourceModel("Quantum Glass", 10),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };
        public ResourceModel[] SpaceshipFactory_StartingCost =
    {
            new ResourceModel("Carbon Fiber", 10),
            new ResourceModel("Quantum Glass", 10),
            new ResourceModel("Higgs Boson", 10),
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
            new ResourceModel("Carbon Fiber", 5),
            new ResourceModel("Quantum Glass", 4),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] SpaceOrganizing_StartingCost =
        {
            new ResourceModel("Carbon Fiber", 15),
            new ResourceModel("Quantum Glass", 15),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] TheExpanse_StartingCost =
       {
            new ResourceModel("Carbon Fiber", 20),
            new ResourceModel("Quantum Glass", 20),
            new ResourceModel("Higgs Boson", 10),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] ArtOfWar_StartingCost =
     {
            new ResourceModel("Carbon Fiber", 25),
            new ResourceModel("Quantum Glass", 25),
            new ResourceModel("Higgs Boson", 15),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Hyperdrive_StartingCost =
     {
            new ResourceModel("Carbon Fiber", 30),
            new ResourceModel("Quantum Glass", 30),
            new ResourceModel("Higgs Boson", 20),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] LightFighter_Cost =
            {
            new ResourceModel("Carbon Fiber", 10),
            new ResourceModel("Quantum Glass", 10),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] HeavyFighter_Cost =
            {
            new ResourceModel("Carbon Fiber", 50),
            new ResourceModel("Quantum Glass", 50),
            new ResourceModel("Higgs Boson", 0),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Battleship_Cost =
            {
            new ResourceModel("Carbon Fiber", 250),
            new ResourceModel("Quantum Glass", 200),
            new ResourceModel("Higgs Boson", 150),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Destroyer_Cost =
           {
            new ResourceModel("Carbon Fiber", 500),
            new ResourceModel("Quantum Glass", 400),
            new ResourceModel("Higgs Boson", 300),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Dreadnought_Cost =
           {
            new ResourceModel("Carbon Fiber", 800),
            new ResourceModel("Quantum Glass", 500),
            new ResourceModel("Higgs Boson", 200),
            new ResourceModel("Solar Energy", 0),
        };

        public ResourceModel[] Mothership_Cost =
           {
            new ResourceModel("Carbon Fiber", 5000),
            new ResourceModel("Quantum Glass", 5000),
            new ResourceModel("Higgs Boson", 1000),
            new ResourceModel("Solar Energy", 0),
        };

        public PlayerModel()
        {
            Name = "Kamil";

            PlayerResources = new ResourceModel[]
            {
                new ResourceModel("Carbon Fiber", 1000),
                new ResourceModel("Quantum Glass", 1000),
                new ResourceModel("Higgs Boson", 0),
                new ResourceModel("Solar Energy", 0),
            };

            CarbonFiberCap = new ResourceModel(2000);
            QuantumGlassCap = new ResourceModel(2000);
            HiggsBosonCap = new ResourceModel(2000);

            CarbonFiberBuilding = new BuildingModel("CarbonFiberBuilding", CarbonFiberBuilding_StartingCost, 0, 1);
            QuantumGlassBuilding = new BuildingModel("QuantumGlassBuilding", QuantumGlassBuilding_StartingCost, 0, 1);
            HiggsBosonBuilding = new BuildingModel("HiggsBosonBuilding", HiggsBosonBuilding_StartingCost, 0, 1);
            SolarEnergyBuilding = new BuildingModel("SolarEnergyBuilding", SolarEnergyBuilding_StartingCost, 0, 1);
            Labolatory = new BuildingModel("Labolatory", Labolatory_StartingCost, 0, 1);
            CarbonFiberStorage = new BuildingModel("CarbonFiberStorage", CarbonFiberStorage_StartingCost, 0, 1);
            QuantumGlassStorage = new BuildingModel("QuantumGlassStorage", QuantumGlassStorage_StartingCost, 0, 1);
            HiggsBosonDetector = new BuildingModel("HiggsBosonDetector", HiggsBosonDetector_StartingCost, 0, 1);
            SpaceshipFactory = new BuildingModel("SpaceshipFactory", SpaceshipFactory_StartingCost, 0, 1);
            NaniteFactory = new BuildingModel("NaniteFactory", NaniteFactory_StartingCost, 0, 1);


            Multipliers = new Dictionary<BuildingModel, float>();
            Multipliers.Add(CarbonFiberBuilding, 20);
            Multipliers.Add(QuantumGlassBuilding, 15);
            Multipliers.Add(HiggsBosonBuilding, 0);
            Multipliers.Add(SolarEnergyBuilding, 2.5F);

            CostMultipliers = new Dictionary<BuildingModel, float>();
            CostMultipliers.Add(CarbonFiberBuilding, 1.5F);
            CostMultipliers.Add(QuantumGlassBuilding, 1.6F);
            CostMultipliers.Add(HiggsBosonBuilding, 1.7F);
            CostMultipliers.Add(SolarEnergyBuilding, 1.8F);
            CostMultipliers.Add(Labolatory, 2F);
            CostMultipliers.Add(CarbonFiberStorage, 2F);
            CostMultipliers.Add(QuantumGlassStorage, 2F);
            CostMultipliers.Add(HiggsBosonDetector, 2F);
            CostMultipliers.Add(SpaceshipFactory, 2F);
            CostMultipliers.Add(NaniteFactory, 2F);

            AIRobotsResearch = new ResearchModel("AIRobotsResearch", AIRobotsResearch_StartingCost, 0, 1, 2);
            SpaceOrganizing = new ResearchModel("SpaceOrganizing", SpaceOrganizing_StartingCost, 0, 1, 4);
            TheExpanse = new ResearchModel("TheExpanse", TheExpanse_StartingCost, 0, 1, 6);
            ArtOfWar = new ResearchModel("ArtOfWar", ArtOfWar_StartingCost, 0, 1, 8);
            Hyperdrive = new ResearchModel("Hyperdrive", Hyperdrive_StartingCost, 0, 1, 10);

            ResearchMultipliers = new Dictionary<ResearchModel, float>();
            ResearchMultipliers.Add(AIRobotsResearch, 2F);
            ResearchMultipliers.Add(SpaceOrganizing, 2F);
            ResearchMultipliers.Add(TheExpanse, 2F);
            ResearchMultipliers.Add(ArtOfWar, 2F);
            ResearchMultipliers.Add(Hyperdrive, 2F);

            LightFighter = new ShipModel("LightFighter", 0, 20, 10, 1, LightFighter_Cost, 2);
            HeavyFighter = new ShipModel("HeavyFighter", 0, 50, 30, 2, HeavyFighter_Cost, 4);
            Battleship = new ShipModel("Battleship", 0, 100, 75, 3, Battleship_Cost, 6);
            Destroyer = new ShipModel("Destroyer", 0, 200, 300, 4, Destroyer_Cost, 8);
            Dreadnought = new ShipModel("Dreadnought", 0, 500, 250, 5, Dreadnought_Cost, 10);
            Mothership = new ShipModel("Mothership", 0, 1000, 1000, 6, Mothership_Cost, 12);

            Pirates = new EnemyModel("Pirates", 5000, 5000, 0, 1, 2, 0, 0);
            PiratesLightFighter = new ShipModel("PiratesLightFighter", 10, 20, 10);

            Outsiders = new EnemyModel("Outsiders", 15000, 15000, 0, 2, 4, 0, 0);
            OutsidersLightFighter = new ShipModel("OutsidersLightFighter", 50, 20, 10);
            OutsidersHeavyFighter = new ShipModel("HeavyFighter", 25, 50, 30);

            Rebels = new EnemyModel("Rebels", 25000, 25000, 10000, 3, 4, 4, 0);
            RebelsBattleship = new ShipModel("RebelsBattleship", 50, 100, 75);
            RebelsDestroyer = new ShipModel("RebelsDestroyer", 25, 200, 300);

            Armaments = new EnemyModel("Armaments", 50000, 50000, 50000, 4, 4, 6, 0);
            ArmamentsDestroyer = new ShipModel("ArmamentsDestroyer", 100, 200, 300);
            ArmamentsDreadnought = new ShipModel("ArmamentsDreadnought", 50, 500, 250);

            Distants = new EnemyModel("Distants", 100000, 100000, 100000, 5, 6, 6, 6);
            DistantsBattleship = new ShipModel("DistantsBattleship", 150, 100, 75);
            DistantsDestroyer = new ShipModel("DistantsDestroyer", 100, 200, 300);
            DistantsDreadnought = new ShipModel("DistantsDreadnought", 50, 500, 250);

            Ancients = new EnemyModel("Ancients", 500000, 500000, 500000, 6, 8, 8, 8);
            AncientsDestroyer = new ShipModel("AncientsDestroyer", 500, 200, 300);
            AncientsDreadnought = new ShipModel("AncientsDreadnought", 250, 500, 250);
            AncientsMothership = new ShipModel("AncientsMothership", 1, 1000, 1000);
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
                else if (building == CarbonFiberStorage)
                {
                    building.SetNewCost(i, CostMultipliers[CarbonFiberStorage]);
                }
                else if (building == QuantumGlassStorage)
                {
                    building.SetNewCost(i, CostMultipliers[QuantumGlassStorage]);
                }
                else if (building == HiggsBosonDetector)
                {
                    building.SetNewCost(i, CostMultipliers[HiggsBosonDetector]);
                }
                else if (building == SpaceshipFactory)
                {
                    building.SetNewCost(i, CostMultipliers[SpaceshipFactory]);
                }
                else if (building == NaniteFactory)
                {
                    building.SetNewCost(i, CostMultipliers[NaniteFactory]);
                }
            }
            building.IncreaseLevel();
            building.SetNewTime(AIRobotsResearch.GetLevel());
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
                PlayerResources[3].AddEnergy(Multipliers[SolarEnergyBuilding]);
                Multipliers[SolarEnergyBuilding] += 0.1F;
            }
            else if (building == CarbonFiberStorage)
            {
                CarbonFiberCap.Cap *= 2;
            }
            else if (building == QuantumGlassStorage)
            {
                QuantumGlassCap.Cap *= 2;
            }
            else if (building == HiggsBosonDetector)
            {
                HiggsBosonCap.Cap *= 2;
            }
            else if (building == NaniteFactory)
            {
                CarbonFiberBuilding.CutTimeToBuildByHalf();
                QuantumGlassBuilding.CutTimeToBuildByHalf();
                HiggsBosonBuilding.CutTimeToBuildByHalf();
                SolarEnergyBuilding.CutTimeToBuildByHalf();
                Labolatory.CutTimeToBuildByHalf();
                CarbonFiberStorage.CutTimeToBuildByHalf();
                QuantumGlassStorage.CutTimeToBuildByHalf();
                HiggsBosonDetector.CutTimeToBuildByHalf();
                SpaceshipFactory.CutTimeToBuildByHalf();
                NaniteFactory.CutTimeToBuildByHalf();

                LightFighter.CutTimeToBuildByHalf();
                HeavyFighter.CutTimeToBuildByHalf();
                Battleship.CutTimeToBuildByHalf();
                Destroyer.CutTimeToBuildByHalf();
                Dreadnought.CutTimeToBuildByHalf();
                Mothership.CutTimeToBuildByHalf();
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
            GenerateCarbonFiber();
            GenerateQuantumGlass();
            GenerateHiggsBoson();
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
                else if (research == SpaceOrganizing)
                {
                    research.SetNewCost(i, ResearchMultipliers[SpaceOrganizing]);
                }
                else if (research == TheExpanse)
                {
                    research.SetNewCost(i, ResearchMultipliers[TheExpanse]);
                }
                else if (research == ArtOfWar)
                {
                    research.SetNewCost(i, ResearchMultipliers[ArtOfWar]);
                }
                else if (research == Hyperdrive)
                {
                    research.SetNewCost(i, ResearchMultipliers[Hyperdrive]);
                }


            }

            research.IncreaseLevel();
            research.SetNewTime();
            CarbonFiberBuilding.SetNewTime(AIRobotsResearch.GetLevel());
            QuantumGlassBuilding.SetNewTime(AIRobotsResearch.GetLevel());
            HiggsBosonBuilding.SetNewTime(AIRobotsResearch.GetLevel());
            SolarEnergyBuilding.SetNewTime(AIRobotsResearch.GetLevel());
            Labolatory.SetNewTime(AIRobotsResearch.GetLevel());
            CarbonFiberStorage.SetNewTime(AIRobotsResearch.GetLevel());
            QuantumGlassStorage.SetNewTime(AIRobotsResearch.GetLevel());
            HiggsBosonDetector.SetNewTime(AIRobotsResearch.GetLevel());
            SpaceshipFactory.SetNewTime(AIRobotsResearch.GetLevel());
            NaniteFactory.SetNewTime(AIRobotsResearch.GetLevel());
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
            // zbieram wszystkie statki playera i sumuje ich łączne HP

            int playerTotalHP = (LightFighter.Count * LightFighter.HealthPoints) +
                                (HeavyFighter.Count * HeavyFighter.HealthPoints) +
                                (Battleship.Count * Battleship.HealthPoints) +
                                (Destroyer.Count * Destroyer.HealthPoints) +
                                (Dreadnought.Count * Dreadnought.HealthPoints) +
                                (Mothership.Count * Mothership.HealthPoints);
            
            // dodaje attack power wszystkich statków playera

            int playerTotalAP = (LightFighter.Count * LightFighter.AttackPower) +
                                (HeavyFighter.Count * HeavyFighter.AttackPower) +
                                (Battleship.Count * Battleship.AttackPower) +
                                (Destroyer.Count * Destroyer.AttackPower) +
                                (Dreadnought.Count * Dreadnought.AttackPower) +
                                (Mothership.Count * Mothership.AttackPower);

            int enemyTotalHP;
            int enemyTotalAP;

            // Jeżeli enemy == Pirates 

            if (enemy == Pirates)
            {
                // zbieram wszystkie statki enemy i sumuje ich łączne HP

                enemyTotalHP = (PiratesLightFighter.Count * PiratesLightFighter.HealthPoints);

                // dodaje attack power wszystkich statków enemy

                enemyTotalAP = (PiratesLightFighter.Count * PiratesLightFighter.AttackPower);

                // Walka się toczy dopóki HP playera albo enemy jest większe od 0

                while (enemyTotalHP > 0 || playerTotalHP > 0) { 

                // Statki playera atakują wartośćią totalAttackPower i odejmuje tą wartość od EnemyTotalHP

                enemyTotalHP -= playerTotalAP;

                    // Jeżeli EnemyTotalHP <= 0 przerywam walkę (ustawiam wartości HP na 0 żeby wyjść z pętli while)
                    // i dodaje rewards do surowców playera i zeruje statki i rewards enemy

                    if (enemyTotalHP <= 0)
                    {
                        PlayerResources[0].Value += enemy.CarbonFiberReward;
                        PlayerResources[1].Value += enemy.QuantumGlassReward;
                        enemy.CarbonFiberReward = 0;
                        enemy.QuantumGlassReward = 0;
                        PiratesLightFighter.Count = 0;
                        playerTotalHP = 0;
                        enemyTotalHP = 0;

                        // Jeżeli EnemyTotalHP > 0 

                    }
                    else if (enemyTotalHP > 0)
                    {
                        // obliczam straty w statkach enemy

                        PiratesLightFighter.Count = (enemyTotalHP / PiratesLightFighter.HealthPoints);

                        // obliczam nową wartość enemyTotalAP

                        enemyTotalAP = (PiratesLightFighter.Count * PiratesLightFighter.AttackPower);

                        // enemy atakuje playera z enemyTotalAttackPower i odejmuje tą wartość od playerTotalHP

                        playerTotalHP -= enemyTotalAP;

                        // Jeżeli playerTotalHP <= 0 przerywam walkę, usuwam statki playera i resetuje statki enemy

                        if (playerTotalHP <= 0)
                        {
                            LightFighter.Count = 0;
                            HeavyFighter.Count = 0;
                            Battleship.Count = 0;
                            Destroyer.Count = 0;
                            Dreadnought.Count = 0;
                            Mothership.Count = 0;

                            PiratesLightFighter.Count = 10;

                            playerTotalHP = 0;
                            enemyTotalHP = 0;

                            // Jeżeli playerTotalHP > 0 to obliczam nową ilość statków playera i player znowu atakuje

                        }
                        else if (playerTotalHP > 0)
                        {
                            // dodaje statki playera do listy tylko i wyłącznie wtedy gdy player jakieś posiada

                            List<ShipModel> ships = new List<ShipModel>();
                            if(LightFighter.Count > 0)
                            {
                                ships.Add(LightFighter);
                            }
                            if(HeavyFighter.Count > 0)
                            {
                                ships.Add(HeavyFighter);
                            }
                            if(Battleship.Count > 0)
                            {
                                ships.Add(Battleship);
                            }
                            if(Destroyer.Count > 0)
                            {
                                ships.Add(Destroyer);
                            }
                            if(Dreadnought.Count > 0)
                            {
                                ships.Add(Dreadnought);
                            }
                            if(Mothership.Count > 0)
                            {
                                ships.Add(Mothership);
                            }
                            
                            // tworzę nową zmienną playerTotalHPPool w celu obliczenia nowej ilości statków bez zmieniania wartości playerTotalHP

                            int playerTotalHPPool = playerTotalHP;

                            // obliczam nowe statki dopóki nie wykorzystam całej puli dostępnego HP ( najpierw niszczone są najsłabsze statki )

                            while (playerTotalHPPool > 0)
                            {
                                foreach (ShipModel ship in ships)
                                {
                                    int LostShip = (int)MathF.Round(ship.Count / ship.HealthPoints);
                                    
                                    playerTotalHPPool -= (ship.Count * ship.HealthPoints);
                                    ship.Count -= LostShip;
                                        
                                    if (playerTotalHPPool < ship.HealthPoints)
                                    {
                                        playerTotalHPPool = 0;
                                    }
                                 }                                   
                            }

                            // obliczam nową wartość playerTotalAP

                            playerTotalAP = (LightFighter.Count * LightFighter.AttackPower) +
                                (HeavyFighter.Count * HeavyFighter.AttackPower) +
                                (Battleship.Count * Battleship.AttackPower) +
                                (Destroyer.Count * Destroyer.AttackPower) +
                                (Dreadnought.Count * Dreadnought.AttackPower) +
                                (Mothership.Count * Mothership.AttackPower);

                            // i wracam do pętli while
                        }
                    }

                } // koniec walki
            }               
        }

        public bool canAttack(EnemyModel enemy)
        {
            if(TheExpanse.Level >= enemy.TheExpanseLevelRequirement && ArtOfWar.Level >= enemy.ArtOfWarLevelRequirement && Hyperdrive.Level >= enemy.HyperdriveLevelRequirement)
            {
                return true;
            }
            return false;
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
            if (this.PlayerResources[0].Value < CarbonFiberCap.Cap)
            {
                this.PlayerResources[0].AddTo(this.Multipliers[CarbonFiberBuilding]);
            }
            else
            {
                this.PlayerResources[0].Value = CarbonFiberCap.Cap;
            }
        }
        private void GenerateQuantumGlass()
        {
            if (this.PlayerResources[1].Value < QuantumGlassCap.Cap)
            {
                this.PlayerResources[1].AddTo(this.Multipliers[QuantumGlassBuilding]);
            }
            else
            {
                this.PlayerResources[1].Value = QuantumGlassCap.Cap;
            }
        }
        private void GenerateHiggsBoson()
        {
            if (this.PlayerResources[2].Value < HiggsBosonCap.Cap)
            {
                this.PlayerResources[2].AddTo(this.Multipliers[HiggsBosonBuilding]);
            }
            else
            {
                this.PlayerResources[2].Value = HiggsBosonCap.Cap;
            }
        }
    }
}

