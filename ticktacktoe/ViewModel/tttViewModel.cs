using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ticktacktoe.Annotations;
using ticktacktoe.Command;

namespace ticktacktoe.ViewModel
{
    public class TTTViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public CommandClickField CommandClickField { get; set; }

        public CommandReset CommandReset { get; set; }

        public TTTViewModel()
        {
            CommandClickField = new CommandClickField(this);
            CommandReset = new CommandReset(this);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
