using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mini_Football.DAL;
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
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;        

        } 
        
      
        
      
        
        public IActionResult Index()
        {
            List<Players> players = _context.Players.ToList();
            List<Gallery> galeries = _context.Galeries.ToList();
            List<SLider> sliders = _context.Sliders.ToList();
            _modelindexvm = new ModelsIndexVM(players,sliders, galeries );
            return View(_modelindexvm);
        }
        public IActionResult Detail(int? id)
        {
            List<News> news = _context.News.ToList();
            List<Players> players = _context.Players.ToList();
            _newsdetail = new NewsDetailVM(players, news);
            if (id is null)  return NotFound();
            Players player = _newsdetail.Players.Find(p => id == p.Id);
            News news2 = _newsdetail.News.Find(n => id == n.Id);
            PlayerNews playerNews = new PlayerNews(player, news2);
            if(player is null)return NotFound();
            if (news is null) return NotFound();
            return View(playerNews);
        }
    }     
}

