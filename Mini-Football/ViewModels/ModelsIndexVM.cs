using Mini_Football.Models;
using System.Collections.Generic;

namespace Mini_Football.ViewModels
{
    public class ModelsIndexVM
    {        
        public List<Players> Player { get; set; }
        public List<SLider> Slider { get; set; }
        public List<Gallery> Gallery { get; set; }

        public ModelsIndexVM(List<Players> players, List<SLider> sliders, List<Gallery> galeries)
        {           
            Player = players;
            Slider = sliders;
            Gallery = galeries;  
        }
    }
}
