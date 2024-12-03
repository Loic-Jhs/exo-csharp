using System;

namespace DiscApp
{
  interface IRentable
  {
    void CalculateRent();
  }
  class Disc(string name, double price, int quantity, string label) : ArticleApp.Article(name, ArticleApp.ArticleType.Leisure, price, quantity)
  {
    public string Label = label;

    public static void Listening()
    {
      Console.WriteLine("Disc listening...");
    }
  }
}