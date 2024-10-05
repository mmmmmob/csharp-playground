using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      double recPeso;
      double circPeso;
      double triPeso;

      double areaRec = Rectangles(2500, 1500, out recPeso);
      double areaCirc = Circles(375, out circPeso);
      double areaTri = Triangles(750, 500, out triPeso);

      double totalCost = TotalWhatever(recPeso, circPeso, triPeso);
      double totalArea = TotalWhatever(areaRec, areaCirc, areaTri);

      Console.WriteLine($"If you want to build the Teotihuacan, you'd have to spend {totalCost} Pesos for the total area of {totalArea} sq.m.");
    }

    static double Rectangles(double length, double width, out double peso)
    {
      double result = length * width;
      peso = Math.Round(180 * result, 2);
      return result;
    }

    static double Circles(double radius, out double peso)
    {
      double result = Math.PI * Math.Pow(radius, 2);
      peso = Math.Round(180 * result, 2);
      return result;
    }

    static double Triangles(double bottom, double height, out double peso)
    {
      double result = 0.5 * bottom * height;
      peso = Math.Round(180 * result, 2);
      return result;
    }

    static double TotalWhatever(double totalRec = 0, double totalCirc = 0, double totalTri = 0)
    {
      return totalRec + totalCirc + totalTri;
    }
  }
}
