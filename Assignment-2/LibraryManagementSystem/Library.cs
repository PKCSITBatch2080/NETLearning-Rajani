using System;
using System.Collections.Generic;

// Library class
public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    // Add book to the library
    public void AddBook(Book book)
    {
        books.Add(book);
    }

    // Display all available books in the library
    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in books)
        {
            if (book.Available)
            {
                Console.WriteLine($"{book.Title} by {book.Author} ({book.Year})");
            }
        }
    }

    // Borrow a book from the library
    public void BorrowBook(string title)
    {
        Book book = books.Find(b => b.Title == title && b.Available);
        if (book != null)
        {
            book.BorrowBook();
        }
        else
        {
            Console.WriteLine("Book not found or unavailable.");
        }
    }
}
