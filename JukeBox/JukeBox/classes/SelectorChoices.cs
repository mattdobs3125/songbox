using System;

namespace JukeBox.classes
{
    public class SelectorChoices
    {
        public Action Selection { get; set; }
        public string Attributes { get; set; }

        public SelectorChoices(Action selection,string attributes )
        {
            Selection = selection;
            Attributes = attributes;
        }




    }
}