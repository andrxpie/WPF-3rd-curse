using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Table_Shulte
{
    public class ViewModel
    {
        public ViewModel()
        {

        }

        private List<Grid> m_streams = new List<Grid>();
        public List<Grid> Streams
        {
            get { return m_streams; }
            set
            {
                m_streams = value;
                OnPropertyChanged("Streams");
            }
        }
    }
}