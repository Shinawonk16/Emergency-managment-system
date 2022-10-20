using System;
using System.Collections.Generic;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;

namespace EMERGENCY_APPLICATION.Implementation
{
    public class RobberyManager:IRobberycase
    {
        
       public static List<Robberycase> listOfRobberycase = new List<Robberycase>();
       public void CheckRobberycase (string location,string harmed)
       {
        Robberycase rob = new Robberycase( location,harmed);
        Console.WriteLine($"Don't panick mrs/mr USER our COP would reach your location int the next two minutes");

       }
       

       public void UpdateRobberycase(string location)
       {
        Robberycase rob = GetRobberycase(location);
            if(rob == null)
            {
                Console.WriteLine("a robberycase not found");
            }
            else
            {
            
                rob.Location = location;
            }
       }

       public void DeleteRoberrycase (string location)
       {
        Robberycase rob= GetRobberycase(location);
            if(rob != null)
            {
                listOfRobberycase.Remove(rob);
            }
            else
            {
                Console.WriteLine("Robberycase not found");
            }
       }    

        public Robberycase GetRobberycase(string location)     
       {
        
            foreach (var item in listOfRobberycase)
            {
                if(item.Location == location)
                {
                    return item;
                }
            }
            return null;
        }

        public void ReportCase( string location,string harmed)
        {
            Robberycase robberycase = new Robberycase(location,harmed);
            listOfRobberycase.Add(robberycase);
            System.Console.WriteLine($"your report has been notify mr/mrs USER we would reach {robberycase.Location} in some minutess");
        }
    }
}
