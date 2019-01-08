using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Drinks : Consumable, IPurchasable
  {
    public decimal GetPrice(decimal q)
    {
      return Price;
    }

    public Drinks(decimal price, string name) : base(price, name)
    {
    }
  }

}