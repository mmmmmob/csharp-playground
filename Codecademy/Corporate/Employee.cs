using System;

namespace CorporatePolymorphism
{
  public abstract class Employee
  // abstract class = whatever inherit from this has to implement whatever flagged abstract
  {
    public abstract void SubmitDailyReport();
    // inherited class has to define this method to its own
    public virtual void Work()
    // inherited class can override this method
    {
      Console.WriteLine("Employee is working.");
    }
    public void ClockIn()
    // this only inherit and cannot be override
    {
      Console.WriteLine("Employee clocks in.");
    }
  }
}
