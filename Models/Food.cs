using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Food : Consumable, IPurchasable
  {
    public decimal GetPrice(decimal q)
    {
      return Price;
    }

    public Food(decimal price, string name) : base(price, name)
    {
    }
  }

}