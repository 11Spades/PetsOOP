using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Pet
    {
        public string Name { get; set; }

        // Constructor
        public Pet(string name)
        {
            Name = name;
        }

        public abstract void MakeSound();
        public void ShowInfo()
        {
            Console.WriteLine("Pet name: " + Name);
        }

    }

    public class Cat : Pet
    {
        // Constructor
        public Cat(string name) : base(name) {}

        public override void MakeSound()
        {
            Console.WriteLine(Name + " meows at you.");
        }

        public void Climb()
        {
            Console.WriteLine(Name + " climbs the wall.");
        }

        public void Meet(Chimpanzee newFriend)
        {
            Console.WriteLine(Name + " scratches at " + newFriend.Name);
        }

        public void Meet(Turtle newFriend)
        {
            Console.WriteLine(Name + " scratches at " + newFriend.Name);
        }

    }

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
