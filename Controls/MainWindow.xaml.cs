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
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Window
    {
        private ViewModel viewModel = new();
        public Controls()
        {
            InitializeComponent();
            DataContext = viewModel;
        }

        public string nns { get; set; }
        public string ?contactInfo { get; set; }
        public int countDays { get; set; }
        public int numType { get; set; }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            if(viewModel.counterCustomers == 12) { viewModel.counterCustomers = 0; return; }
            viewModel.counterCustomers++;
        }

        private void discardBTN_Click(object sender, RoutedEventArgs e)
        {
            nns = string.Empty;
            contactInfo = string.Empty;
            countDays = 0;
            numType = 0;
            viewModel.counterCustomers = 0;

            nnsTBX.Text = string.Empty;
            contactInfoTBX.Text = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                var RB = numTypeSP.Children[i] as RadioButton;
                RB.IsChecked = false;
            }

            calendar.SelectedDates.Clear();
            countDays = 0;
            termsCBX.IsChecked = false;
        }

        private void acceptIntervalBTN_Click(object sender, RoutedEventArgs e)
        {
            if(calendar.SelectedDates.Count == 0) { MessageBox.Show("Choose at least 1 day"); return; }
            countDays = calendar.SelectedDates.Count;
        }

        private void acceptBTN_Click(object sender, RoutedEventArgs e)
        {
            if(nnsTBX.Text == string.Empty) { MessageBox.Show("Enter your name & surname"); return; }
            if(calendar.SelectedDates.Count == 0) { MessageBox.Show("Choose at least 1 day"); return; }

            nns = nnsTBX.Text;
            contactInfo = contactInfoTBX.Text;

            for (int i = 0; i < 3; i++)
            {
                var RB = numTypeSP.Children[i] as RadioButton;
                if(RB.IsChecked == true) numType = i + 1;
            }

            if(numType == 0) { MessageBox.Show("Choose num type"); return; }
            if(viewModel.counterCustomers == 0) { MessageBox.Show("Add at least 1 customer"); return; }
            
            Results res = new Results(nns, contactInfo, countDays, numType, viewModel.counterCustomers);
            res.ShowDialog();
        }
    }

    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public bool IsEnabled { get; set; }
        public Color ForeColor => IsEnabled ? Colors.White : Colors.Black;
        public int counterCustomers { get; set; } = 0;
    }
}