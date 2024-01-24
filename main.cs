using System;
using System.Collections.Generic;
using ClassLibrary1;

public class MainClass
{
    static private void AddNewPet()
    {
        int userInput = -1;
        string petName = "";

        while (userInput != 4)
        {
            Console.Write("This pet is named: ");
            try
            {
                petName = Console.ReadLine();
            }
            catch (Exception e) {}
            Console.WriteLine();

            Console.WriteLine("1. Add a new Cat");
            Console.WriteLine("2. Add a new Chimpanzee");
            Console.WriteLine("3. Add a new Turtle");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("> ");

            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch (Exception e) {}
            Console.WriteLine();

            switch (userInput)
            {
                case 1:
                    Cat newCat = new Cat(petName);
                    break;

                case 2:
                    Chimpanzee newChimpanzee = new Chimpanzee(petName);
                    break;

                case 3:
                    Turtle newTurtle = new Turtle(petName);
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                    break;
            }
        }
    }

    static public void Main()
    {
        int userInput = -1;

        Console.WriteLine("Welcome to the Pet Store!");
        Console.WriteLine("-------------------------");
        Console.WriteLine();

        while (userInput != 4)
        {
            Console.WriteLine("1. Add a new pet");
            Console.WriteLine("2. List all pets");
            Console.WriteLine("3. Make two pets meet");
            Console.WriteLine("4. Exit");
            Console.WriteLine();
            Console.Write("> ");

            try
            {
                userInput = int.Parse(Console.ReadLine());
            }
            catch (Exception e) {}
            Console.WriteLine();

            switch(userInput)
            {
                case 1:
                    AddNewPet();
                    break;

                case 2:
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine();
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    Console.WriteLine();
                    break;
            }
        }
    }
}
