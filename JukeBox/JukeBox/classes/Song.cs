﻿using JukeBox.ads;
using JukeBox.menu;
using System;
using System.Threading;
namespace JukeBox.classes
{
    public class Song:Mover
  {
      
        public string PlaceNumber { get; set; }

        public Song (string title,string artist,string attribute)
    {
            Title = title;
            Artist = artist;
            attribute = artist + title; 



        }
        


  }
}
