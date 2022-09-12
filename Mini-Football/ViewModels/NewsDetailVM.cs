using Mini_Football.Models;
using System.Collections.Generic;

namespace Mini_Football.ViewModels
{
    public class NewsDetailVM
    {
        public List<Players> Players { get; set; }
        public List<News> News { get; set; }

        public NewsDetailVM(List<Players> player, List<News> news)
        {
            Players = player;
            News = news;
        }
    }
   

}
