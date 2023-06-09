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

        public string name { get; set; }
        public string ?concatcInfo { get; set; }
        public int countDays { get; set; }
        public int numType { get; set; }
        public int countCostumers { get; set; }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            if(countCostumers == 12)
            {
                MessageBox.Show("Max num of costumers has been reached", "Message", MessageBoxButton.OK);
                return;
            }

            countCostumers = Convert.ToInt32(costumerCountLBL.Content.ToString().Substring(ToString().Length - 1)) + 1;

            if(countCostumers < 10)
            {
                for (int i = 0; i < costumerCountLBL.ToString().Length; i++)
                {

            }
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            //countCostumers = ++costumerCountLBL
        }
    }
}
