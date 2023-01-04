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
    private Dictionary<string, Book> catalog = new Dictionary<string, Book>();

    public int Count => throw new NotImplementedException();

    public void Add(string title, string firstName, string lastName, int numberOfPages)
    {
      throw new NotImplementedException();
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

