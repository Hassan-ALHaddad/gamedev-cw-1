using System;

namespace CW_1_2
{
    class Program
    {
        static double playerSpeed;
        static void Main(string[] args)
        {
            static void SetSpeed()
            {
                playerSpeed = -2.5;
            }

            static void GetSpeed()
            {
                Console.WriteLine("The current player speed is " + playerSpeed);
            }

            SetSpeed();
            GetSpeed();

            

           
        }
    }
}
