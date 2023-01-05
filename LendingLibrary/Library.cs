#pragma warning disable CS8604 // Possible null reference argument.
using System;
using System.Collections;
using static System.Reflection.Metadata.BlobBuilder;

namespace LendingLibrary
{
  public class Library : ILibrary
  {
    int bookCount = 0;

    public Library()
    {

    }

    //Since books need to be borrowed by Title, use a private Dictionary<string, Book> for storage.
    private static Dictionary<string, Book> catalog = new Dictionary<string, Book>();
    private static Dictionary<string, Book> checkedOut = new Dictionary<string, Book>();

    public int Count => bookCount;

    public void AddBook(string title, string firstName, string lastName, int numberOfPages)
    {
      try
      {
        string? tInput = title;
        string? fNInput = firstName;
        string? lNInput = lastName;
        int pInput = numberOfPages;

        Book newBook = new Book(tInput, fNInput, lNInput, pInput);

        catalog.Add(tInput, newBook);

        Console.WriteLine($"New book has been added: {newBook.Title}, by {newBook.FirstName} {newBook.LastName}");

        bookCount = bookCount + 1;

        Console.WriteLine($"Number of Books in Library: {bookCount}.");
      }
      catch
      {
        throw new NotImplementedException();
      }
    }

    public Book Borrow(string title)
    {
      Book book;
      if (catalog.TryGetValue(title, out book))
      {
        catalog.Remove(title);
        return book;
      }
      return null;
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

