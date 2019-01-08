namespace vendingMachine.Interfaces
{
  interface IPurchasable
  {
    int Price { get; set; }
    string Name { get; set; }
    int GetPrice(int q);
  }
}