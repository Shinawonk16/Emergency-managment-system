using System;
using EMERGENCY_APPLICATION.Implementation;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.Menu
{
    public class Fireoutbreakmenu
    {
        public void FireoutbreakSubmenu()
        {
             System.Console.WriteLine("enter 1 to seek for help\nenter 2 to report\nenter 3 to go back to main menu");
         int ask = int.Parse(Console.ReadLine());
         if (ask == 1)
         {
            SeekHelp();
         }
         else if (ask == 2)
         {
            ReportIncident();
         }
         else if (ask == 3)
         {
            
                Mainmenu mainmenu = new Mainmenu();
                mainmenu.MiniMenu();
         }
        }
        public void SeekHelp()
        {
            Console.WriteLine("Welcome to lifesaver");

          
            Console.Write("Enter your location: ");
            string location = Console.ReadLine();

            Console.Write("enter type of building\nenter 1 if bungalow\n enter 2 if multi story building\nenter 3 if companybuilding\nenter 4 if skyscrapper");
            System.Console.WriteLine(" ");
            string typeofbuilding =Console.ReadLine();
            if(typeofbuilding == "1")
            {
                System.Console.WriteLine("get out of the building");
            }
            else if (typeofbuilding == "2")
            {
                System.Console.WriteLine("turn off all elctric gadget and get out of the building  ");
            }
            else if (typeofbuilding == "3")
            {
                System.Console.WriteLine("do not use Lift or escalator ");
            }
            else if (typeofbuilding == "4")
            {
                System.Console.WriteLine("do not use lift or escalator");
            }
            else  
            {
             Fireoutbreakmenu fireoutbreakmenu = new Fireoutbreakmenu();
            fireoutbreakmenu.FireoutbreakSubmenu();
            }
            Console.WriteLine("is there any nearby fireextigushier\n enter true if yes\nenter false if no");
            bool fireextigushier = bool.Parse(Console.ReadLine());
            if (fireextigushier == true)
            {
                System.Console.WriteLine("make use of the fire extigusheir and move out of the building");
            }
            else if (fireextigushier == false)
            {
             System.Console.WriteLine("don't try quenching the fire with water just move out of the building");   
            }
            else
            {
             Fireoutbreakmenu fireoutbreakmenu = new Fireoutbreakmenu();
            fireoutbreakmenu.FireoutbreakSubmenu();
            }
            FireoutbreakManager fireoutbreakManager = new FireoutbreakManager();
            fireoutbreakManager.CheckFireoutbreak(location,typeofbuilding,fireextigushier);

        }
        public void ReportIncident()
        {
            System.Console.WriteLine("welcome to elifesaver");
              Console.Write("Enter your location: ");
            string location = Console.ReadLine();
             Console.Write("enter type of building\nenter 1 if bungalow\n enter 2 if multi story building\nenter 3 if companybuilding\nenter 4 if skyscrapper");
            System.Console.WriteLine(" ");
            string typeofbuilding =Console.ReadLine();
            if(typeofbuilding == "1")
            {
                System.Console.WriteLine("get people out of the building");
            }
            else if (typeofbuilding == "2")
            {
                System.Console.WriteLine("turn off all elctric gadget and get out of the building  ");
            }
            else if (typeofbuilding == "3")
            {
                System.Console.WriteLine("make sure everybody in building do not use lift or escalator ");
            }
            else if (typeofbuilding == "4")
            {
                System.Console.WriteLine("make sure everybody in building do not use lift or escalator");
            }
            else  
            {
             Fireoutbreakmenu fireoutbreakmenu = new Fireoutbreakmenu();
            fireoutbreakmenu.FireoutbreakSubmenu();
            }
            System.Console.WriteLine("is there any nearby fireextigushier\n if true if yes\nenter false if no");
            bool fireextigushier = bool.Parse(Console.ReadLine());
            if (fireextigushier == true)
            {
                System.Console.WriteLine("make use of the fire extigusheir and move out of the building");
            }
            else if (fireextigushier == false)
            {
             System.Console.WriteLine("don't try quenching the fire with water just move out of the building");   
            }
            else
            {
             Fireoutbreakmenu fireoutbreakmenu = new Fireoutbreakmenu();
            fireoutbreakmenu.FireoutbreakSubmenu();
            }
            FireoutbreakManager fireoutbreakManager = new FireoutbreakManager();
            fireoutbreakManager.CheckFireoutbreak(location,typeofbuilding,fireextigushier);

        }    

           
 
    }
}
