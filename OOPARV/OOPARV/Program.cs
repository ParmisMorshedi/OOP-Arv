using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPARV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bat bat = new Bat("Bob", 1 ,12,"Black","insects","zzzz",true);
            
            bat.MakeSound();
            bat.GetColor();
            bat.GetWeight();
            bat.Gethaswings();
            Console.WriteLine($"Has wings: {bat.Gethaswings()}");
            Console.WriteLine( "*********************************************************************************");


            Kangaroo kangaroo = new Kangaroo("Jack",60, 15, "gray","grasses","yipe", true);
            kangaroo.MakeSound();
            kangaroo.GetColor();
            kangaroo.GetWeight();
            kangaroo.Getjump();
            Console.WriteLine($"Jumps: {kangaroo.Getjump()}");
            Console.WriteLine("*********************************************************************************");


            Snake snake = new Snake("Anakin",17 , 4, "blue", "fish", "hu", 1);
            
            snake.MakeSound();
            snake.GetColor();
            snake.Getsize();
            snake.GetWeight();
         

            KingCobra kingcobra = new KingCobra("cobra", 5, 10, "green","small animals","hiss", 3,true);
            kingcobra.MakeSound();
            kingcobra.IsPoisonousInfo();

            Anaconda anaconda = new Anaconda("anaconda", 50, 8, "green", "small animals","hiss",5, "female");
            anaconda.MakeSound();
            anaconda.Getgender();


        }

    }
}
