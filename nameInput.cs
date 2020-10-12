//Copyright (C) 2020 Duncan McDougall, All rights Reserved
using System;
using System.Threading;

namespace Adventure
{
     class nameInput : Name
    {
        
        
        //public string userName = Console.ReadLine();
        
        //public string nameInput;
        public static void Start()
        {
            
            _Adventure.Program.Print("Welcome to the city, What is your name?");
            Console.WriteLine(" ");
            Console.WriteLine("Input your answer here");
            Console.WriteLine("Your name is... ");
            Console.Clear();
            Adventure.Name.Playername("" );
            Thread.Sleep(1000);
            _Adventure.Program.Print( " are you ready?");
            Thread.Sleep(1000);
            Console.Clear();

         //public string Name;
           //string Name = Console.ReadLine();
           
            
        }


    }
}