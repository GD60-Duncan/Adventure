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
            _Adventure.Program.Print("You see a kid named joe...");
            Thread.Sleep(1000);
            _Adventure.Program.Print("But unforently he doesn't seem intresed in you.");
            _Adventure.Program.Print("You realize how boring school is, so you leave.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();

        }
        public static void home()
        {
           Console.Clear();
            _Adventure.Program.Print("You walk in the door to find nobody there. ");
            _Adventure.Program.Print("Not supprising considiring people are pretty busy these day's");
             _Adventure.Program.Print("It's pretty quiet here so...");
             Thread.Sleep(1000);
            _Adventure.Program.Print("You watch some Tv untill you get board.");
            _Adventure.Program.Print("With nothing better to do you leave");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
            

        }
        public static void theater()
        {
            Console.Clear();
            _Adventure.Program.Print("Walk and check to see what movies are playing. ");
            _Adventure.Program.Print("There is nothing good, as usual. ");
            _Adventure.Program.Print("However you look to your left... ");
            Thread.Sleep(1000);
            _Adventure.Program.Print("You see the same arcade your 10th birthday was at.");
            _Adventure.Program.Print("You reminise of a better time");
            Thread.Sleep(500);
            _Adventure.Program.Print("It looks very empty");
            _Adventure.Program.Print(" I guess");
             Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
        public static void coffieshop()
        {
            Console.Clear();
            _Adventure.Program.Print("You walk in even though it's the afternoon.");
            _Adventure.Program.Print("You look around but then...");
            Thread.Sleep(1000);
            _Adventure.Program.Print("You see Bethany a girl you've had your eye on for a while. ");
            _Adventure.Program.Print("Now would be the perfect opertunity to say hi to her... ");
            Thread.Sleep(1000);
            _Adventure.Program.Print("But you're too shy so you leave");
             Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
        public static void store()
        {
            _Adventure.Program.Print(" Ypu walk in even though you aren't hungry");
            _Adventure.Program.Print(" Why are you there then?");
            _Adventure.Program.Print("Prehaps for a greater purpose?");
             Thread.Sleep(1000);
            _Adventure.Program.Print("");
            _Adventure.Program.Print("Probably not");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
        public static void chessclub()
        {
            _Adventure.Program.Print(" Why did i come here?");
            _Adventure.Program.Print("I don't even play chess anymore.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();

        }
        public static void park()
        {
            _Adventure.Program.Print("How it would feel to be a kid again");
             _Adventure.Program.Print("I mean they look so...");
             Thread.Sleep(1000);
            _Adventure.Program.Print("Happy");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
        public static void downtown()
        {
            _Adventure.Program.Print("Wow how things change");
            _Adventure.Program.Print("I mean years ago this place looked quite diffrent...");
             Thread.Sleep(1000);
            _Adventure.Program.Print("Why do things have to change?");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
        public static void mall()
        {
            _Adventure.Program.Print("What is the meaning of life?");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }

        public static void docks()
        {
            _Adventure.Program.Print("What a beautiful sunset. ");
            Thread.Sleep(1000);
            _Adventure.Program.Print("If only it could last.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue");
            Console.Read();
        }
    } 
}