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
    public class MapViewModel : ObservableObject
    {
        private PlayerModel _player;

        int timeToEnd;
        bool isBusy;

        DispatcherTimer attackTimer;

        public PlayerModel Player
        {
            get => _player;
            set
            {
                _player = value;
                OnPropertyChanged();
            }
        }
        public EnemyModel Pirates
        {
            get => _player.Pirates;
            set
            {
                _player.Pirates.SetEnemy(Pirates);
                OnPropertyChanged(nameof(Pirates));
            }
        }
        public ShipModel PiratesLightFighter
        {
            get => _player.PiratesLightFighter;
            set
            {
                _player.PiratesLightFighter.SetShip(PiratesLightFighter);
                OnPropertyChanged(nameof(PiratesLightFighter));
            }
        }
        public RelayCommand AttackPirates { get; set; }

        public MapViewModel(PlayerModel player)
        {
            Player = player;
            isBusy = false;

            AttackPirates = new RelayCommand(o =>
            {
                Attack(Pirates);
                isBusy = true;

            },
                (o =>
                {
                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canAttack(Pirates) && !isBusy);
                }));
        }
        public void Attack(EnemyModel enemy)
        {
            timeToEnd = enemy.TimeToAttack;
            attackTimer = new DispatcherTimer();
            attackTimer.Interval = TimeSpan.FromSeconds(1);
            attackTimer.Tick += (s, e) => AttackTimer_Tick(enemy);

            attackTimer.Start();

        }

        private void AttackTimer_Tick(EnemyModel enemy)
        {
            timeToEnd = enemy.TimeToAttack;

            if (enemy.TimeToAttack > 0)
            {
                enemy.DecreaseTimer();
                timeToEnd--;
                enemy.NewTime++;
                OnPropertyChanged(enemy.Name);
            }
            else
            {
                attackTimer.Stop();
                enemy.ResetTimer(enemy.NewTime);
                enemy.NewTime = 0;                
                _player.Attack(enemy);
                CheckChanges();
                OnPropertyChanged(enemy.Name);
                isBusy = false;
                OnPropertyChanged(nameof(Player.PlayerResources));
            }

        }
        public void CheckChanges()
        {
            OnPropertyChanged(nameof(Player.PiratesLightFighter));
            OnPropertyChanged(nameof(Player.Pirates.CarbonFiberReward));
            OnPropertyChanged(nameof(Player.Pirates.QuantumGlassReward));
            
        }
    }
}
