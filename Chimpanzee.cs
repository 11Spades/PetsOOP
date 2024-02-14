using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class Chimpanzee : Pet
    {
        // Constructor
        public Chimpanzee(string name) : base(name) {}

        public override void MakeSound()
        {
            Console.WriteLine(Name + " hoots at you.");
        }
    }
}
