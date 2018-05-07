using JukeBox.classes;
using System;
using System;
namespace JukeBox
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Collection Songs = new Collection("h","cpp");
            Song kimd = new Song("Stars", "So Bright","");
            Song sis = new Song("Stars", "So Bright","");
            Song il = new Song("Stars", "So Bright","");
            Song ste = new Song("Stars", "So Bright","");


            Songs.AddSong(kimd);
            Songs.AddSong(sis);
            Songs.AddSong(il);
            Songs.AddSong(ste);

            Songs.Setter();

            
            while (Songs.Here)
            {
                Songs.MainBuild(); 
               
            }
        }
    }
}





