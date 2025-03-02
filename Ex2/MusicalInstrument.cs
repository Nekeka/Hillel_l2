using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    abstract class MusicalInstrument
    {
        public abstract string Name { get; set; }
        public abstract string Story { get; set; }
        public abstract string Description { get; set; }

        public MusicalInstrument(string name, string story, string description)
        {
            Name = name;
            Story = story;
            Description = description;
        }

        public abstract void Sound();
        public abstract void Show();
        public abstract void Desk();
        public abstract void History();

        public override string ToString()
        {
            return Name;
        }
    }
}