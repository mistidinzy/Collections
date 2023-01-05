#pragma warning disable CS8604 // Possible null reference argument.
using System;
using System.Collections;

namespace LendingLibrary
{
  public class Library : ILibrary
  {
    public Library()
    {
      
    }

    //Since books need to be borrowed by Title, use a private Dictionary<string, Book> for storage.
    private static Dictionary<int, Book> catalog = new Dictionary<int, Book>();

    public int Count => throw new NotImplementedException();

    public static void AddBook(string title, string firstName, string lastName, int numberOfPages)
    {
      try
      {
        Console.WriteLine("Add a Book");
        Console.WriteLine("");
        Console.WriteLine("What is the title?");
        string? tInput = Console.ReadLine();
        Console.WriteLine("What is the author's first name?");
        string? fNInput = Console.ReadLine();
        Console.WriteLine("What is the author's last name?");
        string? lNInput = Console.ReadLine();
        Console.WriteLine("How many pages does it have?");
        string? pInput = Console.ReadLine();
        int pageInt = Int32.Parse(pInput);
        int bookID = generateIDNumber();

        Book newBook = new Book(bookID, tInput, fNInput, lNInput, pageInt);

        catalog.Add(bookID, newBook);
      }
      catch
      {
        throw new NotImplementedException();
      }
    }

    public Book Borrow(string title)
    {
      throw new NotImplementedException();
    }

    public void Return(Book book)
    {
      throw new NotImplementedException();
    }

    public IEnumerator<Book> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }

    public static int generateIDNumber()
    {
      Random rnd = new Random();

      int num = rnd.Next(100, 1000);

      if(catalog.ContainsKey(num))
      {
        int newNum = rnd.Next(100, 1000);
        num = newNum;
      }
      return num;
    }
  }
}

