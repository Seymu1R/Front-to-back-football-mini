using Mini_Football.Models;

namespace Mini_Football.ViewModels
{
    public class PlayerNews
    {
        public int Id { get; set; }

        public Players Player { get; set; }

        public News News { get; set; }

        public PlayerNews(Players player ,News news)
        {
            Player = player;
            News = news;
        }
    }
}
