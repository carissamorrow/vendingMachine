namespace vendingMachine
{
  interface vendingMachine
  {
    int Price { get; set; }
    string UPC { get; set; }
    int GetPrice(int q);
  }
}