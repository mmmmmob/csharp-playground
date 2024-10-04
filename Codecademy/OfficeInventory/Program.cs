using System;
using System.Collections.Generic;

public class InventoryManagement
{
  public static void Main(string[] args)
  {
    List<string> inventoryList = new List<string> { "Printer", "Laptop", "Desk Chair", "Monitor", "Keyboard" };

    Console.WriteLine(inventoryList.Count);
    bool hasDeskChair = inventoryList.Contains("Desk Chair");
    Console.WriteLine(hasDeskChair);
    bool removed = inventoryList.Remove("Printer");
    Console.WriteLine(removed);

    foreach (string item in inventoryList)
    {
      Console.WriteLine(item);
    }

    List<string> newItems = new List<string> { "Mouse", "Desk Lamp" };
    // Add and remove above two items
    inventoryList.AddRange(newItems);
    inventoryList.RemoveRange(4, 2); // remove at index 4 for 2 items

    List<string> topInventory = inventoryList.GetRange(0, 3); // get list from index 0 for 3 items
    foreach (string item in topInventory)
    {
      Console.WriteLine(item);
    }
  }
}