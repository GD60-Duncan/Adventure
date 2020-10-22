//Copyright (C) 2020 Duncan McDougall, All rights Reserved
using System;
using System.Threading;

namespace TheEnding
{

    class goodbye
    {
        public static void TheEnding()
        {
            Console.Clear();
            _Adventure.Program.Print("The second you leave, i will forget everything...");
            _Adventure.Program.Print("But that's ok.");
            Thread.Sleep(1000);
            _Adventure.Program.Print("Did you win or lose?");
            _Adventure.Program.Print("Well it doesn't matter because there aren't any any winners in life.");
            Thread.Sleep(500);
            _Adventure.Program.Print("We all die...");
            Thread.Sleep(1000);
            _Adventure.Program.Print("And there's nothing you can do about it.");
            Thread.Sleep(500);
        }
    }

}