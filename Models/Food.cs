using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Food : Consumable, IPurchasable
  {
    public int GetPrice(int q)
    {
      return Price;
    }

    public Food(int price, string name) : base(price, name)
    {
    }
  }

}