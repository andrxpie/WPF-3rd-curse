﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static WPF_repeat.ViewModel;

namespace WPF_repeat
{
    /// <summary>
    /// Interaction logic for Binding.xaml
    /// </summary>
    public partial class Binding : Window
    {
        private ViewModel viewModel = new();

        public Binding()
        {
            InitializeComponent();
            this.DataContext = viewModel;
            colorLST.ItemsSource = viewModel.ColorList;
        }

        private void AddColor(object sender, RoutedEventArgs e)
        {
            if(!viewModel.ColorList.Contains(viewModel.ToString()))
                viewModel.ColorList.Add(viewModel.ToString());
            else MessageBox.Show("Color already exist");
        }

        private void DeleteColor(object sender, RoutedEventArgs e)
        {
            if(colorLST.SelectedItem != null)
                viewModel.ColorList.RemoveAt(colorLST.SelectedIndex);
        }
    }

    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public ViewModel() {}

        public Color Color => Color.FromArgb(alpha, red, green, blue);
        public ObservableCollection<string> ColorList { get; set; } = new();

        public byte alpha { get; set; }
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }

        public override string ToString()
        {
            return Color.ToString();
        }
    }
}