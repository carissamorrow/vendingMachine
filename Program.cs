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
      Electronics iPhone = new Electronics(32, "iphone5");
      Electronics Headphones = new Electronics(15, "fancy headphones");
      Food Banana = new Food(2, "Banana");
      Food Apple = new Food(3, "Apple");
      Drinks Redbull = new Drinks(4, "Redbull");
      Drinks Snapple = new Drinks(2, "Snapple");

      myMachine.AddProduct("Food", Banana);
      myMachine.AddProduct("Food", Apple);
      myMachine.AddProduct("Drinks", Redbull);
      myMachine.AddProduct("Drinks", Snapple);
      // myMachine.AddProduct("Electronics", Iphone);
      // myMachine.AddProduct("Electronics", Headphones);
      Console.Clear();
      Console.WriteLine("Welcome to my Vending Machine");

      foreach (var pair in myMachine.Products)
      {
        System.Console.WriteLine(pair.Key + "s");
        pair.Value.ForEach(product =>
        {
          System.Console.WriteLine(product.Name);
          System.Console.WriteLine(product.Price);
        });
      }
    }
  }
}

