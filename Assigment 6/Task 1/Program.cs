using LibrarySystem;
{
    Library myLibrary = new Library(5);

    myLibrary.AddBook(new Book("Lord Of The Rings", "J.R.R. Tolkien", 1954));
    myLibrary.AddBook(new Book("Harry Potter", "J.K. Rowling", 1997));
    myLibrary.AddBook(new Book("Data Tutashkhia", "Chabua Amirejibi", 1975));

    //find book by author
    Book? findBookByAuthor = myLibrary.Find("author", "J.K. Rowling");
    if (findBookByAuthor != null)
    {
        Console.WriteLine("Book found: " + findBookByAuthor.Title);
    }
    else
    {
        Console.WriteLine("Book not found");
    }

    //Find Book By Title
    Book? findBookByTitle = myLibrary.Find("title", "Data Tutashkhia");
    if (findBookByTitle != null)
    {
        Console.WriteLine("Author of the book " + findBookByTitle.Title + " is " + findBookByTitle.Author);
    }
    else
    {
        Console.WriteLine("Book Not found");
    }

    //Find Book By year 
    Book? findBookByYear = myLibrary.Find("year", "1954");
    if (findBookByYear != null)
    {
        Console.WriteLine("Book found: " + findBookByYear.Title);
    }
    else
    {
        Console.WriteLine("Book not found.");
    }

    // Remove a book
    myLibrary.RemoveBook(1);

    // Print the remaining books in the library
    Console.WriteLine("Books in the library:");
    for (int i = 0; i < myLibrary.Count; i++)
    {
        Book? book = myLibrary[i];
        if (book != null)
        {
            Console.WriteLine("Title: " + book.Title + ", Author: " + book.Author + ", Year: " + book.Year);
        }
    }
}