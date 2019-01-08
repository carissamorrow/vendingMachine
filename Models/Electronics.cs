using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Electronics : IPurchasable
  {
    public int Price { get; set; }
    public string Name { get; set; }

    public int GetPrice(int q)
    {
      return Price;
    }

    public Electronics(int price, string name) : base(price, name)
    {

    }
  }

}