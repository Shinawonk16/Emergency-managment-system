using System;
using System.Collections.Generic;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.Implementation
{
    public class ElectricoutbreakManager:IElectricoutbreak
    {
        public static List<Electricoutbreak> listOfElectricoutbreak= new List<Electricoutbreak>();        
       public void CheckElectricoutbreak (string location,bool removecircuitbreaker)
       {
            Electricoutbreak elect = new Electricoutbreak( location,removecircuitbreaker);
            
            Console.WriteLine($"Don't be frighten  mrs/mr user just jump with your feet out of the building our rescue squad would reach {elect.Location} int the next ten minutes");
       }

            public void UpdateElectricoutbreak(string location)
            {
                Electricoutbreak elect = GetElectricoutbreak(location);
                    if(elect == null)
                    {
                        Console.WriteLine("electricoutbreak location not found");
                    }
                    else
                    {
                    
                        elect.Location = location;
                    }
            }

            public void DeleteElectricoutbreak (string location)
            {
                Electricoutbreak elect = GetElectricoutbreak(location);
                    if(elect != null)
                    {
                        listOfElectricoutbreak.Remove(elect);
                    }
                    else
                    {
                        Console.WriteLine(" electricoutbreak not found");
                    }
            }    

                public Electricoutbreak GetElectricoutbreak(string location)     
                {
                
                    foreach (var item in listOfElectricoutbreak)
                    {
                        if(item.Location == location)
                        {
                            return item;
                        }
                    }
                    return null;
                }

        public void ReportElectricoutbreak(string location,bool removecircuitbreaker)
        {
            Electricoutbreak electricoutbreak = new Electricoutbreak(location,removecircuitbreaker);
            listOfElectricoutbreak.Add(electricoutbreak);
            System.Console.WriteLine($"your report has been notify mr/mrs user we would reach {electricoutbreak.Location} in some minutess");

        }

    }
}