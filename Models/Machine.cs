using System.Collections.Generic;
using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class vendingMachine
  {
    public string Name { get; set; }
    public Dictionary<string, List<Consumable>> Products { get; private set; }

    public List<IPurchasable> Inventory { get; set; }
    public void AddProduct(string type, Consumable product)
    {
      if (!Products.ContainsKey(type))
      {
        Products.Add(type, new List<Consumable>());
      }
      Products[type].Add(product);
    }

    public vendingMachine(string name)
    {
      Name = name;
      Products = new Dictionary<string, List<Consumable>>();
    }
  }
}