using System;
using System.Collections.Generic;

class GroceryList
{
  static void Main()
  {
    string[] myGroceryList = { "eggs", "milk", "juice", "bananas", "cereal" };
    int[] groceryListPrices = { 3, 4, 5, 6, 4 };

    Console.WriteLine("My grocery list.");

    for (int index = 0; index < myGroceryList.Length; index++)
    {
      Console.WriteLine(myGroceryList[index]);
    }

    int total = 0;
    foreach (int price in groceryListPrices)
    {
      total = total + price;
    }

  }
}