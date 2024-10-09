using System;

namespace SavingInterface
{
  interface IDisplayable
  {
    void Display();
    string HeaderSymbol { get; }
  }
}