using QuantumWorld_v1._0.Commands;
using QuantumWorld_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuantumWorld_v1._0.ViewModel
{
    public class BuildingsViewModel : ObservableObject
    {
        private PlayerModel _player;
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

        public RelayCommand UpgradeCarbonFiberBuilding { get; set; }
        public RelayCommand UpgradeQuantumGlassBuilding { get; set; }

        public RelayCommand UpgradeHiggsBosonBuilding { get; set; }
        public BuildingsViewModel(PlayerModel player)
        {
            Player = player;

            UpgradeCarbonFiberBuilding = new RelayCommand(o =>
            {
                _player.upgradeBuilding(CarbonFiberBuilding);
                OnPropertyChanged(nameof(CarbonFiberBuilding));
                OnPropertyChanged(nameof(Player.PlayerResources));


            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return _player.canUpgradeBuilding(CarbonFiberBuilding);
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


        }
    }
}
