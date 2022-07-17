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
        public EnemyModel Outsiders
        {
            get => _player.Outsiders;
            set
            {
                _player.Outsiders.SetEnemy(Outsiders);
                OnPropertyChanged(nameof(Outsiders));
            }
        }
        public ShipModel OutsidersLightFighter
        {
            get => _player.OutsidersLightFighter;
            set
            {
                _player.OutsidersLightFighter.SetShip(OutsidersLightFighter);
                OnPropertyChanged(nameof(OutsidersLightFighter));
            }
        }
        public ShipModel OutsidersHeavyFighter
        {
            get => _player.OutsidersHeavyFighter;
            set
            {
                _player.OutsidersHeavyFighter.SetShip(OutsidersHeavyFighter);
                OnPropertyChanged(nameof(OutsidersHeavyFighter));
            }
        }
        public EnemyModel Rebels
        {
            get => _player.Rebels;
            set
            {
                _player.Rebels.SetEnemy(Rebels);
                OnPropertyChanged(nameof(Rebels));
            }
        }
        public ShipModel RebelsBattleship
        {
            get => _player.RebelsBattleship;
            set
            {
                _player.RebelsBattleship.SetShip(RebelsBattleship);
                OnPropertyChanged(nameof(RebelsBattleship));
            }
        }
        public ShipModel RebelsDestroyer
        {
            get => _player.RebelsDestroyer;
            set
            {
                _player.RebelsDestroyer.SetShip(RebelsDestroyer);
                OnPropertyChanged(nameof(RebelsDestroyer));
            }
        }
        public EnemyModel Armaments
        {
            get => _player.Armaments;
            set
            {
                _player.Armaments.SetEnemy(Armaments);
                OnPropertyChanged(nameof(Armaments));
            }
        }
        public ShipModel ArmamentsDestroyer
        {
            get => _player.ArmamentsDestroyer;
            set
            {
                _player.ArmamentsDestroyer.SetShip(ArmamentsDestroyer);
                OnPropertyChanged(nameof(ArmamentsDestroyer));
            }
        }
        public ShipModel ArmamentsDreadnought
        {
            get => _player.ArmamentsDreadnought;
            set
            {
                _player.ArmamentsDreadnought.SetShip(ArmamentsDreadnought);
                OnPropertyChanged(nameof(ArmamentsDreadnought));
            }
        }
        public EnemyModel Distants
        {
            get => _player.Distants;
            set
            {
                _player.Distants.SetEnemy(Distants);
                OnPropertyChanged(nameof(Distants));
            }
        }
        public ShipModel DistantsBattleship
        {
            get => _player.DistantsBattleship;
            set
            {
                _player.DistantsBattleship.SetShip(DistantsBattleship);
                OnPropertyChanged(nameof(DistantsBattleship));
            }
        }
        public ShipModel DistantsDestroyer
        {
            get => _player.DistantsDestroyer;
            set
            {
                _player.DistantsDestroyer.SetShip(DistantsDestroyer);
                OnPropertyChanged(nameof(DistantsDestroyer));
            }
        }
        public ShipModel DistantsDreadnought
        {
            get => _player.DistantsDreadnought;
            set
            {
                _player.DistantsDreadnought.SetShip(DistantsDreadnought);
                OnPropertyChanged(nameof(DistantsDreadnought));
            }
        }
        public EnemyModel Ancients
        {
            get => _player.Ancients;
            set
            {
                _player.Ancients.SetEnemy(Ancients);
                OnPropertyChanged(nameof(Ancients));
            }
        }
        public ShipModel AncientsDestroyer
        {
            get => _player.AncientsDestroyer;
            set
            {
                _player.AncientsDestroyer.SetShip(AncientsDestroyer);
                OnPropertyChanged(nameof(AncientsDestroyer));
            }
        }
        public ShipModel AncientsDreadnought
        {
            get => _player.AncientsDreadnought;
            set
            {
                _player.AncientsDreadnought.SetShip(AncientsDreadnought);
                OnPropertyChanged(nameof(AncientsDreadnought));
            }
        }
        public ShipModel AncientsMothership
        {
            get => _player.AncientsMothership;
            set
            {
                _player.AncientsMothership.SetShip(AncientsMothership);
                OnPropertyChanged(nameof(AncientsMothership));
            }
        }
        public RelayCommand AttackPirates { get; set; }
        public RelayCommand AttackOutsiders { get; set; }
        public RelayCommand AttackRebels { get; set; }
        public RelayCommand AttackArmaments { get; set; }
        public RelayCommand AttackDistants { get; set; }
        public RelayCommand AttackAncients { get; set; }
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

            AttackOutsiders = new RelayCommand(o =>
            {
                Attack(Outsiders);
                isBusy = true;

            },
                (o =>
                {
                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canAttack(Outsiders) && !isBusy);
                }));

            AttackRebels = new RelayCommand(o =>
            {
                Attack(Rebels);
                isBusy = true;

            },
                (o =>
                {
                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canAttack(Rebels) && !isBusy);
                }));

            AttackArmaments = new RelayCommand(o =>
            {
                Attack(Armaments);
                isBusy = true;

            },
                (o =>
                {
                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canAttack(Armaments) && !isBusy);
                }));

            AttackDistants = new RelayCommand(o =>
            {
                Attack(Distants);
                isBusy = true;

            },
                (o =>
                {
                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canAttack(Distants) && !isBusy);
                }));

            AttackAncients = new RelayCommand(o =>
            {
                Attack(Ancients);
                isBusy = true;

            },
                (o =>
                {
                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canAttack(Ancients) && !isBusy);
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
            OnPropertyChanged(nameof(Player.OutsidersLightFighter));
            OnPropertyChanged(nameof(Player.OutsidersHeavyFighter));
            OnPropertyChanged(nameof(Player.RebelsBattleship));
            OnPropertyChanged(nameof(Player.RebelsDestroyer));
            OnPropertyChanged(nameof(Player.ArmamentsDestroyer));
            OnPropertyChanged(nameof(Player.ArmamentsDreadnought));
            OnPropertyChanged(nameof(Player.DistantsBattleship));
            OnPropertyChanged(nameof(Player.DistantsDestroyer));
            OnPropertyChanged(nameof(Player.DistantsDreadnought));
            OnPropertyChanged(nameof(Player.AncientsDestroyer));
            OnPropertyChanged(nameof(Player.AncientsDreadnought));
            OnPropertyChanged(nameof(Player.AncientsMothership));
            OnPropertyChanged(nameof(Player.Pirates.CarbonFiberReward));
            OnPropertyChanged(nameof(Player.Pirates.QuantumGlassReward));
            OnPropertyChanged(nameof(Player.Outsiders.CarbonFiberReward));
            OnPropertyChanged(nameof(Player.Outsiders.QuantumGlassReward));
            OnPropertyChanged(nameof(Player.Rebels.CarbonFiberReward));
            OnPropertyChanged(nameof(Player.Rebels.QuantumGlassReward));
            OnPropertyChanged(nameof(Player.Rebels.HiggsBosonReward));
            OnPropertyChanged(nameof(Player.Armaments.CarbonFiberReward));
            OnPropertyChanged(nameof(Player.Armaments.QuantumGlassReward));
            OnPropertyChanged(nameof(Player.Armaments.HiggsBosonReward));
            OnPropertyChanged(nameof(Player.Distants.CarbonFiberReward));
            OnPropertyChanged(nameof(Player.Distants.QuantumGlassReward));
            OnPropertyChanged(nameof(Player.Distants.HiggsBosonReward));
            OnPropertyChanged(nameof(Player.Ancients.CarbonFiberReward));
            OnPropertyChanged(nameof(Player.Ancients.QuantumGlassReward));
            OnPropertyChanged(nameof(Player.Ancients.HiggsBosonReward));
        }
    }
}
