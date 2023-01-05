using System.Collections.Generic;

namespace LendingLibrary.Tests;

public class LibraryTests
{
    [Fact]
    public void DictionaryWorks()
    {
      Dictionary<int, Book> catalog = new Dictionary<int, Book>();
      Assert.Empty(catalog);
    }

  [Fact]
  public void CanAddBookToCatalog()
  {
    Dictionary<int, Book> catalog = new Dictionary<int, Book>();

    int bookID = Library.generateIDNumber();

    Book testBook = new Book(bookID, "BookName", "Author", "Authorington", 50);

    catalog.Add(bookID, testBook);

    Assert.NotEmpty(catalog);
  }
}
