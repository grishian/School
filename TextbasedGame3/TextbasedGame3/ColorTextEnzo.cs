using System;
using System.Collections.Generic;
using System.Text;

namespace TexBasedGame3
{
    class ColorTextEnzo
    {

        public void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public void Orange()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }

        public void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Purple()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public void Reset()
        {
            Console.ResetColor();
        }




    }
}

