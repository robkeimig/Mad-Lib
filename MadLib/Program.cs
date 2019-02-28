using System;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string adjective1, nationality, person, noun1, adjective2;
            string noun2, adjective3, pluralNoun, noun3, number1, shape, food1, food2, number2, adjective4;
            Console.Write("Type an adjective: ");
                adjective1 = Console.ReadLine();

            Console.Write("Type a nationality: ");
                nationality = Console.ReadLine();

            Console.Write("Type a Famous Person: ");
                person = Console.ReadLine();

            Console.Write("Type a noun: ");
                noun1 = Console.ReadLine();

            Console.Write("Type an adjective: ");
                adjective2 = Console.ReadLine();

            Console.Write("Type an adjective: ");
                adjective3 = Console.ReadLine();

            Console.Write("Type a noun: ");
                noun2 = Console.ReadLine();

            Console.Write("Type an adjective: ");
                adjective4 = Console.ReadLine();

            Console.Write("Type a plural noun: ");
                pluralNoun = Console.ReadLine();

            Console.Write("Type a noun: ");
                noun3 = Console.ReadLine();

            Console.Write("Type a whole number: ");
                number1 = Console.ReadLine();

            Console.Write("Type a shape: ");
                shape = Console.ReadLine();

            Console.Write("Type a food: ");
                food1 = Console.ReadLine();

            Console.Write("Type a food: ");
                food2 = Console.ReadLine();

            Console.Write("Type a whole number: ");
                number2 = Console.ReadLine();

            Console.Write(
$@"Pizza was invented by a {adjective1}, {nationality} chef named {person}.
To make a pizza, you need to take a lump of {noun1} and make a thin round {adjective2} {noun2}.
Now, you cover it with {adjective3} sauce, {adjective4} cheese, and fresh chopped {pluralNoun}.
Next, you have to bake it in a very hot {noun3}. When it is done, cut it into {number1} {shape}.
Some kids like {food1} pizza the best, but my favorite is the {food2} pizza. 
If I could, I would eat pizza {number2} times a day!");

            Console.ReadLine();
        }
    }
}
