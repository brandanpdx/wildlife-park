namespace Park.Models
{
  public class Animal
  {
    private string _name;
    private string _species;
    private string _gender;
    private string _diet;
    private int _age;

    public Animal(string name, string species, string gender, string diet, int age)
    {
      _name = name;
      _species = species;
      _gender = gender;
      _diet = diet;
      _age = age;
    }
    public string GetName()
    {
      return _name;
    }
    public string GetSpecies()
    {
      return _species;
    }
    public string Gender()
    {
      return _gender;
    }
    public string GetDiet()
    {
      return _diet;
    }
    public int GetAge()
    {
      return _age;
    }
  }
}