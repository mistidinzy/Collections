using System;

namespace LendingLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, Welcome to the Library!");

      userMenu();
     



    }

    static void userMenu()
    {
      Console.WriteLine("Please choose one of these options.");
      Console.WriteLine("1. View Catalog");
      Console.WriteLine("2. Add a Book");
      Console.WriteLine("3. Borrow a Book");
      Console.WriteLine("4. Delete a Book");
    }

  }
}