using System;

public class Book
{
    public virtual void BorrowBook()
    {
        Console.WriteLine("A general book is being borrowed.");
    }
}

public class FictionBook : Book
{
    public override void BorrowBook()
    {
        Console.WriteLine("A fiction book is being borrowed.");
    }
}

public class NonFictionBook : Book
{
    public override void BorrowBook()
    {
        Console.WriteLine("A non-fiction book is being borrowed.");
    }
}

public class ChildrensBook : Book
{
    public override void BorrowBook()
    {
        Console.WriteLine("A children's book is being borrowed.");
    }
}

public class Librarian
{
    public void LendBook()
    {
        Console.WriteLine("Lending a book with no specific details/parameters.");
    }

    public void LendBook(string title)
    {
        Console.WriteLine($"Lending a book with title: {title}");
    }

    public void LendBook(string title, DateTime dueDate)
    {
        Console.WriteLine($"Lending a book with title: {title} due date: {dueDate}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book();
        book.BorrowBook();

        book = new FictionBook();
        book.BorrowBook();

        book = new NonFictionBook();
        book.BorrowBook();

        book = new ChildrensBook();
        book.BorrowBook();

        Librarian librarian = new Librarian();
        librarian.LendBook();
        librarian.LendBook("One Piece");
        librarian.LendBook("Doraemon", new DateTime(2024, 8, 31, 16, 0, 0));
    }
}