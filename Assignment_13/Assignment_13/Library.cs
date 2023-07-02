using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13
{
    public class Library
    {
        private List<Book> books;
        private int capacity;

        public List<Book> Books
        {
            get { return books; }
        }

        public int Capacity
        {
            get { return capacity; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Capacity cannot be negative.");
                capacity = value;
            }
        }

        public Library(int capacity)
        {
            Capacity = capacity;
            books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if (book == null)
                throw new ArgumentNullException(nameof(book), "Book cannot be null.");

            if (Books.Count >= Capacity)
                throw new IndexOutOfRangeException("The library is at maximum capacity.");

            Books.Add(book);
        }
        public Book GetBook(int bookId)
        {
            foreach (var book in Books)
            {
                if (book.BookId == bookId)
                    return book;
            }

            throw new BookNotFoundException($"Book with ID '{bookId}' not found in the library.");
        }
    }
}
