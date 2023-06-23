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

namespace MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel ViewModel;
        public MainWindow()
        {
            ViewModel = new ViewModel();
            DataContext = ViewModel;
        }

        private void Prev(object sender, RoutedEventArgs e)
        {
            ViewModel.PrevBook();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            ViewModel.NextBook();
        }
    }
}