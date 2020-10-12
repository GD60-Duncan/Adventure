// Copyright (C) 2020 Duncan McDougall, All Rights Reserved
using System;
using System.Collections.Generic;

//Sample text
namespace Adventure
{
     class Name
     {
         public static void Playername(string userName)
        {
            
            userName = Console.ReadLine();
            if (userName != null)
            {
                userName = new string(userName);
                Console.Write(userName);
            }
            else
             {
                 userName = new string("Ness");
            Console.Write(" Ness ");
             }
        


            //if Console.ReadLine();
           
           //Console.Write(userName);
        }
     }
}