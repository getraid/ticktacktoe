using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ticktacktoe.ViewModel;

namespace ticktacktoe.Command
{
    public class CommandClickField : ICommand
    {
        private readonly TTTViewModel viewModel;
        public CommandClickField(TTTViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            int b = int.Parse((string)parameter);
            if (viewModel.Coll[b] == true || viewModel.Coll[b] == false)
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            var param = int.Parse((string)parameter);

            viewModel.TTTManager.ApplyNewButtonClick(viewModel.Coll, param, viewModel.currentPlayer);
            viewModel.TTTManager.SetCollVisual(viewModel.Coll, viewModel.CollVisual);
            if (viewModel.TTTManager.CheckifWonEasyEasy(viewModel.Coll).HasValue)
            {
                if (viewModel.currentPlayer == true)
                {
                    viewModel.LastWinner = "O";
                }
                else
                {
                    viewModel.LastWinner = "X";
                }
            
            }

            viewModel.currentPlayer = !viewModel.currentPlayer;
        }

        public event EventHandler CanExecuteChanged;
    }
}
