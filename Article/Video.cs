using System;
using ArticleApp;

namespace VideoApp
{
  class Video(string name, double price, int quantity, int duration) : ArticleApp.Article(name, ArticleApp.ArticleType.Leisure, price, quantity)
  {
    public int Duration = duration;

    public void Display()
    {
      Console.WriteLine($"Video duration: {Duration}mn");
    }

    public override void PublishDetails()
    {
      Console.WriteLine("Disc: Name : {0}, Price : {1}, Quantity : {2}, Type : {3}, Duration : {4}", Name, Price, Quantity, ArticleType.Leisure, Duration);
    }
  }
}