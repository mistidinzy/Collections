using System;
namespace LendingLibrary
{
  public class Book
  {
    public int ID { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Pages { get; set; }

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

