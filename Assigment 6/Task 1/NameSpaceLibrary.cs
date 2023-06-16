namespace LibrarySystem
{
    public class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

    }

    public class Library
    {
        private Book?[] _books;
        private int _count;

        public Library(int capacity)
        {
            _books = new Book[capacity];
            _count = 0;
        }

        public Book? this[int index]
        {
            get { return _books[index]; }
            set { _books[index] = value; }
        }

        public int Count
        {
            get { return _count; }
        }

        public void AddBook(Book book)
        {
            if(_count<_books.Length)
            {
                _books[_count] = book;
                _count++;
            }
            else
            {
                Console.WriteLine("The Library is full");
            }
        }

        public void RemoveBook(int? index = null)
        {
            if(index == null)
            {
                Array.Clear(_books, 0, _books.Length);
                _count = 0;
            }
            else
            {
                if(index >= 0 && index< _count)
                {
                    for (int i = index??0; i < _count - 1; i++)
                    {
                        _books[i] = _books[i + 1];
                    }
                    _count--;
                    _books[_count] = null;
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
        }
        public Book? Find(string searchCriteria, string searchTerm)
        {
            return SearchHelper.FindBook(_books, searchCriteria, searchTerm);
        }
    }
    public static class SearchHelper
    {
        public static Book? FindBook(Book?[] books,  string searchCriteria, string searchTerm)
        {
            switch(searchCriteria.ToLower())
            {
                case "author":
                    return Array.Find(books, book => book?.Author == searchTerm);
                case "title":
                    return Array.Find(books, book => book?.Title == searchTerm);
                case "year":
                    if(int.TryParse(searchTerm, out int year) )
                    return Array.Find(books, book => book?.Year == year);
                    break;
            }
            return null;
        }
    }
}