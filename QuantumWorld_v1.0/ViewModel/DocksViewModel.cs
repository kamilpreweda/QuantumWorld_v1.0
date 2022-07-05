using QuantumWorld_v1._0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace QuantumWorld_v1._0.ViewModel
{
    public class DocksViewModel : ObservableObject
    {
        private PlayerModel _player;

        int timeToEnd;

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

        public DocksViewModel(PlayerModel player)
        {
            Player = player;
        }
    }
}
