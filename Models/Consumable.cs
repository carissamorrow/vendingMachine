namespace vendingMachine
{
  abstract class Consumable
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Consumable(decimal price, string name)
    {
      Price = price;
      Name = name;
    }
  }
}