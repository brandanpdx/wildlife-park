using System;
using System.Collections.Generic;
using Park.Models;


namespace Models
{
  public class Program 
  {
    public static List<Animal> Animals = new List<Animal>(6) {};
    public static void Main()
    {
      Animal aslan = new Animal("Aslan", "Lion", "Male", "Carnivore", 60);
      Animal geoffrey = new Animal("Geoffrey", "Giraffe", "Male", "Herbivores", 23);
      Animal mo = new Animal("Mo", "Otter", "Male", "Omnivore", 4);
      Animal frank = new Animal("Frank", "Black Bear", "Male", "Omnivore", 32);

      Animals.Add(aslan);
      Animals.Add(geoffrey);
      Animals.Add(mo);
      Animals.Add(frank);
      Console.WriteLine("Welcome to the Epicodus City Zoo Zookeeper Portal!");
      Init();
    }

    public static void Init()
    {
      Console.WriteLine("What would you like to do today?");
      Console.WriteLine("Press [A] to add an animal.  Press [D] to display all animals.  Press [L] to lookup a specific animal.  Press [Q] to Quit." );
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
      else if (userSelect == "Q")
      {
        Quit();
      }
      else 
      {
        Console.WriteLine("Invalid Selection!");
        Init();
      }
    }

    public static void Add()
    {
      Console.WriteLine("What is the name of your animal?");
      string newName = Console.ReadLine();
      Console.WriteLine("What is the species of your animal?");
      string newSpecies = Console.ReadLine();
      Console.WriteLine("What is the gender of your animal?");
      string newGender = Console.ReadLine();
      Console.WriteLine("What is the diet of your animal?");
      string newDiet = Console.ReadLine();
      Console.WriteLine("What is the age of your animal?");
      string userAge = Console.ReadLine();
      int newAge = int.Parse(userAge);
      Animal newAnimal = new Animal(newName, newSpecies, newGender, newDiet, newAge);
      Animals.Add(newAnimal);
      Console.Write(newName + " has been added to your animal list! \n" ); 
      Init();
    }

    public static void Display()
    {
      foreach (Animal animal in Animals)
      {
        Console.WriteLine("------------------------");
        Console.WriteLine("Name: " + animal.GetName());
        Console.WriteLine("Species : " + animal.GetSpecies());
        Console.WriteLine("Gender : " + animal.GetGender());
        Console.WriteLine("Diet : " + animal.GetDiet());
        Console.WriteLine("Age : " + animal.GetAge());
      }
      Init();
    }
    


    public static void Lookup()
    {
      Console.WriteLine("Would you like to lookup animal by name or species?");
      string lookupBy = Console.ReadLine();
      if (lookupBy == "name")
      {
        LookupByName();
      }
      else if (lookupBy == "species")
      {
        LookupBySpecies();
      }
      else 
      {
        Console.WriteLine("Sorry, please search by [name] or [species]");
        Lookup();
      }
    }
    public static void LookupByName()
    {
      List<Animal> AnimalNameMatchingSearch = new List<Animal>(1);

      Console.WriteLine("What is the name of the animal you're looking for?");
      string userAnimalLookup = Console.ReadLine();
      foreach (Animal animal in Animals) 
      {
        if (userAnimalLookup == animal.GetName())
        {
          AnimalNameMatchingSearch.Add(animal); 
        }
      }

      if (AnimalNameMatchingSearch.Count > 0)
      {
        foreach (Animal animal in AnimalNameMatchingSearch)
        {
          Console.WriteLine("------------------------");
          Console.WriteLine("Name: " + animal.GetName());
          Console.WriteLine("Species : " + animal.GetSpecies());
          Console.WriteLine("Gender : " + animal.GetGender());
          Console.WriteLine("Diet : " + animal.GetDiet());
          Console.WriteLine("Age : " + animal.GetAge());
        }
      }
      else 
      {
        Console.WriteLine("Sorry, no animals match that name.");
        LookupByName();
      }
    }
  

    public static void LookupBySpecies()
    {
      Console.WriteLine("What is the species of the animal you're looking for?");
      string userAnimalLookup = Console.ReadLine();
      foreach (Animal animal in Animals) 
      {
        if (userAnimalLookup == animal.GetSpecies())
        {
          Console.WriteLine("------------------------");
          Console.WriteLine("Name: " + animal.GetName());
          Console.WriteLine("Species : " + animal.GetSpecies());
          Console.WriteLine("Gender : " + animal.GetGender());
          Console.WriteLine("Diet : " + animal.GetDiet());
          Console.WriteLine("Age : " + animal.GetAge());
        }
        else
        {
          Console.WriteLine("Sorry, cannot find that species.");
        }
      }
    }
    
    public static void Quit()
    {
      Console.WriteLine("Peace out, trout!");
    }
   
  }
}