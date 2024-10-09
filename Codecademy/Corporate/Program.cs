using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
  class Program
  {
    static void Main(string[] args)
    {
      //*********************************
      //******* Task3 Test Code *********
      //*********************************
      Employee hrRep = new HR();

      hrRep.ClockIn();
      hrRep.Work();
      hrRep.SubmitDailyReport();
      Console.WriteLine(); //Line break
      //*********************************
      //******* Task3 Test Code *********
      //*********************************

      // Employees List
      // upcasting helps allowing us to use derived methods and base methods (can use both engineer specifically made method and general method on Employee)
      Employee employee1 = new Engineer();
      employee1.ClockIn();
      employee1.Work();
      employee1.SubmitDailyReport();
      Console.WriteLine(); //Line break

      Employee employee2 = new Manager();
      employee2.ClockIn();
      employee2.Work();
      employee2.SubmitDailyReport();
      Console.WriteLine(); //Line break

      Employee employee3 = new Intern();
      employee3.ClockIn();
      employee3.Work();
      employee3.SubmitDailyReport();
      Console.WriteLine(); //Line break

      // Placeholder for adding employees to the list
    }
  }
}
