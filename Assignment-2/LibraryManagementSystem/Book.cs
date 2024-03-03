using System;

// Abstract class representing a book
public abstract class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool Available { get; set; }

    // Constructor
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        Available = true; // By default, book is available when added to the library
    }

    // Abstract method for borrowing a book
    public abstract void BorrowBook();
}
