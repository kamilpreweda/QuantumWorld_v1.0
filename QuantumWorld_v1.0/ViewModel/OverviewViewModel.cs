using QuantumWorld_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumWorld_v1._0.ViewModel
{
    public class OverviewViewModel : ObservableObject
    {
        private PlayerModel _player;
        public PlayerModel Player { get => _player;
            set
            {
                _player = value;
                OnPropertyChanged();
            }
        }

        public OverviewViewModel(PlayerModel player)
        {
            Player = player;
        }
    
    }
}
