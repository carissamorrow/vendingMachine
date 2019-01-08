namespace vendingMachine
{
  abstract class Consumable
  {
    public string Name { get; set; }
    public int Price { get; set; }

    public Consumable(int price, string name)
    {
      Price = price;
      Name = name;
    }
  }
}