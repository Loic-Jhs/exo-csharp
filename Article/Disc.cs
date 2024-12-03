using System;
using ArticleApp;

namespace DiscApp
{
  class Disc(string name, double price, int quantity, string label) : ArticleApp.Article(name, ArticleApp.ArticleType.Leisure, price, quantity)
  {
    public string Label = label;

    public static void Listening()
    {
      Console.WriteLine("Disc listening...");
    }

    public override void PublishDetails()
    {
      Console.WriteLine("Disc: Name : {0}, Price : {1}, Quantity : {2}, Type : {3}, Label : {4}", Name, Price, Quantity, ArticleType.Leisure, Label);
    }
  }
}