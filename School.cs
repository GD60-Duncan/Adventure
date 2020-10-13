//Copyright (C) 2020 Duncan McDougall, All rights Reserved
using System;
using System.Threading;


namespace Adventure
{
    class Location
    {
        public static void school()
        {
            Console.Clear();
            _Adventure.Program.Print("You enter the building and head down the hallway.");
            _Adventure.Program.Print("You see a kid name joe...");
            Thread.Sleep(1000);
            _Adventure.Program.Print("But unforently he doesn't seem intresed in you.");
            _Adventure.Program.Print("You realize how boring school is, so you leave.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();

        }
    } 
}