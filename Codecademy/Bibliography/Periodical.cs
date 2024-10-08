using System;

namespace BiblioInheritance
{
  class Periodical : Resource
  {
    // PROPERTIES
    public string Period { get; private set; }

    // CONSTRUCTOR
    public Periodical(string title, string category, string period) : base(title, category)
    {
      Period = period;
    }

    // METHOD (OVERRRIDDEN)
    public override void UpdateStatus()
    {
      Status = Status == "Available" ? "In-use" : "Available";
    }

  }

}