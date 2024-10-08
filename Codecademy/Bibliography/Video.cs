using System;

namespace BiblioInheritance
{
  class Video : Resource
  {
    // PROPERTIES
    public string Director { get; private set; }
    public int Runtime { get; private set; }
    public string MediaType { get; private set; }

    // CONSTRUCTOR
    public Video(string title, string category, string director, int runtime, string mediaType) : base(title, category)
    {
      Director = director;
      Runtime = runtime;
      MediaType = mediaType;
    }

    // METHOD (OVERRIDDEN)
    public override void GetInfo()
    {
      Console.WriteLine($"Title: {Title}\nCategory: {Category}\nDirector:{Director}\nRuntime: {Runtime}\nMedia Type: {MediaType}\nStatus: {Status}");
    }
  }
}
