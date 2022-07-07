﻿using QuantumWorld_v1._0.Commands;
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
    public class DocksViewModel : ObservableObject
    {
        private PlayerModel _player;

        int timeToEnd;
        bool isBusy;

        DispatcherTimer shipTimer;

        public PlayerModel Player
        {
            get => _player;
            set
            {
                _player = value;
                OnPropertyChanged();
            }
        }
        public ShipModel LightFighter
        {
            get => _player.LightFighter;
            set
            {
                _player.LightFighter.SetShip(LightFighter);
                OnPropertyChanged(nameof(LightFighter));
            }
        }
        public ShipModel HeavyFighter
        {
            get => _player.HeavyFighter;
            set
            {
                _player.HeavyFighter.SetShip(HeavyFighter);
                OnPropertyChanged(nameof(HeavyFighter));
            }
        }
        public ShipModel Battleship
        {
            get => _player.Battleship;
            set
            {
                _player.Battleship.SetShip(Battleship);
                OnPropertyChanged(nameof(Battleship));
            }
        }
        public ShipModel Destroyer
        {
            get => _player.Destroyer;
            set
            {
                _player.Destroyer.SetShip(Destroyer);
                OnPropertyChanged(nameof(Destroyer));
            }
        }
        public ShipModel Dreadnought
        {
            get => _player.Dreadnought;
            set
            {
                _player.Dreadnought.SetShip(Dreadnought);
                OnPropertyChanged(nameof(Dreadnought));
            }
        }
        public ShipModel Mothership
        {
            get => _player.Mothership;
            set
            {
                _player.Mothership.SetShip(Mothership);
                OnPropertyChanged(nameof(Mothership));
            }
        }
        public RelayCommand BuildLightFighter { get; set; }
        public RelayCommand BuildHeavyFighter { get; set; }
        public RelayCommand BuildBattleship { get; set; }
        public RelayCommand BuildDestroyer { get; set; }
        public RelayCommand BuildDreadnought { get; set; }
        public RelayCommand BuildMothership { get; set; }
        public DocksViewModel(PlayerModel player)
        {
            Player = player;
            isBusy = false;

            BuildLightFighter = new RelayCommand(o =>
                {
                    BuildShip(LightFighter);
                    isBusy = true;
                },
                (o =>
                {

                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canBuildShip(LightFighter) && !isBusy);
                }));

            BuildHeavyFighter = new RelayCommand(o =>
            {
                BuildShip(HeavyFighter);
                isBusy = true;
            },
                (o =>
                {

                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canBuildShip(HeavyFighter) && !isBusy);
                }));

            BuildBattleship = new RelayCommand(o =>
            {
                BuildShip(Battleship);
                isBusy = true;
            },
                (o =>
                {

                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canBuildShip(Battleship) && !isBusy);
                }));

            BuildDestroyer = new RelayCommand(o =>
            {
                BuildShip(Destroyer);
                isBusy = true;
            },
                (o =>
                {

                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canBuildShip(Destroyer) && !isBusy);
                }));

            BuildDreadnought = new RelayCommand(o =>
            {
                BuildShip(Dreadnought);
                isBusy = true;
            },
                (o =>
                {

                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canBuildShip(Dreadnought) && !isBusy);
                }));

            BuildMothership = new RelayCommand(o =>
            {
                BuildShip(Mothership);
                isBusy = true;
            },
                (o =>
                {

                    CommandManager.InvalidateRequerySuggested();
                    return (_player.canBuildShip(Mothership) && !isBusy);
                }));
        }
        public void BuildShip(ShipModel ship)
        {

            timeToEnd = ship.TimeToBuild;
            shipTimer = new DispatcherTimer();
            shipTimer.Interval = TimeSpan.FromSeconds(1);
            shipTimer.Tick += (s, e) => ShipTimer_Tick(ship);

            shipTimer.Start();
        }

        private void ShipTimer_Tick(ShipModel ship)
        {
            timeToEnd = ship.TimeToBuild;            

            if (ship.TimeToBuild > 0)
            {
                ship.DecreaseTimer();
                timeToEnd--;
                ship.NewTime++;
                OnPropertyChanged(ship.Name);
            }
            else
            {
                shipTimer.Stop();
                ship.ResetTimer(ship.NewTime);
                _player.BuildShip(ship);
                ship.NewTime = 0;
                CheckChanges();
                OnPropertyChanged(ship.Name);                
                isBusy = false;
                OnPropertyChanged(nameof(Player.PlayerResources));
            }
        }
        public void CheckChanges()
        {
            OnPropertyChanged(nameof(Player.LightFighter));
            OnPropertyChanged(nameof(Player.HeavyFighter));
            OnPropertyChanged(nameof(Player.Battleship));
            OnPropertyChanged(nameof(Player.Destroyer));
            OnPropertyChanged(nameof(Player.Dreadnought));
            OnPropertyChanged(nameof(Player.Mothership));

        }
    }
}
