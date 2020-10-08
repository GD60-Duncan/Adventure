//
using System;

namespace Adventure
{
     class Locations
    {
       public static void Locationlist()
       {
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
       }

       abstract class Currentlocation 
       {
           //public string Currentlocation 
       } 

    }
}