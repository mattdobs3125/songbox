using JukeBox.menu;
using System;
using System.Collections.Generic;
using System.Text;

namespace JukeBox.ads
{
    public abstract class Mover : ISongChoices 
    {
        public string Title { get; set; }
        public string Artist  { get; set; }
        
        public DateTime SongStart { get; set; }
        public DateTime SongLength { get; set; }

        public void Time()
        {
            SongStart = DateTime.Now;
            SongLength = DateTime.Now.AddDays(8);
        }




    }



}
