using System;

public class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Book Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

public class HandleBook
{
    public static void Main(string[] args)
    {
        Book book = new Book("The Alchemist", "Paulo Coelho", 299.99);
        book.DisplayDetails();
    }
}
