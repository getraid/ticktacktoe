using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ticktacktoe.ViewModel;

namespace ticktacktoe.Command
{
    public class CommandReset : ICommand
    {
        private readonly TTTViewModel viewModel;

        public CommandReset(TTTViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            viewModel.TTTManager.ResetColltoBlank(viewModel.Coll);
            viewModel.TTTManager.ResetCollVisualtoBlank(viewModel.CollVisual);
            viewModel.currentPlayer = false;
        }

        public event EventHandler CanExecuteChanged;
    }
}
