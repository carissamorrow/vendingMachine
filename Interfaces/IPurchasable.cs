namespace vendingMachine.Interfaces
{
  interface IPurchasable
  {
    decimal Price { get; set; }
    string Name { get; set; }
    decimal GetPrice(decimal q);
  }
}