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
using System.Windows.Shapes;

namespace WPF_repeat
{
    /// <summary>
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Window
    {
        public Controls()
        {
            InitializeComponent();
        }

        public class Order
        {
            public string name { get; set; }
            public string ?concatcInfo { get; set; }
            public int countDays { get; set; }
            public int numType { get; set; }
            public int countCostumers { get; set; }

            public Order()
            {

            }
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            //countCostumers = ++costumerCountLBL
        }
    }
}
