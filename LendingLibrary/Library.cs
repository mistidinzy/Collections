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
    private Dictionary<int, Book> catalog = new Dictionary<int, Book>();

    public int Count => throw new NotImplementedException();

    public void Add(string title, string firstName, string lastName, int numberOfPages)
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

        Book newBook = new Book(tInput, fNInput, lNInput, pageInt);

        Console.WriteLine("What is the Book ID?");
        string? idInput = Console.ReadLine();
        int idInt = Int32.Parse(idInput);

        catalog.Add(idInt, newBook);
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
  }
}

