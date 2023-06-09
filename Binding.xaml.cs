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
    /// Interaction logic for Binding.xaml
    /// </summary>
    public partial class Binding : Window
    {
        private ViewModel viewModel = new();

        public Binding()
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }

    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public ViewModel()
        {
            
        }

        public Color Color => Color.FromArgb(alpha, red, green, blue);

        // ARGB
        public byte alpha { get; set; }
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }
    }
}