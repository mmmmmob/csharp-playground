using System;

public class GalacticTravelAgency
{
  public static void Main(string[] args)
  {
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);
    Console.WriteLine("-------------");

    passengerAge += 1;
    Console.WriteLine($"Edited Age: {passengerAge}");

    // Explicitly convert
    double passengerAgeDouble = (double)passengerAge;
    Console.WriteLine($"Age in {passengerAgeDouble.GetType()} (Explicit): {passengerAgeDouble}");

    // Implicitly convert
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine($"Age in {passengerAgeDouble2.GetType()} (Implicit): {passengerAgeDouble2}");

    // Using built-in method
    string passengerAgeString = passengerAge.ToString();
    Console.WriteLine($"Age in {passengerAgeString.GetType()}: {passengerAgeString}");
  }
}