// Copyright (C) 2020 Duncan McDougall, All Rights Reserved
using System;
using System.Collections.Generic;

//Sample text
namespace Adventure
{
     class Name
     {
        //yes i am aware that it is static, it's far too late for me to change it
        
         public static void Playername(string userName)
        {
            
            userName = Console.ReadLine();
            if (userName != "")
            {
                userName = new string(userName);
                Console.Write(userName);
            }
            else
            //if userName is blank, it assigns a defult username
             {
                 userName = new string("Ness");
            Console.Write(" Ness");
             }

        }
                
//ignore this, just experienting
           
        }
        class setName : Name
        {
            public void Writename()
        {
          string userName = ("hi");
          Console.Write(userName);
        }
     }
}