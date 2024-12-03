using System;
using ArticleApp;

namespace BookApp
{
  class Book : ArticleApp.Article
  {
    public string Isbn { get; set; }
    public int PagesNb { get; set; }

    // Constructeur
    public Book(string name, double price, int quantity, string isbn, int pagesNb)
    : base(name, ArticleApp.ArticleType.Leisure, price, quantity)
    {
      Isbn = isbn;
      PagesNb = pagesNb;
    }

    public override void PublishDetails()
    {
      Console.WriteLine("Book: Name : {0}, Price : {1}, Quantity : {2}, Type : {3}, ISBN : {4}, Number of pages : {5}", Name, Price, Quantity, ArticleType.Leisure, Isbn, PagesNb);
    }
  }
}
