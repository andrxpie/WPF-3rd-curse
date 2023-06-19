using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Table_Shulte.ViewModels;

namespace Table_Shulte
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            TableVM vm = (TableVM)DataContext;

            if(vm != null)
            {        
                int diff = vm.Size;
                DataContext = new TableVM(diff);
            }
            else MessageBox.Show("Game haven`t started");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Difficulty(object sender, RoutedEventArgs e)
        {           
            for (int i = 0; i < 3; i++)
            {
                RadioButton RB = (RadioButton)difficultySTCK.Children[i];

                if (RB.IsChecked == true)
                {
                    if((string)RB.Content == "Easy    (5 x 5)")
                    {
                        DataContext = new TableVM(5);
                        return;
                    }
                    else if((string)RB.Content == "Medium  (7 x 7)")
                    {
                        DataContext = new TableVM(7);
                        return;
                    }
                    else
                    {
                        DataContext = new TableVM(9);
                        return;
                    }
                }
            }
        }

        private void ClickCell(object sender, RoutedEventArgs e)
        {
            TableVM vm = (TableVM)DataContext;
            Button btn = (Button)sender;

            if((string)btn.Content == vm.CurrCell.ToString())
            {
                vm.CurrCell++;
                btn.IsEnabled = true;
            }
        }
    }
}