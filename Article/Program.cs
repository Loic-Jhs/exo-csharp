using ArticleApp;
class Program
{
  public static void Main(string[] args)
  {
    Article newArticle = CreateArticleFromUserInput();
    Console.WriteLine("Article sucesful created!");
    newArticle.DisplayItem();
    GeneratedTable();
  }

  public static Article CreateArticleFromUserInput()
  {
    Console.WriteLine("Creation of new article");
    try
    {
      string name;
      do
      {
        Console.Write("Enter the article name : ");
        name = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(name))
        {
          Console.WriteLine("The item name cannot be empty. Please try again.");
        }
      } while (string.IsNullOrWhiteSpace(name));

      Console.Write("Enter the article type (Food, Drugstore, Clothing or Leisure) : ");

      if (!Enum.TryParse(Console.ReadLine(), out ArticleType type))
      {
        Console.WriteLine("Enter a valid article type!");
        throw new Exception();
      }

      Console.Write("Enter the article price : ");
      double price = Convert.ToDouble(Console.ReadLine());

      Console.Write("Enter the article quantity : ");
      int quantity = Convert.ToInt32(Console.ReadLine());
      return new Article(name, type, price, quantity);
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
      throw;
    }
  }

  public static void GeneratedTable()
  {
    Article[] articles = new Article[4];
    articles[0] = new Article("Article 1", ArticleType.Food, 4.99, 200);
    articles[1] = new Article("Article 2", ArticleType.Clothing, 19.99, 150);
    articles[2] = new Article("Article 3", ArticleType.Drugstore, 2.39, 500);
    articles[3] = new Article("Article 4", ArticleType.Leisure, 8.99, 130);

    foreach (var article in articles)
    {
      article.DisplayItem();
    }

    articles[0].AddItem(50);
    articles[3].DeleteItem(10);

    foreach (var article in articles)
    {
      article.DisplayItem();
    }
  }
}