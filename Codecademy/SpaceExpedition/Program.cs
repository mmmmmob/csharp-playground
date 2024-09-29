using System;
using System.ComponentModel;

public class SpaceExpedition
{
  public static void Main(string[] args)
  {
    bool isAtmosphereBreathable = true;
    bool isGravityStable = false;
    bool resourcesSufficient = true;

    bool isHabitable = isAtmosphereBreathable && isGravityStable;
    Console.WriteLine($"Habitable? : {isHabitable}");

    bool suitableForExpansion = isGravityStable && resourcesSufficient;
    Console.WriteLine($"Suitable for Expansion? : {suitableForExpansion}");

    int currentCrew = 5;
    int maxCrewCapacity = 10;

    bool canAcceptMoreCrew = currentCrew < maxCrewCapacity;
    Console.WriteLine($"Can Accept More Crew? : {canAcceptMoreCrew}");
  }
}