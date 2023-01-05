using System;

namespace LendingLibrary
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, Welcome to the Library!");

      userMenu();
      //LoadSeedBooks();
    }

    static void userMenu()
    {
      Console.WriteLine("Please choose one of these options.");
      Console.WriteLine("1. View Catalog");
      Console.WriteLine("2. Add a Book");
      Console.WriteLine("3. Borrow a Book");
      Console.WriteLine("4. Delete a Book");

      string input = Console.ReadLine();

      switch (input)
      {
        case "1":
          Console.WriteLine("You chose option 1. View Catalog");
          break;
        case "2":
          Console.WriteLine("You chose option 2. Add a Book");
          break;
        case "3":
          Console.WriteLine("You chose option 3. Borrow a Book");
          break;
        case "4":
          Console.WriteLine("You chose option 4. Delete a Book");
          break;
        default:
          Console.WriteLine("Invalid input. Please try again.");
          break;
      }
    }
  }
}