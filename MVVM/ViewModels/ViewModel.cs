using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public bool IsAvaiablePrev => CurrentBookIndex > 0 ? true : false;
        public bool IsAvaiableNext => CurrentBookIndex < Books.Count - 1 ? true : false;
        public IList<Book> Books = new List<Book>();
        public Book CurrentBook { get; set; }
        private int CurrentBookIndex { get; set; } = 0;

        public ViewModel() 
        {
            Books.Add(new Book() { Name = "Hicksaw Ridge", Author = "Steve Man", PubDate = new DateOnly(2023, 6, 14), Description = "This is a description of \"Hicksaw Ridge\"" });
            Books.Add(new Book() { Name = "The Great Gatsby", Author = "F. Scott Fitzgerald", PubDate = new DateOnly(1925, 4, 10), Description = "This is a description of \"The Great Gatsby\""});
            Books.Add(new Book() { Name = "Lonely worker", Author = "Alfrefo Gamb", PubDate = new DateOnly(988, 2, 23), Description = "This is a description of \"Lonely worker\""});

            CurrentBook = Books.First();
        }

        public void NextBook()
        {
            CurrentBook = Books[++CurrentBookIndex];
        }

        public void PrevBook()
        {
            CurrentBook = Books[--CurrentBookIndex];
        }
    }
}