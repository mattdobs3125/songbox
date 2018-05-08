using System;
using System.Collections.Generic;
using System.Text;
using JukeBox.classes;
using System.Threading;

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
            foreach (var choice  in Choice)
            {
                Console.WriteLine($" {choice.Attributes}");
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
                Console.WriteLine(" Playing!!!");
                
                if (index == 4)
                {
                    index = 1;
                    
                    Console.Beep(658, 125);
                    Console.Beep(1320, 500);
                    Thread.Sleep(250);
                    Console.Beep(990, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 250);
                    Thread.Sleep(250);
                    Console.Beep(1320, 125);
                    Console.Beep(1188, 125);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 250);
                    Thread.Sleep(250);
                    Console.Beep(880, 500);
                    Console.Beep(880, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 750);
                    Console.Beep(1056, 250);
                    
                }
                else if (index == 5)
                {
                    index = 1;
                    Console.Beep(1188, 500);
                    Console.Beep(1408, 250);
                    Thread.Sleep(250);
                    Console.Beep(1760, 500);
                    Console.Beep(1584, 250);
                    Thread.Sleep(250);
                    Console.Beep(1320, 750);
                    Console.Beep(1056, 250);
                    Thread.Sleep(250);
                    Console.Beep(1320, 500);
                    Console.Beep(1408, 250);
                    Thread.Sleep(250);
                    Console.Beep(1320, 750);
                    Console.Beep(1188, 250);
                    Thread.Sleep(250);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                }
                else if (index == 6)
                {
                    index = 1;
                    Console.Beep(658, 125);
                    Console.Beep(1320, 500);
                    Console.Beep(990, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 250);
                    Console.Beep(1320, 125);
                    Console.Beep(1188, 125);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 250);
                    Console.Beep(880, 500);
                    Console.Beep(880, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 750);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 500);
                    Console.Beep(1320, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(880, 500);
                    Console.Beep(880, 500);
                    Thread.Sleep(250);
                    Console.Beep(1188, 500);
                    Console.Beep(1408, 250);
                    Console.Beep(1760, 500);
                    Console.Beep(1584, 250);
                    Console.Beep(1408, 250);
                    Console.Beep(1320, 750);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 500);
                    Console.Beep(990, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 500);
                    Console.Beep(1320, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(880, 500);
                    Console.Beep(880, 500);
                    Thread.Sleep(500);
                    Console.Beep(1320, 500);
                    Console.Beep(990, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 250);
                    Console.Beep(1320, 125);
                    Console.Beep(1188, 125);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 250);
                    Console.Beep(880, 500);
                    Console.Beep(880, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 750);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 500);
                    Console.Beep(1320, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(880, 500);
                    Console.Beep(880, 500);
                    Thread.Sleep(250);
                    Console.Beep(1188, 500);
                    Console.Beep(1408, 250);
                    Console.Beep(1760, 500);
                    Console.Beep(1584, 250);
                    Console.Beep(1408, 250);
                    Console.Beep(1320, 750);
                    Console.Beep(1056, 250);
                    Console.Beep(1320, 500);
                    Console.Beep(1188, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(990, 500);
                    Console.Beep(990, 250);
                    Console.Beep(1056, 250);
                    Console.Beep(1188, 500);
                    Console.Beep(1320, 500);
                    Console.Beep(1056, 500);
                    Console.Beep(880, 500);
                    Console.Beep(880, 500);
                    Thread.Sleep(500);
                    Console.Beep(660, 1000);
                    Console.Beep(528, 1000);
                    Console.Beep(594, 1000);
                    Console.Beep(495, 1000);
                    Console.Beep(528, 1000);
                    Console.Beep(440, 1000);
                    Console.Beep(419, 1000);
                    Console.Beep(495, 1000);
                    Console.Beep(660, 1000);
                    Console.Beep(528, 1000);
                    Console.Beep(594, 1000);
                    Console.Beep(495, 1000);
                    Console.Beep(528, 500);
                    Console.Beep(660, 500);
                    Console.Beep(880, 1000);
                    Console.Beep(838, 2000);
                    Console.Beep(660, 1000);
                    Console.Beep(528, 1000);
                    Console.Beep(594, 1000);
                    Console.Beep(495, 1000);
                    Console.Beep(528, 1000);
                    Console.Beep(440, 1000);
                    Console.Beep(419, 1000);
                    Console.Beep(495, 1000);
                    Console.Beep(660, 1000);
                    Console.Beep(528, 1000);
                    Console.Beep(594, 1000);
                    Console.Beep(495, 1000);
                    Console.Beep(528, 500);
                    Console.Beep(660, 500);
                    Console.Beep(880, 1000);
                    Console.Beep(838, 2000);
                }

            }
            return Choice [ index - 1].Selection;
        }   
    }
}