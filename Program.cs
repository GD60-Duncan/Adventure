﻿// Copyright (C) 2020 Duncan McDougall, All Rights Reserved
using System;
using System.Threading;
//Sample text
namespace _Adventure
{

    class Program
    {
        static void Main(string[] args)
        {
            
            //starts the program and asks for name
            Adventure.nameInput.Start();
            string Name = Console.ReadLine();
            
            //ignore this
            Player i = new Player();
            
            
          Console.Clear(); 
          
          Console.WriteLine("");
          //calls importaint values and switch statement 
          LocationOutput();
          Console.WriteLine("");
          int exit = (1); 

         //once player goes to valid location reapeat again
         //you cannot leave the program, i did this on purpose to show the location changing witout the program ending
          do 
          {
              Console.Clear();
              LocationOutput();
              Console.WriteLine("");
    
          } while (exit == 1 );
        {
            
        }

 

          Console.WriteLine("Goodbye " + Name);
           Thread.Sleep(3500); 
          {
              
          }
         
        }
        static void meme()
        {
            
        }

         static void LocationOutput()
        {
            //string userName;
            Console.WriteLine("School    Home     The Movies      Coffee Shop     Store     Chess Club    The Park    Downtown    The Docks   The Mall");
            Console.WriteLine("");

            Console.WriteLine("Where would you like to go" );
            string Currentlocation = Console.ReadLine().ToLower  ();
         {
               //Assigns Each Location to a int (didn't really implument it but it defines each location)   
            const int Zero = 0;
            const int One = 1;
            const int Two = 2;
            const int Three = 3;
            const int Four = 4;
            const int Five = 5;
            const int Six = 6;
            const int Seven = 7;
            const int Eight = 8;
            const int Nine = 9;
            const int Ten = 10;
            
            //Location Array

        string[] Location = new string[11];         
         Location[Zero] = ("Where do you want do go ");
         Location[One] = ("You head to the school"); 
         Location[Two] = ("You head home");  //Home
         Location[Three] = ("You head to the movies");
         Location[Four] = ("You head to the coffie shop");
         Location[Five] = ("You head to the store");
         Location[Six] = ("You head to the chess club");
         Location[Seven] = ("You head to the park");
         Location[Eight]= ("You head downtown");
         Location[Nine]= ("you head to the mall");
        Location[Ten] = ("You head to the docks");
           
        //this doesn't do anything still
        int[,] playerLocation = {{ 0 }};

   
         switch (Currentlocation)
          {
            case "school":
            {
                Console.WriteLine(Location[One]);
                break;
            }
            case "home":
            {
                Console.Write(Location[Two]);
                break;
            }
            case "the movies":
            {
                Console.WriteLine(Location[Three]);
                break;
            }
            case "coffee shop":
          {
              Console.WriteLine(Location[Four]);
              break;
          }
          case "store":
          {
              Console.WriteLine(Location[Five]);
              break;
          }
          case "chess club":
          {
              Console.WriteLine(Location[Six]);
              break;
          }
          case "the park":
          {
              Console.WriteLine(Location[Seven]);
              break;
          }
          case "downtown":
          {
              Console.WriteLine(Location[Eight]);
              break;
          }
          case "the mall":
          {
              Console.WriteLine(Location[Nine]);
              break;
          }
          case "the docks":
          {
              Console.WriteLine(Location[Ten]);
              break;
          }

          default:
          {
            //this only appears when you made a wrong input
                Console.Clear();
                Console.WriteLine("Sorry, That is not a valid input.");
                Thread.Sleep(3500);
                Console.Clear();
                LocationOutput();
               
            
               Console.WriteLine("");
               Console.ReadLine();
            break;
          }  
            }
            
           
            }

        }
    }   
}
