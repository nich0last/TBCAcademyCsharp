using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13
{
    public class Book
    {
        public int BookId { get; }
        public string Title { get; }
        public string Author { get; }

        public Book(int bookId, string title, string author)
        {
            if (bookId <= 0)
                throw new ArgumentException("Book ID must be a positive integer.", nameof(bookId));

            if (string.IsNullOrEmpty(title))
                throw new ArgumentNullException(nameof(title), "Title cannot be empty or null.");

            if (string.IsNullOrEmpty(author))
                throw new ArgumentNullException(nameof(author), "Author cannot be empty or null.");

            BookId = bookId;
            Title = title;
            Author = author;
        }
    }
}
