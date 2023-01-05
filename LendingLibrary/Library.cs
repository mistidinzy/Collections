#pragma warning disable CS8604 // Possible null reference argument.
using System;
using System.Collections;

namespace LendingLibrary
{
  public class Library : ILibrary
  {
    int count = 0;

    public Library()
    {
      
    }

    //Since books need to be borrowed by Title, use a private Dictionary<string, Book> for storage.
    private static Dictionary<int, Book> catalog = new Dictionary<int, Book>();

    public int Count => count;

    public void AddBook(string title, string firstName, string lastName, int numberOfPages)
    {
      try
      {
        string? tInput = title;
        string? fNInput = firstName;
        string? lNInput = lastName;
        int pInput = numberOfPages;
        int bookID = generateIDNumber();

        Book newBook = new Book(bookID, tInput, fNInput, lNInput, pInput);
        catalog.Add(bookID, newBook);
        Console.WriteLine($"New book has been added: {newBook.Title}, by {newBook.FirstName} {newBook.LastName}");
        count = count + 1;

        Console.WriteLine($"Number of Books in Library: {count}.");
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

