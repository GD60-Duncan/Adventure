// Copyright (C) 2020 Duncan McDougall, All Rights Reserved
using System;
//Sample text
namespace _Adventure
{

    class Program
    {
        static void Main(string[] args)
        {
            Adventure.nameInput.Start();
            //Name = Console.ReadLine();
             //Adventure.userName.userName();
             Console.ReadLine();
            //Adventure.userName.userName();
            //userName userName = new userName;
            
          Console.Clear(); 
          //Player Inputs Where They Wants To Go
          Console.WriteLine("");
          LocationOutput();
          Console.WriteLine("");

          {
              
          }
         
        }

         static void LocationOutput()
        {
            //string userName;
            Console.WriteLine("School    Home     The Movies      Coffee Shop     Store     Chess Club    The Park    Downtown    The Docks   The Mall");
            Console.WriteLine("");

            Console.WriteLine("Where would you like to go");
            string Currentlocation = Console.ReadLine().ToLower  ();
             Console.WriteLine(Currentlocation);
            
            {
                Console.Clear();
                LocationOutput();
            }
            //if (Currentlocation.Equals("school")+("home");
            {
            
            }
        }   
    }
}
