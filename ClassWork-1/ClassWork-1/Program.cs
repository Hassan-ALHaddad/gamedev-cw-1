using System;

namespace ClassWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1
            string characterName = "Hero";
            float speed = 25.5f;
            int age = 22;
            string superPower1 = "steel armor";
            string superPower2 = "night vision";


            Console.WriteLine("My name is " + characterName + " my power is " + superPower1 +
                " and " + superPower2 + ". my age is " + age + " ,and speed is " + speed);

            //ex2
            string heroName = "Hassan";
            int heroHeight = 170;
            int heroAge = 20;
            string heroSuperPower1 = "gold armor";
            string heroSuperPower2 = "invisible";

            int ageDifference = age - heroAge;
            Console.WriteLine("The different age between " + characterName + " and " + heroName + " is " + ageDifference);



        }
    }
}