using System;
namespace LendingLibrary
{
  public class Book
  {
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Pages { get; set; }

    public Book(string title, string firstName, string lastName, int pages)
    {
      Title = title;
      FirstName = firstName;
      LastName = lastName;
      Pages = pages;
    }
  }
}

