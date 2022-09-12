using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mini_Football.Models;
using Mini_Football.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Football.Controllers
{
    public class HomeController : Controller
    {
        private static ModelsIndexVM _modelindexvm;
        private static NewsDetailVM _newsdetail;

        List<Players> players = new List<Players>() { new Players { Id=1, FullName = "Lionel Messi", ImgUrl = "https://www.pngall.com/wp-content/uploads/5/Lionel-Messi.png", Position = "Forward" },
          new Players { Id=2, FullName="Cristiano Ronaldo" , ImgUrl="https://toppng.com/uploads/preview/cr7-cristiano-ronaldo-png-football-player-free-png-for-cristiano-ronaldo-11557197514axet066iqa.png",Position="Forward" },
          new Players { Id=3, FullName="Neymar JR" , ImgUrl="https://e7.pngegg.com/pngimages/731/600/png-clipart-neymar-paris-saint-germain-f-c-fc-barcelona-transparency-neymar-celebrities-tshirt-thumbnail.png", Position = "Forward" },
          new Players { Id=4, FullName="Andreas Iniesta" , ImgUrl="https://w7.pngwing.com/pngs/755/470/png-transparent-andres-iniesta-fc-barcelona-spain-national-football-team-football-player-el-clasico-fc-barcelona-tshirt-sport-team.png", Position = "Midefelder" },
          new Players {Id=5, FullName="Muhammad Salah" , ImgUrl="https://img.favpng.com/12/25/24/mohamed-salah-liverpool-f-c-anfield-a-s-roma-egypt-national-football-team-png-favpng-JFc6ej8KcbCfUzhwjEPTqBiir.jpg", Position = "Forward" }
        };


        List<Gallery> galerys = new List<Gallery>() { new Gallery { Id = 1, Title = "FIFA CHAMPION", SubTitle = "by Cosmin Capitanu", ImgUrl= "https://pbs.twimg.com/profile_images/1542772548601012231/oCX85H28_400x400.jpg" }, new Gallery {Id=2, Title="PRACTICE SESSION", SubTitle= "by Cosmin Capitanu", ImgUrl= "https://img.favpng.com/20/6/1/training-athlete-sport-coach-football-png-favpng-byRPGenKinpiqKUc6nnTsUJYr.jpg" } };
        List<SLider> sliders = new List<SLider>() { new SLider {Id=1, ImgUrl= "https://cdn.britannica.com/51/190751-050-147B93F7/soccer-ball-goal.jpg?q=60", Title="RISE AS ONE", SubTitle="JOIN US FOR THE BETTER FOOTBALL" },
        new SLider {Id=2, ImgUrl= "https://img.olympicchannel.com/images/image/private/t_social_share_thumb/f_auto/primary/qjxgsf7pqdmyqzsptxju", Title="FOOTBALL CLUB", SubTitle="JOIN US FOR THE BETTER FOOTBALL" },
        new SLider {Id=3, ImgUrl= "https://images.indianexpress.com/2021/09/football-stock-photo-1.jpg", Title="RISE AS ONE", SubTitle="JOIN US FOR THE BETTER FOOTBALL" }};
      
        List<News> newses = new List<News>() { new News { Id = 2, Title = "Cristiano Ronaldo's harsh new reality", Content = "Cristiano Ronaldo didn't get his wish and leave Manchester United this summer, and while that could change in January, things have gone rather poorly for the forward so far this campaign. " },
        new News {Id=1, Title="Messi madness at the inauguration of the World Cup final stadium", Content="Argentina will face Mexico in one of the most sought-after tickets of the group stage at the upcoming World Cup in Qatar." },
        new News{Id=3, Title="Neymar: Rudiger is scary, he's very big and strong", Content="Paris Saint-Germain star Neymar has stated that Real Madrid centre-back Antonio Rudiger is an intimidating opponent." },
        new News {Id=4 , Title="Iniesta: Barcelona, with Messi, should have won Champions League more" , Content="Barca won four of their five European Cups with Iniesta and Messi together at Camp Nou – in 2006, 2009, 2011 and 2015 – but have underachieved in the continental competition since completing the treble in Luis Enrique's first season as coach."} ,
        new News{Id=5, Title="“Not sure what you see” – Klopp disputes Mo Salah playing too wide this season" , Content="Mohamed Salah has found himself on the periphery of games so far for Liverpool in what has proven concerning for fans, but Jurgen Klopp does not feel his No. 11 has been pushed too far wide."} };
      
        public HomeController()
        {
            _modelindexvm = new ModelsIndexVM(players,sliders,galerys);
            _newsdetail = new NewsDetailVM(players, newses);

        }
        public IActionResult Index()
        {
            return View(_modelindexvm);
        }
        public IActionResult Detail(int? id)
        {
            if (id is null)  return NotFound();
            Players player = _newsdetail.Players.Find(p => id == p.Id);
            News news = _newsdetail.News.Find(n => id == n.Id);
            PlayerNews playerNews = new PlayerNews(player, news);
            if(player is null)return NotFound();
            if (news is null) return NotFound();
            return View(playerNews);
        }
    }     
}

