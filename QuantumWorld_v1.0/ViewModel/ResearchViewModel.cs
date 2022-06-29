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

        public RelayCommand UpgradeAIRobotsResearch { get; set; }

        public ResearchViewModel(PlayerModel player)
        {
            Player = player;

            UpgradeAIRobotsResearch = new RelayCommand(o =>
            {
                UpgradeResearch(AIRobotsResearch);

            },
            (o =>
            {
                CommandManager.InvalidateRequerySuggested();
                return (_player.canUpgradeResearch(AIRobotsResearch) && isTimerRunning());
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
                OnPropertyChanged(nameof(Player.PlayerResources));

            }
        }

        public bool isTimerRunning()
        {
            if (timeToEnd > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
