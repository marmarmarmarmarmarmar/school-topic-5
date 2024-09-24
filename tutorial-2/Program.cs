using System;
namespace ui_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade;
            Console.WriteLine("what was your grade?!??!?");
            int.TryParse(Console.ReadLine(), out grade);
            if (grade >= 50)
            {
                Console.WriteLine("congratulations!!!!!!!!");
            }
            else
            {
                Console.WriteLine("just like me fr");
            }
            if (grade < 50)
            {
                Console.WriteLine("You got an F!!!!!!!!!!!");
            }
            else if (grade <= 85)
            {
                Console.WriteLine("You got a B!!!!!!!!!!!");
            }
            else if (grade <= 75)
            {
                Console.WriteLine("You got a C!!!!!!!!!!!");
            }
            else if (grade <= 65)
            {
                Console.WriteLine("You got a D!!!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("You got an A!!!!!!!!!!!");
            }
            int age;
            Console.WriteLine("what is your age?!?!?!??");
            int.TryParse(Console.ReadLine(), out age);
            if (age >= 16)
            {
                Console.WriteLine("you can drive!!!!!!!!!");
            }
            else
            {
                Console.WriteLine("you can't drive!!!!!!!!!!");
            }
            Console.WriteLine("");
            int bet;
            Console.WriteLine("How much would you like to bet?!?1?1?!?");
            if (int.TryParse(Console.ReadLine(), out bet))
            {
                Console.WriteLine("You bet " + bet.ToString("C") + "!!!!!!");
            }
            else
            {
                Console.WriteLine("thassa not a valid number!!!!!!!!!");
                Console.WriteLine("Thus, your bet will be set to a minimum of $1.00!!!!");
                bet = 1;
            }
            Console.WriteLine("");
            int waterTemp;
            Console.WriteLine("also, what is the temperature you would like to give to water??!?1");
            if (int.TryParse(Console.ReadLine(), out waterTemp))
            {
                if (waterTemp <= 0)
                {
                    Console.WriteLine("the water at " + waterTemp + " celsius would be solid!!!!!");
                }
                else if (waterTemp <= 99)
                {
                    Console.WriteLine("the water at " + waterTemp + " celsius would be liquid!!!!!");
                }
                else
                {
                    Console.WriteLine("the water at " + waterTemp + " celsius would be a gas!!!!!");
                }
            }
            else
            {
                Console.WriteLine("that is not a valid temperature!!!!!!!!!!!!!!!!!!!!!!!");
            }
            Console.WriteLine("");
            Console.WriteLine("also what is your age again?!!?!?? I forgot!!!!!!!!!");
            
        }
    }
}

