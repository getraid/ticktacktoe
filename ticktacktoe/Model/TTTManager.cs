using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ticktacktoe.ViewModel;

namespace ticktacktoe.Model
{
    // ReSharper disable once InconsistentNaming
    public class TTTManager
    {
        public const int ButtonCount = 9;

        public ObservableCollection<bool?> InitCollToBlank()
        {
            ObservableCollection<bool?> temp = new ObservableCollection<bool?>();
            for (int i = 0; i < ButtonCount; i++)
            {
                temp.Add(null);
            }
            return temp;
        }

        public ObservableCollection<char> InitCollVisualToBlank()
        {
            ObservableCollection<char> temp = new ObservableCollection<char>();
            for (int i = 0; i < ButtonCount; i++)
            {
                temp.Add(' ');
            }
            return temp;
        }

        public void ResetColltoBlank(ObservableCollection<bool?> coll)
        {
            for (int i = 0; i < coll.Count; i++)
            {
                coll[i] = null;
            }

        }

        public void ResetCollVisualtoBlank(ObservableCollection<char> collV)
        {
            for (int i = 0; i < collV.Count; i++)
            {
                collV[i] = ' ';
            }

        }


        public void ApplyNewButtonClick(ObservableCollection<bool?> coll, int parameter, bool? currentPlayer)
        {
            coll[parameter] = (currentPlayer);
        }

        [Obsolete]
        public bool? CheckIfWon(ObservableCollection<bool?> coll)
        {
            if (
                (coll[0] == true & coll[1] == true & coll[2] == true) ||
                (coll[3] == true & coll[4] == true & coll[5] == true) ||
                (coll[6] == true & coll[7] == true & coll[8] == true) ||
                (coll[0] == true & coll[3] == true & coll[6] == true) ||
                (coll[1] == true & coll[4] == true & coll[7] == true) ||
                (coll[2] == true & coll[5] == true & coll[8] == true) ||
                (coll[0] == true & coll[4] == true & coll[8] == true) ||
                (coll[2] == true & coll[4] == true & coll[6] == true)
                )
            {

                return true;
            }
            else if (
                (coll[0] == false & coll[1] == false & coll[2] == false) ||
                (coll[3] == false & coll[4] == false & coll[5] == false) ||
                (coll[6] == false & coll[7] == false & coll[8] == false) ||
                (coll[0] == false & coll[3] == false & coll[6] == false) ||
                (coll[1] == false & coll[4] == false & coll[7] == false) ||
                (coll[2] == false & coll[5] == false & coll[8] == false) ||
                (coll[0] == false & coll[4] == false & coll[8] == false) ||
                (coll[2] == false & coll[4] == false & coll[6] == false)
            )
            {
                MessageBox.Show("Spieler 'X' hat gewonnen!");
                return false;
            }

            return null;
        }

        public bool? CheckIfWonEasy(ObservableCollection<bool?> coll)
        {
            bool temp = false;

            for (int i = 0; i < 2; i++)
            {
                if ((coll[0] == temp & coll[1] == temp & coll[2] == temp) ||
                (coll[3] == temp & coll[4] == temp & coll[5] == temp) ||
                (coll[6] == temp & coll[7] == temp & coll[8] == temp) ||
                (coll[0] == temp & coll[3] == temp & coll[6] == temp) ||
                (coll[1] == temp & coll[4] == temp & coll[7] == temp) ||
                (coll[2] == temp & coll[5] == temp & coll[8] == temp) ||
                (coll[0] == temp & coll[4] == temp & coll[8] == temp) ||
                (coll[2] == temp & coll[4] == temp & coll[6] == temp))
                {
                    if (temp)
                    {
                        MessageBox.Show("Spieler 'O' hat gewonnen!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Spieler 'X' hat gewonnen!");
                        return false;
                    }
                }
                temp = true;
            }
            return null;

        }

        public void SetCollVisual(ObservableCollection<bool?> coll, ObservableCollection<char> collV)
        {
            for (var i = 0; i < ButtonCount; i++)
            {
                if (coll[i] == true)
                {
                    collV[i] = 'O';
                }
                else if ((coll[i] == false))
                {
                    collV[i] = 'X';
                }
                else
                {
                    collV[i] = ' ';
                }
            }

        }

    }
}
