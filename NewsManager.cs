using lettheworld_burn;

public class NewsManager
{
    public delegate void NewsAddedEventHandler(News news);

    public delegate void NewsRemovedEventHandler(News news);

    public List<News> NewsList { get; set; }

    public NewsManager()
    {
        NewsList = new List<News>();
    }

    public void AddNews(News news)
    {
        NewsList.Add(news);
    }
    public News FindNewsByTitle(string title)
    {
        foreach (News news in NewsList)
        {
            if (news.Title == title)
            {
                return news;
            }
        }
        return null;
    }

    public bool EditNews(string title, string newSummary, DateTime newDate)
    {
        News news = FindNewsByTitle(title);
        if (news != null)
        {
            news.Summary = newSummary;
            news.Date = newDate;
            return true;
        }
        return false;
    }

    public bool DeleteNews(string title)
    {
        News news = FindNewsByTitle(title);
        if (news != null)
        {
            NewsList.Remove(news);
            return true;
        }
        return false;
    }
}