using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ticktacktoe.Annotations;
using ticktacktoe.Command;
using ticktacktoe.Model;

namespace ticktacktoe.ViewModel
{
    public class TTTViewModel : INotifyPropertyChanged
    {
        private string _lastWinner;
        public ObservableCollection<bool?> Coll { get; set; }
        public ObservableCollection<char> CollVisual { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool? currentPlayer { get; set; }

        public string LastWinner
        {
            get { return _lastWinner; }
            set
            {
                if (value == _lastWinner) return;
                _lastWinner = value;
                OnPropertyChanged();
            }
        }

        public CommandReset CommandReset { get; set; }
        public CommandClickField CommandClickField { get; set; }
        public TTTManager TTTManager { get; set; }


        public TTTViewModel()
        {
            Init();
        }

        public void Init()
        {
            CommandClickField = new CommandClickField(this);
            CommandReset = new CommandReset(this);
            TTTManager = new TTTManager();

            Coll = TTTManager.InitCollToBlank();
            CollVisual = TTTManager.InitCollVisualToBlank();
            currentPlayer = false;
            LastWinner = null;
            TTTManager.SetCollVisual(Coll, CollVisual);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
