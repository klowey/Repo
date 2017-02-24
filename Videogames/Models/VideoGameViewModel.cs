using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Videogames.Models
{
    public class VideoGameViewModel
    {
        public List<VideoGame> videoGames;
        public Microsoft.AspNetCore.Mvc.Rendering.SelectList publisher;

        public string videogamepublisher { get; set; }

        
    
    }
}
