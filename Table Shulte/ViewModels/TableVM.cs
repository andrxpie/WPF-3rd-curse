using _09_shulte_table.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Ink;

namespace Table_Shulte.ViewModels
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class TableVM
    {
        private IList<CellVM> cells = new List<CellVM>();
        public IEnumerable<CellVM> Cells => cells;
        public int FirstNumber => 1;
        public int LastNumber => Size * Size - 1;
        public int Size { get; }
        public bool IsStarted { get; set; }
        public int CurrCell { get; set; } = 1;

        public TableVM(int size) 
        {
            Size = size;
            IsStarted = true;
            CurrCell = 1;

            for (int i = FirstNumber; i <= LastNumber; ++i) cells.Add(new CellVM(i));
            cells[0].IsEnable = true;
            //cells.Shuffle();

            cells.Insert(cells.Count / 2, new CellVM());
        }

        public void NextCell(int number)
        {
            if(CurrCell != number) return;

            for (int i = 0; i < LastNumber; i++)
            {
                if(cells[i].Number != null && cells[i].Number == CurrCell)
                {
                    CurrCell++;
                    if(cells[i].Number != LastNumber / 2)
                        cells[i + 1].IsEnable = true;
                    else
                        cells[i + 2].IsEnable = true;
                    if(cells[i].Number == LastNumber)
                        MessageBox.Show("Congrats");
                    break;
                }
            }
        }
    }

    public enum CellColor
    {
        White, Yellow, Green, Blue, Red, Purple
    }

    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class CellVM
    {
        private static Random rnd = new();

        public int? Number { get; }
        public CellColor Color { get; set; }
        public bool IsEnable { get; set; } = false;

        public CellVM(int? number = null)
        {
            Number = number;
            Color = Number != null ? GetRandomColor() : CellColor.White;
        }

        private static CellColor GetRandomColor()
        {
            return (CellColor)rnd.Next(Enum.GetValues(typeof(CellColor)).Length);
        }
    }
}