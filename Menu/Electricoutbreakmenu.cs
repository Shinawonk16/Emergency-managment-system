using System;
using EMERGENCY_APPLICATION.Implementation;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.Menu
{
    public class Electricoutbreakmenu
    {
        
    //    Electricoutbreak eob  = new Electricoutbreak();
       public void ElectricoutbreakSubMenu()
       {
         System.Console.WriteLine("enter 1 for help\nenter 2 to report\nenter 3 to go back to main menu");
         int save = int.Parse(Console.ReadLine());
         if(save == 1)
            {
                SeekForAssistance();
            }
            
            else if(save == 2)
            {
                Report();
            }
            else if (save== 3)
            {
                Mainmenu mainmenu = new Mainmenu();
                mainmenu.MiniMenu();
            }
            

        }
        public void SeekForAssistance()
        {
            
            Console.WriteLine("Welcome to lifesaver");


            Console.Write("Enter your location: ");
            string location = Console.ReadLine();

            Console.Write("have you remove the circuit breaker\n enter true if you have remove the circuit breaker\nenter false if you havenot remove the circuit breaker ");
            System.Console.WriteLine(" ");
            bool removecircuitbreaker = bool.Parse(Console.ReadLine());
             if (removecircuitbreaker == true)
            {
                System.Console.WriteLine("don't be afraid and stay off the building");
            }
            else if (removecircuitbreaker == false)
            {
                System.Console.WriteLine("remove the circuit breaker mrs/mr User");
            }
           

            ElectricoutbreakManager electricoutbreakManager = new ElectricoutbreakManager();
            electricoutbreakManager.CheckElectricoutbreak(location,removecircuitbreaker);
            Mainmenu mainmenu = new Mainmenu();
        }  
        public void Report()  
        {
            // System.Console.WriteLine("enter fullname");
           
            Console.Write("Enter your location: ");
            string location = Console.ReadLine();

            Console.Write("have you remove the circuit breaker ");
            bool removecircuitbreaker = bool.Parse(Console.ReadLine());
            if (removecircuitbreaker == true)
            {
                System.Console.WriteLine("don't be afraid");
            }
            else if (removecircuitbreaker == false)
            {
                System.Console.WriteLine("remove the circuit breaker and get everyone out of the building");
            }
            ElectricoutbreakManager electricoutbreakManager = new ElectricoutbreakManager();
            electricoutbreakManager.ReportElectricoutbreak(location,removecircuitbreaker);

        }

    }
}