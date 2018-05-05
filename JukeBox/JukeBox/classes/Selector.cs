using System;
using System.Collections.Generic;
using System.Text;
//menu
namespace JukeBox.classes
{
    class Selector
    {
        private string Title { get; set; }
        private List <SelectorChoices> Choice { get; set; }
        public Selector (string title ,List<SelectorChoices> choice)
        {
            Title = title;
            Choice = choice;
        }
        void PrintSongs()
        {
            int count = 1;
            foreach (var choice  in Choice)
            {
                Console.WriteLine($"{count++} {choice.Attributes}");
            }
        }
        public Action ChoiceSelection()
        {
            PrintSongs();
            string Io = Console.ReadLine();
            int index = -1;
            bool check = Int32.TryParse(Io, out index);
            if (!check||index <= 0||index >Choice.Count)
            {
                Console.WriteLine(" Make your selection!!!");
                return null;
            }
            return Choice [ index - 1].Selection;
        }   
    }
}