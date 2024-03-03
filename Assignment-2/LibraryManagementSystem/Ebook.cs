using System;

// Class representing an e-book
public class EBook : Book
{
    public string Format { get; set; }

    public EBook(string title, string author, int year, string format) : base(title, author, year)
    {
        Format = format;
    }

    // Implementation of borrowing an e-book
    public override void BorrowBook()
    {
        Console.WriteLine($"You have borrowed the e-book: {Title} by {Author} in {Format} format.");
    }
}
