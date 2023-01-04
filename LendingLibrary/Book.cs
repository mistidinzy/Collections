using System;
namespace LendingLibrary
{
  public class Book
  {
    int ID { get; set; }
    string Title { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    int Pages { get; set; }

    public Book(int bookID, string title, string firstName, string lastName, int pages)
    {
      ID = bookID;
      Title = title;
      FirstName = firstName;
      LastName = lastName;
      Pages = pages;
    }
  }
}

