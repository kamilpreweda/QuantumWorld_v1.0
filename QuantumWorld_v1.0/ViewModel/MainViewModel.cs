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
    }
}
