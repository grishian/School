using System;
using System.Collections.Generic;
using System.Text;

namespace Kinderboerderij
{
    class ConsoleMethods
    {

        //fields

        //constructors

        //methods

        public void Foreground(ConsoleColor color)
        {
            Console.ForegroundColor = color;           
        }

        public void ForegroundRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public void ForegroundYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }



    }
}
