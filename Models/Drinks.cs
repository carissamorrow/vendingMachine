using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Drinks : Consumable, IPurchasable
  {
    public int GetPrice(int q)
    {
      return Price;
    }

    public Drinks(int price, string name) : base(price, name)
    {
    }
  }

}