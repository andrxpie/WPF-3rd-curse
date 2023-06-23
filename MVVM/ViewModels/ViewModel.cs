using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class ViewModel
    {
        static string description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public bool IsAvaiablePrev { get; set; } = false;
        public bool IsAvaiableNext { get; set; } = true;

        public List<Book> books = new List<Book>()
        { 
            new Book() { Name = "Hicksaw Ridge", Author = "Steve Man", PubDate = new DateOnly(2023, 6, 14), Description = ViewModel.description },
            new Book() { Name = "The Great Gatsby", Author = "F. Scott Fitzgerald", PubDate = new DateOnly(1925, 4, 10), Description = ViewModel.description },
            new Book() { Name = "Lonely worker", Author = "Alfrefo Gamb", PubDate = new DateOnly(988, 2, 23), Description = ViewModel.description }
        };
        public Book CurrentBook { get; set; }

        public ViewModel() 
        {
            CurrentBook = books.First();
        }

        public void NextBook()
        {
            
        }

        public void PrevBook()
        {

        }
    }
}