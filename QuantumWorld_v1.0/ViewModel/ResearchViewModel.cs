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
    public class ResearchViewModel : ObservableObject
    {
        private PlayerModel _player;

        int timeToEnd;
        bool isBusy;

        DispatcherTimer researchTimer;

        public PlayerModel Player
        {
            get => _player;
            set
            {
                _player = value;
                OnPropertyChanged();
            }
        }

        public ResearchModel AIRobotsResearch
        {
            get => _player.AIRobotsResearch;
            set
            {
                _player.AIRobotsResearch.SetResearch(AIRobotsResearch);
                OnPropertyChanged(nameof(AIRobotsResearch));
            }
        }
        public ResearchModel SpaceOrganizing
        {
            get => _player.SpaceOrganizing;
            set
            {
                _player.SpaceOrganizing.SetResearch(SpaceOrganizing);
                OnPropertyChanged(nameof(SpaceOrganizing));
            }
        }

        public ResearchModel TheExpanse
        {
            get => _player.TheExpanse;
            set
            {
                _player.TheExpanse.SetResearch(TheExpanse);
                OnPropertyChanged(nameof(TheExpanse));
            }
        }

        public ResearchModel ArtOfWar
        {
            get => _player.ArtOfWar;
            set
            {
                _player.ArtOfWar.SetResearch(ArtOfWar);
                OnPropertyChanged(nameof(ArtOfWar));
            }
        }

        public ResearchModel Hyperdrive
        {
            get => _player.Hyperdrive;
            set
            {
                _player.Hyperdrive.SetResearch(Hyperdrive);
                OnPropertyChanged(nameof(Hyperdrive));
            }
        }

        public RelayCommand UpgradeAIRobotsResearch { get; set; }
        public RelayCommand UpgradeSpaceOrganizing { get; set; }
        public RelayCommand UpgradeTheExpanse { get; set; }
        public RelayCommand UpgradeArtOfWar { get; set; }
        public RelayCommand UpgradeHyperdrive { get; set; }

        public ResearchViewModel(PlayerModel player)
        {
            Player = player;
            isBusy = false;

            UpgradeAIRobotsResearch = new RelayCommand(o =>
            {
                UpgradeResearch(AIRobotsResearch);
                isBusy = true;
            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return (_player.canUpgradeResearch(AIRobotsResearch) && !isBusy);
            }));

            UpgradeSpaceOrganizing = new RelayCommand(o =>
            {
                UpgradeResearch(SpaceOrganizing);
                 isBusy = true;
            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return (_player.canUpgradeResearch(SpaceOrganizing) && !isBusy);
            }));

            UpgradeTheExpanse = new RelayCommand(o =>
            {
                UpgradeResearch(TheExpanse);
                isBusy = true;
            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return (_player.canUpgradeResearch(TheExpanse) && !isBusy);
            }));

            UpgradeArtOfWar = new RelayCommand(o =>
            {
                UpgradeResearch(ArtOfWar);
                isBusy = true;
            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return (_player.canUpgradeResearch(ArtOfWar) && !isBusy);
            }));

            UpgradeHyperdrive = new RelayCommand(o =>
            {
                UpgradeResearch(Hyperdrive);
                isBusy = true;
            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return (_player.canUpgradeResearch(Hyperdrive) && !isBusy);
            }));
        }

        public void UpgradeResearch(ResearchModel research)
        {

            timeToEnd = research.TimeToBuild;
            researchTimer = new DispatcherTimer();
            researchTimer.Interval = TimeSpan.FromSeconds(1);
            researchTimer.Tick += (s, e) => ResearchTimer_Tick(research);

            researchTimer.Start();
        }

        private void ResearchTimer_Tick(ResearchModel research)
        {
            timeToEnd = research.TimeToBuild;

            if (research.TimeToBuild > 0)
            {
                research.TimeToBuild--;
                timeToEnd--;
                research.NewTime++;
                OnPropertyChanged(research.Name);
            }
            else
            {
                researchTimer.Stop();
                _player.upgradeResearch(research);
                research.ResetTimer(research.NewTime);
                OnPropertyChanged(research.Name);
                isBusy = false;
                OnPropertyChanged(nameof(Player.PlayerResources));

            }
        }        
    }
}
