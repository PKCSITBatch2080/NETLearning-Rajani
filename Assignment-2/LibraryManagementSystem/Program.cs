// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a library
        Library library = new Library();

        // Add physical books to the library
        PhysicalBook book1 = new PhysicalBook("Introduction to C#", "John Doe", 2020);
        PhysicalBook book2 = new PhysicalBook("Data Structures and Algorithms", "Jane Smith", 2019);
        library.AddBook(book1);
        library.AddBook(book2);

        // Add an e-book to the library
        EBook ebook1 = new EBook("Design Patterns", "Gang of Four", 1994, "PDF");
        library.AddBook(ebook1);

        // Display available books
        library.DisplayAvailableBooks();

        // Borrow a book
        library.BorrowBook("Introduction to C#");
        library.BorrowBook("Design Patterns");

        // Display available books after borrowing
        library.DisplayAvailableBooks();

        Console.ReadLine();
    }
}
