using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary.Tests;

public class LibraryTests
{
  [Fact]
  public void NewDictionaryWorks()
  {
    Dictionary<string, Book> catalog = new Dictionary<string, Book>();
    Assert.Empty(catalog);
  }

  [Fact]
  public void CanAddBookToCatalog()
  {
    Dictionary<string, Book> catalog = new Dictionary<string, Book>();
    string bookID = "BookName";
    Book testBook = new Book("BookName", "Author", "Authorington", 50);
    catalog.Add(bookID, testBook);
    Assert.NotEmpty(catalog);
    string testBookID = testBook.Title;
    Assert.Equal("BookName", testBookID);
  }

  [Fact]
  public void CanBorrowBook()
  {
    // Arrange
    var library = new Library();
    library.AddBook("The Great Gatsby", "F. Scott", "Fitzgerald", 180);
    library.AddBook("To Kill a Mockingbird", "Harper", "Lee", 210);

    // Act
    var book = library.Borrow("The Great Gatsby");

    // Assert
    Assert.NotNull(book);
    Assert.Equal("The Great Gatsby", book.Title);
    Assert.Equal("F. Scott", book.FirstName);
    Assert.Equal("Fitzgerald", book.LastName);
    Assert.Equal(180, book.Pages);
  }

  [Fact]
  public void Borrow_InvalidTitle_ReturnsNull()
  {
    // Arrange
    var library = new Library();
    library.AddBook("The Great Gatsby", "F. Scott", "Fitzgerald", 180);
    library.AddBook("To Kill a Mockingbird", "Harper", "Lee", 210);

    // Act
    var book = library.Borrow("Pride and Prejudice");

    // Assert
    Assert.Null(book);
  }
}
