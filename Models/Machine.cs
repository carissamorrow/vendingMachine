using System.Collections.Generic;
using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Machine
  {
    public string Name { get; set; }
    public Dictionary<string, List<IPurchasable>> Products { get; private set; }

    public List<IPurchasable> Inventory { get; set; }
    public void AddProduct(string type, IPurchasable product)
    {
      if (!Products.ContainsKey(type))
      {
        Products.Add(type, new List<IPurchasable>());
      }
      Products[type].Add(product);
    }
    public void ShowBalance(int type, IPurchasable product)
    {
      // if (Products.Add)
      // {
      //   System.Console.WriteLine("Your Balance Is...");
      // }
    }
    public Machine(string name)
    {
      Name = name;
      Products = new Dictionary<string, List<IPurchasable>>();
    }
  }
}