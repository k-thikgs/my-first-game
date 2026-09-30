using System;

namespace SimpleRPG
{
    class Game
    {
        bool end;

        private void InitVariables()
        {
            this.end = false;
        }

        public Game()
        {
            this.InitVariables();
            Console.WriteLine("Welcome to Simple RPG! from inside the constructor");

        }

        public void Run()
        {
            while (this.end == false)
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0)
                {
                    Console.WriteLine("Ending game");
                    this.end = true;
                }
                else
                {
                    Console.WriteLine("You entered: " + number);
                }
            }
            Console.WriteLine("Ending game");


        }
    }

}
