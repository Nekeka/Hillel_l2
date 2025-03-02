using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Violin : MusicalInstrument
    {
        public Violin(string name, string story, string desc) : base(name, story, desc)
        {

        }

        private string _name;
        private string _desc;
        private string _story;
        public override string Name { get => _name; set => _name = value; }
        public override string Description { get => _desc; set => _desc = value; }
        public override string Story { get => _story; set => _story = value; }

        public override void Sound()
        {
            Console.WriteLine("звучить ніжно, яскраво та дуже виразно");
        }
        public override void Show()
        {
            Console.WriteLine($"Це {Name}");
        }
        public override void History()
        {
            Console.WriteLine($"{Story}");
        }
        public override void Desk()
        {
            Console.WriteLine($"{Description}");
        }
    }
}
