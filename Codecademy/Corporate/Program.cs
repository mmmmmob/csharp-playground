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

      // Employees type declaration
      // upcasting helps allowing us to use derived methods and base methods (can use both engineer specifically made method and general method on Employee)
      Employee employee1 = new Engineer();
      employee1.ClockIn();
      employee1.Work();
      employee1.SubmitDailyReport();
      Console.WriteLine(); //Line break

      // downcasting allows us to convert a base type reference back to a specific type, enabling access to specific methods.
      Engineer? engineer1 = employee1 as Engineer;
      // if cannot downcast it'll return null
      if (engineer1 != null)
      {
        engineer1.SubmitDailyReport();
        Console.WriteLine();
      }
      else { Console.WriteLine("Downcasting failed."); }

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

      // Adding employees  to a list
      List<Employee> employees = new List<Employee> { employee1, employee2, employee3 };
      foreach (Employee employee in employees)
      {
        // use 'is' if wanting to return bool for conditional statement
        if (employee is Engineer)
        {
          Console.WriteLine("This is an Engineer");
        }
        else if (employee is Intern)
        {
          Console.WriteLine("This is an Intern");
        }
        else if (employee is Manager)
        {
          Console.WriteLine("This is a Manager");
        }

        employee.ClockIn();
        employee.Work();
        employee.SubmitDailyReport();
      }
    }
  }
}
