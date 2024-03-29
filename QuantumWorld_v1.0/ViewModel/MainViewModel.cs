﻿using QuantumWorld_v1._0.Commands;
using QuantumWorld_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace QuantumWorld_v1._0.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        DispatcherTimer timer = new DispatcherTimer();

        public RelayCommand OverviewViewCommand { get; set; }
        public RelayCommand BuildingsViewCommand { get; set; }
        public RelayCommand ResearchViewCommand { get; set; }
        public RelayCommand DocksViewCommand { get; set; }
        public RelayCommand MapViewCommand { get; set; }
        public OverviewViewModel OverviewVM { get; set; }
        public BuildingsViewModel BuildingsVM { get; set; }
        public ResearchViewModel ResearchVM { get; set; }
        public DocksViewModel DocksVM { get; set; }
        public MapViewModel MapVM { get; set; }

       
        private PlayerModel _player;
        public PlayerModel Player { get => _player;
            set
            {
                _player = value;
                OnPropertyChanged();
            }
        }

        private object _currentView;
        public object CurrentView { get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            timer.Interval = TimeSpan.FromSeconds(0.5);

            _player = new PlayerModel();

            OverviewVM = new OverviewViewModel(Player);
            BuildingsVM = new BuildingsViewModel(Player);
            ResearchVM = new ResearchViewModel(Player);
            DocksVM = new DocksViewModel(Player);
            MapVM = new MapViewModel(Player);

            CurrentView = OverviewVM;

            OverviewViewCommand = new RelayCommand(o =>
            {
                CurrentView = OverviewVM;
            });

            BuildingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = BuildingsVM;
            });

            ResearchViewCommand = new RelayCommand(o =>
            {
                CurrentView = ResearchVM;
            });

            DocksViewCommand = new RelayCommand(o =>
            {
                CurrentView = DocksVM;
            });

            MapViewCommand = new RelayCommand(o =>
            {
                CurrentView = MapVM;
            });

            timer.Tick += Timer_Tick;
            timer.Start();



        }

        private void Timer_Tick(object? sender, EventArgs e)
        {

            Player.StableResourceIncome();
            OnPropertyChanged(nameof(Player));
            }
        }
    }

