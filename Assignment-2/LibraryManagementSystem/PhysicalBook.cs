using System;

// Class for physical books
public class PhysicalBook : Book
{
    public PhysicalBook(string title, string author, int year) : base(title, author, year)
    {
    }

    // Implementation of borrowing a physical book
    public override void BorrowBook()
    {
        if (Available)
        {
            Available = false;
            Console.WriteLine($"You have borrowed the book: {Title} by {Author}");
        }
        else
        {
            Console.WriteLine($"Sorry, the book {Title} is not available for borrowing.");
        }
    }
}
