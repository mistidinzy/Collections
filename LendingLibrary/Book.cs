using System;
namespace LendingLibrary
{
  public class Book
  {
    public Book(string title, string firstName, string lastName, int pages)
    {
      Title = title;
      FirstName = firstName;
      LastName = lastName;
      Pages = pages;
    }

    string Title { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
    int Pages { get; set; }
  }
}

