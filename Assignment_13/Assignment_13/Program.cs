using Assignment_13;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Creating a library with a capacity of 2
            Library library = new Library(2);

            // Adding valid books
            Book book1 = new Book(1, "Book 1", "Author 1");
            library.AddBook(book1);

            Book book2 = new Book(2, "Book 2", "Author 2");
            library.AddBook(book2);


            // Attempting to add a null book
            Book? nullBook = null;
            library.AddBook(nullBook);

            // Attempting to add another book, which exceeds the library's capacity
            Book book3 = new Book(3, "Book 3", "Author 3");
            library.AddBook(book3);

            // Attempting to retrieve a book that exists in the library
            Book retrievedBook = library.GetBook(2);
            Console.WriteLine("Retrieved Book: " + retrievedBook.Title);

            // Attempting to retrieve a book that doesn't exist in the library
            Book nonExistentBook = library.GetBook(4);
            Console.WriteLine("Retrieved Book: " + nonExistentBook.Title);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("ArgumentNullException: " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine("BookNotFoundException: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program execution complete.");
        }
    }
}