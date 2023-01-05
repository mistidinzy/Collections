#pragma warning disable CS8604 // Possible null reference argument.
using System;
using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary
{
  public class Library<T> : ILibrary
  {
    int bookCount = 0;
    T[] books = new T[2];

    public Library(int bookCount)
    { }

    private static Dictionary<string, Book> catalog = new Dictionary<string, Book>();
    private static Dictionary<string, Book> checkedOut = new Dictionary<string, Book>();
    public int Count => bookCount;
    public T this[int index] => books[index];

    public void AddBook(string title, string firstName, string lastName, int numberOfPages)
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

    public Book Borrow(string title)
    {
      Book book;

      if (catalog.TryGetValue(title, out book))
      {
        catalog.Remove(title);
        checkedOut.Add(title, book);
        return book;
      }
      else return null;
    }

    public void Return(Book book)
    {
      if (checkedOut.TryGetValue(book.Title, out book))
      {
        checkedOut.Remove(book.Title);
        catalog.Add(book.Title, book);
      }
      else
      {
        throw new NotImplementedException();
      }
    }

    public void PrintDictionary(Dictionary<string, string> dictionary)
    {
      foreach (KeyValuePair<string, string> item in dictionary)
      {
        Console.WriteLine(item.Key + ": " + item.Value);
      }
    }

    public IEnumerator<T> GetEnumerator()
    {
      for (int i = 0; i < bookCount; i++)
      {
        yield return books[i];
      }
    }

    IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }
  }
}

