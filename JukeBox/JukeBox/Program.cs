using JukeBox.classes;
using System;

namespace JukeBox
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Collection Songs = new Collection("h","cpp");
            Song Fus = new Song("Beeps in hollywood", "Beeples","Enter 3 to play this song");
            Song Ro = new Song("Beep upTown", "Beeps in Paris","Enter 4 to play this song");
            Song Dah = new Song("Faster than beep", "Lost B33p's","Enter 5 to play this song");
            


            Songs.AddSong(Fus);
            Songs.AddSong(Ro);
            Songs.AddSong(Dah);
           

            Songs.Setter();

            
            while (Songs.Here)
            {
                Songs.MainBuild(); 
               
            }
        }
    }
}





