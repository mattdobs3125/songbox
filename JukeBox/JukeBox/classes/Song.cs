using JukeBox.ads;
using JukeBox.menu;
using System;
namespace JukeBox.classes
{
    public class Song:Mover
  {
        public string Title { get; set; }
        public string Artist { get; set; }
      

        public Song (string title,string artist)
    {
            Title = title;
            Artist = artist;
    }
  }
}