using System;

using System;

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
  }
}
