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
        private readonly TTTViewModel _viewModel;

        public CommandReset(TTTViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

            _viewModel.TTTManager.ResetColltoBlank(_viewModel.Coll);
            _viewModel.TTTManager.ResetCollVisualtoBlank(_viewModel.CollVisual);
            _viewModel.currentPlayer = false;
        }

        public event EventHandler CanExecuteChanged;
    }
}
