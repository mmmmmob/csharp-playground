using System;

namespace DatingProfile
{
  class Profile
  {
    // FIElDS + PROPERTIES
    private string name;
    private int age;
    public int Age
    {
      get { return age; }
      set
      {
        if (value >= 18)
        {
          age = value;
        }
        else { age = 0; }
      }
    }
    private string city;
    private string country;
    private string pronouns;
    private string[] hobbies;

    // CONSTRUCTORS
    public Profile(string name, int age, string city, string country, string pronouns = "they/them")
    {
      this.name = name;
      this.Age = age;
      this.city = city;
      this.country = country;
      this.pronouns = pronouns;
      this.hobbies = new string[] { };
    }

    public Profile(string name, int age) : this(name, age, "N/A", "N/A")
    {
      this.name = name;
      this.Age = age;
    }

    // METHODS
    public string ViewProfile()
    {
      if (this.age == 0) { return "This user is not eligible to use OOYA."; }
      else
      {
        string profile = $"Name: {this.name} ({this.pronouns})\nAge: {this.age}\nCity: {this.city}, {this.country}\n";
        string userHobbies = hobbies.Length == 0 ? "Hobby: N/A" : "Hobby: ";
        foreach (string hobby in this.hobbies)
        {
          userHobbies += $"\n- {hobby}";
        }
        return profile + userHobbies;
      }
    }

    public void SetHobbies(string[] hobbies)
    {
      this.hobbies = hobbies;
    }
  }
}
