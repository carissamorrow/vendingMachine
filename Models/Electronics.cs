using vendingMachine.Interfaces;

namespace vendingMachine.Models
{
  class Electronics : IPurchasable
  {
    public decimal Price { get; set; }
    public string Name { get; set; }

    public decimal GetPrice(decimal q)
    {
      return Price;
    }

    public Electronics(decimal price, string name)
    {
      Price = price;
      Name = name;
    }
  }

}