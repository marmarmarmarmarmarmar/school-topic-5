using System;
using System.Formats.Asn1;
namespace ui_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = 20;
            int cats = 20;
            int dogs = 15;
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people < cats)
            {
                Console.WriteLine("Too many cats!!1!!");
            }
            if (people > cats)
            {
                Console.WriteLine("Too many people!!1!11");
            }
            if (people < dogs)
            {
                Console.WriteLine("Too many dogs!!1!!");
            }
            if (people > dogs)
            {
                Console.WriteLine("Too many people!!1!11");
            }
            Console.WriteLine("Press ENTER to continue.");
            Console.ReadLine();
            Console.Clear();
            dogs += 5;
            Console.WriteLine("People: " + people + " Dogs: " + dogs + " Cats: " + cats);
            if (people >= dogs)
            {
                Console.WriteLine("People are greater than or equal to dogs!!11!!");
            }
            if (people <= dogs)
            {
                Console.WriteLine("People are less than or equal to dogs11!11!1");
            }
            if (people == dogs)
            {
                Console.WriteLine("people are dogsr");
            }
            Console.WriteLine("");
            string dinosaur;
            Console.WriteLine("What dinosaur has the three large horn?!?!?");
            dinosaur = Console.ReadLine();
            if (dinosaur.ToLower() == "triceratops")
            {
                Console.WriteLine("you are correct!!!!!!!!");
            }
            Console.WriteLine("");
            string answer;
            Console.WriteLine("also, what is the magic word?!?!??!");
            answer = Console.ReadLine();
            if (answer.ToLower() == "please")
            {
                Console.WriteLine("you are welcome!!!!!!");
            }
            Console.WriteLine("");
            int age;
            Console.WriteLine("also, what is your age??????");
            int.TryParse(Console.ReadLine(), out age);
            if (age < 16)
            {
                Console.WriteLine("you can't drive!!!!!!!!");
            }
            if (age < 18)
            {
                Console.WriteLine("you can't vote!!!!!!!!!");
            }
            if (age < 25)
            {
                Console.WriteLine("you can't rent a car!!!!!!");
            }
            if (age > 25)
            {
                Console.WriteLine("you can do anything!!!!!!");
            }
            Console.WriteLine("");
            int temperature;
            Console.WriteLine("also, at what temperature does water freeze??????");
            int.TryParse(Console.ReadLine(), out temperature);
            if (temperature == 0)
            {
                Console.WriteLine("correct!!!!!!!");
            }
            if (temperature == 32)
            {
                Console.WriteLine("No");
            }
            if (temperature == 273)
            {
                Console.WriteLine("correct!!!!!!!!!!!!!!!!!!!!");
            }
        }
    }
}

