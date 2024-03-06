using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class BookLibrary
    {
        private string name;
        private List<Book> books;

        public BookLibrary(string name)
        {
            this.name = Name;
            this.books = new List<Book>();
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Book> Books
        {
            get
            {
                return books;
            }

            set
            {
                books = value;
            }
        }

        public void AddBook(string title, double rating)
        {
            Book book = new Book(title, rating);
            books.Add(book);
        }

        public double AverageRating()
        {
            if (books.Count == 0)
            {
                return 0;
            }
            double sum = books.Sum(b  => b.Rating);
            return sum / (double)books.Count;
        }

        public List<string> GetBooksByRating(double rating)
        {
            List<string> List = books
                .Where(b => b.Rating > rating)
                .Select(b => b.Title)
                .ToList();
            return List;
        }

        public List<Book> SortByTitle()
        {
            List<Book> sortedList = books.OrderBy(book => book.Title).ToList();
            Books.Clear();
            Books = sortedList;
            return sortedList;
        }

        public List<Book> SortByRating()
        {
            List<Book> sortedList = books.OrderByDescending(book => book.Rating).ToList();
            Books.Clear();
            Books = sortedList;
            return sortedList;
        }

        public string[] ProvideInformationAboutAllBooks()
        {
            string[] result = books.Select(book => book.ToString()).ToArray();
            return result;
        }

        public bool CheckBookIsInBookLibrary(string title)
        {
            bool isTtue = books.Any(book => book.Title == title);
            return isTtue;


        }
    }
}

