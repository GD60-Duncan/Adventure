// Copyright (C) 2020 Duncan McDougall, All Rights Reserved
using System;
//Sample text
namespace _Adventure
{
    class Program
    {

        static void Main(string[] args)
        {
         //location list   
            //string[] locationList = new string[11];
        {
            
        } 

        {
           //Learn Player's Name 
             Console.WriteLine("Welcome to the city, What is your name?");
            Console.WriteLine(" ");
            Console.WriteLine("Input your answer here");
            string userName = Console.ReadLine();
          Console.Clear(); 
          //Player Inputs Where They Wants To Go
          Console.WriteLine("School    Home     The Movies      Coffee Shop     Store     Chess Club    The Park    Downtown    The Docks   The Mall");
          Console.WriteLine("");
          Console.WriteLine("Where would you like to go " + userName);
          string currentLocation = Console.ReadLine();
            
          //Assign Each Location To A Number  
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

           //string School = currentLocation[Zero];
        
        string[] Location = new string[11];
         Location[Zero] = ("Where do you want do go");
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
         
          
         string[] locationList = {"School", "Home", "Coffee", "Store", "Chess Club","The Park","Downtown","The Docks,","The Mall"};

            //Selects Location Based of Player Input
         


          //if (currentLocation = School) {
              //Console.WriteLine(Location[One]);
          //}

                     //Updates Current Location

        int[,] playerLocation = {{ 0 }};

         switch (currentLocation)
          {
            case "School":
            {
                Console.WriteLine(Location[One]);
                break;
            }
            case "Home":
            {
                Console.Write(Location[Two]);
                break;
            }
            case "Coffee Shop":
            {
                Console.WriteLine(Location[Three]);
                break;
            }
            case "Store":
          {
              Console.WriteLine(Location[Four]);
              break;
          }
          case "Chess Club":
          {
              Console.WriteLine(Location[Five]);
              break;
          }
          case "The Park":
          {
              Console.WriteLine(Location[Six]);
              break;
          }

        //Prints Current Location


          }
         
         // Future proofing for anyone who tries to break my program
         
         if (Location.Length > 11) {
                Console.WriteLine("Congrats You Found A Bug, Please Report This To Me!!!!!!!");

         }
           
        
        //}
        } 

        {
        //string Input = Console.ReadLine();
            //if (Input == "")
            //Console.Write(Location1);
            //if (Location[Number] = V) {
                    //Console.WriteLine(Location[0]);
        }

            //for (int i = 0 ; i <2; i++) While Loop
        {
            //Console.WriteLine(locationList[0] );
        }    

            
            //string answer = Console.ReadLine();
           
         {
        //exit 
          //bool exit = false;
           //while (!exit);
           //int locationIndex = 0;
        }


        }
    }
}