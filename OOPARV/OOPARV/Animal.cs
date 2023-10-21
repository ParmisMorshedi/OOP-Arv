using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace OOPARV
{
    class Animal
    {
        //sex egenskaper som alla djur delar med varandra
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }
        public string Sound { get; set; }

        public Animal(string name, int weight, int age, string color, string food, string sound)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Color = color;
            Food = food;
            Sound = sound;
        }
        // metoder


        public void GetWeight()
        {
            Console.WriteLine($"{Name}  weights {Weight}kg");
        }
        public void GetColor()

        {
            Console.WriteLine($"{Name} is {Color}. ");

        }
        public void MakeSound()
        {
            Console.WriteLine($"{Name} makes a sound: {Sound}");

        }


    }
    //fösra djur
    class Bat : Animal
    {
        //properties för bat
        public bool Haswings { get; set; }

        //konstruktor för bat
        public Bat(string name, int weight, int age, string color, string food,string sound, bool haswings) : base(name,weight, age, color, food,sound)
        {
            Haswings = haswings;

        }
        //metod för bat
       public bool Gethaswings()
        { 
            return Haswings;
           
        }



    }
    //andra djur
    class Kangaroo : Animal
    {
        public bool Jumps { get; set; }

        public Kangaroo(string name, int weight, int age, string color, string food, string sound ,bool jumps) : base(name,weight ,age, color, food,sound)
        {
            Jumps=jumps;

        }
        public bool Getjump()
        {
            return Jumps ;

        }
    }

   

}

