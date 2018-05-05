using JukeBox.ads;
using JukeBox.menu;
using JukeBox.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace JukeBox.classes
{
    class Collection:Mover
    {
       
        public int PlaceNumber { get; set; }

        public bool Here { get; set; }
        private List<Song> Songs = new List<Song>();
        private List <ISongChoices>Choices = new List<ISongChoices>();
        

        private Selector Main { get; set; }


        public Collection(string title, string artist)
        {
            Title = title;
            Artist = artist;
              
        }
        public void MainSelector()
        {
            Action choice = Main.ChoiceSelection();
            if (choice != null)
            {
                choice.Invoke();
            }
        }

        private void SongSelection()
        {
            Console.Clear();
            Here = true;
            while (Here)
            {
                Action choice = Main.ChoiceSelection();
                
            }
        }



        internal void AddSong(Song song)
        {
            Songs.Add(song);
            AddSong ((Mover)song);
        } 

        internal void AddSong (Mover  Item)
        {
            Choices.Add(Item);
        }

        public void ShowSongs ()
        {
            Console.Clear();
            int counter = 1;
            foreach (Song song in Songs)
            {
                Console.WriteLine($"Number {counter++} {song.Title} ");
            }
        }




    }
}
