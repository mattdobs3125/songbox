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
       
        public int PlaceNumber { get; private set; }
        public bool Check { get; private set; }
        public bool Here { get; set; }
        private List<Song> Songs = new List<Song>();
        private List <ISongChoices>Choices = new List<ISongChoices>();
        private Selector Main { get; set; }
        private Selector SongMenu { get; set; }

        

        public Collection(string title, string artist)
        {
            Title = title;
            Artist = artist;
            Check = false;
            Here = true;
            Main = BuildMain();
        }
        public void MainSelector()
        {//button choice 
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
                if (choice != null)
                {
                    choice.Invoke();
                }
            }
        }

        Selector BuildMain()
        {
            return new Selector (
                "Main Menu!!",new List<SelectorChoices>
                {
                    new SelectorChoices(SongSelection,"Song Choices"),
                    new SelectorChoices(ExitJukeBox,"Leave lukeBox")
                }
             );
        }
        public void Setter()
        {
            BuildSongMenu();
        }
        void  BuildSongMenu()
        {
            SongMenu = new Selector(
                "Song Menu", new List<SelectorChoices>
                {
                    new SelectorChoices(ShowSongs,"Song List!"),
                    new SelectorChoices(Leave,"Leave the song")
                }
             );
        }
        //adds the song
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
        public void MainBuild()
        {
            Action selection = Main.ChoiceSelection();
            if (selection != null)
            {
                selection.Invoke();
            }
        }



         private void ExitJukeBox()
        {
            Console.WriteLine("Thanks for listening");
            Here = false;

        }

        private void Leave()
        {
            Console.WriteLine("You've left the collection!!");
            Check = false;

        }

    }
}
