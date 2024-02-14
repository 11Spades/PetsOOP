using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Turtle : Pet
    {
        // Constructor
        public Turtle(string name) : base(name) {}

        public override void MakeSound()
        {
            Console.WriteLine(Name + " grunts at you.");
        }

        public void HideInShell()
        {
            Console.WriteLine(Name + " hides in its shell.");
        }
    }
}
