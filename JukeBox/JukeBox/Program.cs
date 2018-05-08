using JukeBox.classes;
using System;

namespace JukeBox
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Collection Songs = new Collection("h","cpp");
            Song fus = new Song("Beeps in hollywood", "Beeples");
            Song ro = new Song("Beep upTown", "Beeps in Paris");
            Song da = new Song("Faster than beep", "Lost B33p's");
            


            Songs.AddSong(fus);
            Songs.AddSong(ro);
            Songs.AddSong(da);
           

            Songs.Setter();

            
            while (Songs.Here)
            {
                Songs.MainBuild(); 
               
            }
        }
    }
}





