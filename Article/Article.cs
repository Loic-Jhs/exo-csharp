using System;

namespace ArticleApp
{
  public enum ArticleType
  {
    Food,
    Drugstore,
    Clothing,
    Leisure
  }

  interface IRentable
  {
    double CalculateRent();
  }

  class Article : IRentable
  {
    public string Name;
    public double Price;
    public int Quantity;
    public ArticleType Type { get; set; }

    //Constructor
    public Article(string name, ArticleType type, double price, int quantity)
    {
      Name = name;
      Type = type;
      Price = price;
      Quantity = quantity;
    }

    //Methods
    public void DisplayItem()
    {
      Console.WriteLine($"Name: {Name}, article Type: {Type}, Price: {Price:F2}€, Quantity: {Quantity}");
    }
    public void AddItem(int amount)
    {
      if (amount > 0)
      {
        Quantity += amount;
        Console.WriteLine($"{amount} added at {Name}. New quantity: {Quantity}");
      }
      else
      {
        Console.WriteLine("The quantity must be positive!");
      }
    }
    public void DeleteItem(int amount)
    {
      if (amount > 0 && amount <= Quantity)
      {
        Quantity -= amount;
        Console.WriteLine($"{amount} remove of {Name}. New quantity: {Quantity}");
      }
      else
      {
        Console.WriteLine("Invalid quantity. Check that quantity is positive and does not exceed stock.");
      }
    }

    public virtual double CalculateRent()
    {
      return Price * 0.90;
    }
  }
}