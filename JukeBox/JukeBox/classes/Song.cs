using JukeBox.ads;
using JukeBox.menu;
using System;
using System.Threading;
namespace JukeBox.classes
{
    public class Song:Mover
  {
        public string Direction { get; set; }


        public Song (string title,string artist,string direction)
    {
            Title = title;
            Artist = artist;
            Direction = direction;
           ; 



        }
        


  }
}
