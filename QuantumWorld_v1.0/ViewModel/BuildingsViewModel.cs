using QuantumWorld_v1._0.Commands;
using QuantumWorld_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Threading;

namespace QuantumWorld_v1._0.ViewModel
{
    public class BuildingsViewModel : ObservableObject
    {
        private PlayerModel _player;

        int timeToEnd;

        DispatcherTimer buildingTimer;

        public PlayerModel Player
        {
            get => _player;
            set
            {
                _player = value;
                OnPropertyChanged();
            }
        }
        public BuildingModel CarbonFiberBuilding
        {
            get => _player.CarbonFiberBuilding;
            set
            {
                _player.CarbonFiberBuilding.SetBuilding(CarbonFiberBuilding);
                OnPropertyChanged(nameof(CarbonFiberBuilding));
            }
        }

        public BuildingModel QuantumGlassBuilding
        {
            get => _player.QuantumGlassBuilding;
            set
            {
                _player.QuantumGlassBuilding.SetBuilding(QuantumGlassBuilding);
                OnPropertyChanged(nameof(QuantumGlassBuilding));
            }
        }
        public BuildingModel HiggsBosonBuilding
        {
            get => _player.HiggsBosonBuilding;
            set
            {
                _player.HiggsBosonBuilding.SetBuilding(HiggsBosonBuilding);
                OnPropertyChanged(nameof(HiggsBosonBuilding));
            }
        }
        public BuildingModel SolarEnergyBuilding
        {
            get => _player.SolarEnergyBuilding;
            set
            {
                _player.SolarEnergyBuilding.SetBuilding(SolarEnergyBuilding);
                OnPropertyChanged(nameof(SolarEnergyBuilding));
            }
        }

        public RelayCommand UpgradeCarbonFiberBuilding { get; set; }
        public RelayCommand UpgradeQuantumGlassBuilding { get; set; }

        public RelayCommand UpgradeHiggsBosonBuilding { get; set; }
        public RelayCommand UpgradeSolarEnergyBuilding { get; set; }

       


        public BuildingsViewModel(PlayerModel player)
        {
            Player = player;

            // buildingTimer.Interval = TimeSpan.FromSeconds(1);

            UpgradeCarbonFiberBuilding = new RelayCommand(o =>
            {
                UpgradeBuilding(CarbonFiberBuilding);
                 
            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return (_player.canUpgradeBuilding(CarbonFiberBuilding) && isTimerRunning());
            }));

            UpgradeQuantumGlassBuilding = new RelayCommand(o =>
            {
                _player.upgradeBuilding(QuantumGlassBuilding);
                OnPropertyChanged(nameof(QuantumGlassBuilding));
                OnPropertyChanged(nameof(Player.PlayerResources));


            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return _player.canUpgradeBuilding(QuantumGlassBuilding);
            }));

            UpgradeHiggsBosonBuilding = new RelayCommand(o =>
            {
                _player.upgradeBuilding(HiggsBosonBuilding);
                OnPropertyChanged(nameof(HiggsBosonBuilding));
                OnPropertyChanged(nameof(Player.PlayerResources));


            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return _player.canUpgradeBuilding(HiggsBosonBuilding);
            }));
            UpgradeSolarEnergyBuilding = new RelayCommand(o =>
            {
                _player.upgradeBuilding(SolarEnergyBuilding);
                OnPropertyChanged(nameof(SolarEnergyBuilding));
                OnPropertyChanged(nameof(Player.PlayerResources));


            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return _player.canUpgradeBuilding(SolarEnergyBuilding);
            }));


        }

        public void UpgradeBuilding(BuildingModel building)
        {
            
            timeToEnd = building.TimeToBuild;
            buildingTimer = new DispatcherTimer();
            buildingTimer.Interval = TimeSpan.FromSeconds(1);
            buildingTimer.Tick += (s, e) => BuildingTimer_Tick(building);
            
            buildingTimer.Start();
        }

        private void BuildingTimer_Tick(BuildingModel building)
        {
            timeToEnd = building.TimeToBuild;
            
            if (building.TimeToBuild > 0)
            {
                building.TimeToBuild--;
                timeToEnd--;
                OnPropertyChanged(building.Name);
            }
            else
            {
                buildingTimer.Stop();
                _player.upgradeBuilding(building);
                OnPropertyChanged(building.Name);
                OnPropertyChanged(nameof(Player.PlayerResources));

                //building.TimeToBuild += 6;
                //OnPropertyChanged(building.Name);
                
            }
        }

        public bool isTimerRunning()
        {
            if (timeToEnd > 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        
    }
}
