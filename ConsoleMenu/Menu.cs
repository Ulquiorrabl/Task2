using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.ConsoleMenu
{
    class Menu
    {
        bool menuState;
        public Menu()
        {
            menuState = true;
        }

        public void Show()
        {
            while (menuState)
            {
                Console.WriteLine("Choose needed operation");
                Console.WriteLine("1. Show parsed text");
                Console.WriteLine("Choose needed operation");
                Console.WriteLine("Choose needed operation");
                Console.WriteLine("0.Exit");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {

                    case 0:
                        menuState = false;
                        break;

                }
            }
            

        }

    }
}
