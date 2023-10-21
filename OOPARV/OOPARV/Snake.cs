using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPARV
{    
    //Tredje djur
    internal class Snake :Animal
    {
        
       
         public int Size { get; set; }

         public Snake(string name, int weight, int age, string color, string food, string sound, int size) : base(name, age, weight, color, food, sound)
            
            {
                Size=size;
            }
         public void Getsize()
            {
                Console.WriteLine($"{Name} has {Size} meter long. ");

            }

    }
    class KingCobra : Snake
    {
        public bool IsPoisonous { get; set; }

        public KingCobra( string name, int weight, int age, string color, string food, string sound, int size, bool poison) :base ( name,  weight, age, color, food, sound, size)
            {
            IsPoisonous = poison;
            }
        public void IsPoisonousInfo()
        {
            Console.WriteLine($"{Name} is {(IsPoisonous ?"poisonous": "not poinsonous")}. ");
        
        
        }


    }
    class Anaconda : Snake 
    {
        public string Gender { get; set;}

        public Anaconda (string name, int weight, int age, string color, string food, string sound, int size, string gender) : base(name, weight, age, color, food, sound, size)
        {
            Gender = gender;
        }
        public void Getgender()
        {
            Console.WriteLine($"{Name} is a {Gender} anaconda.");

        }
    }
    

}

