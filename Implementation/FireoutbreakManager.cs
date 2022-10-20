using System;
using System.Collections.Generic;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.Implementation
{
    public class FireoutbreakManager:IFireoutbreak
    {
        public static List<Fireoutbreak> listOfFireoutbreak = new List<Fireoutbreak>();
      
       public void CheckFireoutbreak(string location,string typeofbuilding ,bool fireextigushier)
       {
        Fireoutbreak fire = new Fireoutbreak( location,typeofbuilding,fireextigushier );
        Console.WriteLine($"keep calm mrs/mr USER and make sure you do not use a lift or escalator the Fire squad would reach your location int the next two minutes");
        
       }
       

       public void UpdateFireoutbreak(string location)
     {
        Fireoutbreak fire = GetFireoutbreak(location);
            if(fire== null)
            {
                Console.WriteLine("Fireoutbreak Location  not found");
            }
            else
            {
            
                fire.Location = location;
            }
       }

       public void DeleteFireoutbreak(string location)
       {
        Fireoutbreak fire = GetFireoutbreak(location);
            if(fire != null)
            {
                listOfFireoutbreak.Remove(fire);
            }
            else
            {
                Console.WriteLine("Fireoutbreak not fouund");
            }
       }    

        public Fireoutbreak GetFireoutbreak(string location)     
       {
        
            foreach (var item in listOfFireoutbreak)
            {
                if(item.Location == location)
                {
                    return item;
                }
            }
            return null;
        }

        public void ReportFireoutbreak(string location, string typeofbuilding,bool fireextigushier)
        {
            Fireoutbreak fireoutbreak = new Fireoutbreak(location,typeofbuilding,fireextigushier);
            listOfFireoutbreak.Add(fireoutbreak);
            System.Console.WriteLine("your report has been notify mr/mrs user we would reach {fireoutbreak.Location} in some minutes");
        }
    }
}