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
        private TableVM vm; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Restart(object sender, RoutedEventArgs e)
        {
            vm = (TableVM)DataContext;

            if(vm != null)
            {        
                int diff = vm.Size;
                vm = new TableVM(diff);
                DataContext = vm;
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
                    int size = 0;
                    switch ((string)RB.Content)
                    {
                        case "Easy    (5 x 5)":
                            size = 5;
                            break;
                        case "Medium  (7 x 7)":
                            size = 7;
                            break;
                        default:
                            size = 9;
                            break;
                    }
                    
                    vm = new TableVM(size);
                    DataContext = vm;
                }
            }
        }

        private void ClickCell(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            vm.NextCell(int.Parse(btn.Content.ToString()));
        }
    }
}