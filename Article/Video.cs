using System;

namespace VideoApp
{
  interface IRentable
  {
    void CalculateRent();
  }
  class Video(string name, double price, int quantity, int duration) : ArticleApp.Article(name, ArticleApp.ArticleType.Leisure, price, quantity)
  {
    public int Duration = duration;

    public void Display()
    {
      Console.WriteLine($"Video duration: {Duration}mn");
    }
  }
}