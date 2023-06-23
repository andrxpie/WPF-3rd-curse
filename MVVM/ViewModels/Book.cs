using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateOnly PubDate { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{PubDate.Month} {PubDate.Day}, {PubDate.Year}";
        }
    }
}