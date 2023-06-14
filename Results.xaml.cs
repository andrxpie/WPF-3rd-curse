using PropertyChanged;
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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Window
    {
        public Results(string nns, string ?contactInfo, int countDays, int numType, int counterCustomers)
        {
            InitializeComponent();

            nnsTBX.Content = nns;
            contactInfoTBX.Content = contactInfo;

            if(countDays == 1) intervalTBX.Content = countDays + " day";
            else intervalTBX.Content = countDays + " days";

            if(numType == 1) numTypeTBX.Content = "Econom";
            else if(numType == 2) numTypeTBX.Content = "Standart";
            else numTypeTBX.Content = "Lux";

            counterCustomersTBX.Content = counterCustomers;
            
            double sum = 20;

            if(numType == 1) sum *= 0.8;
            else if(numType == 2) sum *= 1.1;
            else sum *= 2.3;

            sum *= counterCustomers;
            sum *= countDays;

            totalCostTBX.Content = sum + "$";
        }
    }
}