using System;
using System.Collections.Generic;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.Implementation
{
    public class AccidentManager:IAccident
    {
       public static List<Accident> listOfAccident = new List<Accident>();
       public static List<Complaints> listOfComplaints = new List<Complaints>();

       public AccidentManager()
       {
        
       }
       public void CheckAccident (string location,string typeoffaccident)
       {
        Accident acid = new Accident( location,typeoffaccident);
        listOfAccident.Add(acid);
        Console.WriteLine($"keep calm mrs/mr USER our agent would reach the {acid.Location} int the next two minutes,and don,t be frigthen by your position");

       }

       public void ReportAccident(string location,string typeOfAccident)
       {
        Accident accident = new Accident ( location,typeOfAccident);
    
        // listOfComplaints.Add(complaints);
        listOfAccident.Add(accident);
        Console.WriteLine($"your report has been notify mr/mrs user we would reach {accident.Location} in some minutess");

       }
       

       public void UpdateAccident(string location)
       {
        Accident acid = GetAccident(location);
            if(acid == null)
            {
                Console.WriteLine("accident not found");
            }
            else
            {
            
                acid.Location = location;
            }
       }

       public void DeleteAccident (string location)
       {
        Accident acid = GetAccident(location);
            if(acid != null)
            {
                listOfAccident.Remove(acid);
            }
            else
            {
                Console.WriteLine("accident not found");
            }
       }    

        public Accident GetAccident(string location)     
       {
        
            foreach (var item in listOfAccident)
            {
                if(item.Location == location)
                {
                    return item;
                }
            }
            return null;
        }
           
              
    }
}