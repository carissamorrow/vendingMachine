using System;
using System.Collections.Generic;
using vendingMachine.Models;

namespace vendingMachine
{
  class Program
  {
    static void Main(string[] args)
    {

      Machine myMachine = new Machine("My Fancy Vending Machine");
      Electronics iPhone = new Electronics(32, "Option 1: iphone5");
      Electronics Headphones = new Electronics(15, "Option 2: fancy headphones");
      Food Banana = new Food(2, "Option 3. Banana");
      Food Apple = new Food(3, "Option 4. Apple");
      Drinks Redbull = new Drinks(4, "Option 5. Redbull");
      Drinks Snapple = new Drinks(2, "Option 6. Snapple");

      myMachine.AddProduct("Electronics", iPhone);
      myMachine.AddProduct("Electronics", Headphones);
      myMachine.AddProduct("Food", Banana);
      myMachine.AddProduct("Food", Apple);
      myMachine.AddProduct("Drinks", Redbull);
      myMachine.AddProduct("Drinks", Snapple);

      Console.Clear();
      Console.WriteLine("Welcome to my Vending Machine");
      foreach (var pair in myMachine.Products)
      {
        System.Console.WriteLine(pair.Key + "s");
        pair.Value.ForEach(product =>
        {
          System.Console.WriteLine(product.Name);
          System.Console.WriteLine(product.Price + " dollars");
        });
      }
      Console.WriteLine("Let's Make A Purchase, Choose Your Guilty Pleasure");

      int choice;
      if (Int32.TryParse(Console.ReadLine(), out choice))
      {
        System.Console.WriteLine("Thanks For Choosing A Product!");
        //how to show the product name purchased?
      }

    }
  }
}



