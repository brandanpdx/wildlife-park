using System;
using System.Collections.Generic;
using Park.Models;


namespace Models
{
  public class Program 
  {
    public static void Main()
    {
      Animal aslan = new Animal("Aslan", "Lion", "Male", "Carnivore", 60);
      Animal geoffrey = new Animal("Geoffrey", "Giraffe", "Male", "Herbivores", 23);
      Animal mo = new Animal("Mo", "Otter", "Male", "Omnivore", 4);
      Animal frank = new Animal("Frank", "Black Bear", "Male", "Omnivore", 32);

      List<Animal> Animals = new List<Animal>(6) {aslan, geoffrey, mo, frank};
      Console.WriteLine("Welcome to the Epicodus City Zoo Zookeeper Portal!");
      Init();
    }

      public static void Init()
      {
      Console.WriteLine("What would you like to do today?");
      Console.WriteLine("Press [A] to add an animal.  Press [D] to display all animals.  Press [L] to lookup a specific animal." );
      string userSelect = Console.ReadLine();
      if (userSelect == "A")
      {
        Add();
      }
      else if (userSelect == "D")
      {
        Display();
      }
      else if (userSelect == "L")
      {
        Lookup();
      }
      else 
      {
        Console.WriteLine("Invalid Selection!");
        Init();
      }
    }

    public static void Add()
    {
      Console.WriteLine("This is the add function placeholder");
    }

    public static void Display()
    {
      Console.WriteLine("This is the display function placeholder");
    }
    
    public static void Lookup()
    {
      Console.WriteLine("This is the lookup function placeholder");
    }
   
  }
}