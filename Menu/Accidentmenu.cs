using System;
using EMERGENCY_APPLICATION.Implementation;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.Menu
{
    public class Accidentmenu
    {
       public IAccident accident;
       public void AccidentSubMenu()
       {
         System.Console.WriteLine("enter 1 for help\nenter 2 to report\nenter 3 to go back to mainmenu");
         int yelp = int.Parse(Console.ReadLine());
         if(yelp == 1)
            {
                SeekForHelp();
            }
            else if (yelp == 2)
            {
                Report();
            }
            else if(yelp == 3)
            {
                Mainmenu mainmenu = new Mainmenu();
                mainmenu.MiniMenu();
            }
        }
        public void SeekForHelp()
        {
            
            Console.WriteLine("Welcome to lifesaver");

            
            Console.Write("Enter your location: ");
            string location = Console.ReadLine();

            Console.Write("Enter your type of Accident: \n enter 1 if bike accident\nenter 2 if car accident\nenter 3 if slippery accident");
            System.Console.WriteLine(" ");
            string typeOfAccident = Console.ReadLine();
            if (typeOfAccident == "1")
            {
                System.Console.WriteLine("we will be in the location in some moment");
            }
            else if (typeOfAccident == "2")
            {
                System.Console.WriteLine("our Ambulance will be in the location in some moment ");
            }
            else if (typeOfAccident == "3")
            {
                System.Console.WriteLine("try getting first aid for your self and our firstaider will be with you in a moment");
            }

            
            // accident.CheckAccident(fullName,location,typeOfAccident,position);
            AccidentManager acid = new AccidentManager();
            acid.CheckAccident(location,typeOfAccident);
            acid.UpdateAccident(location);
            foreach (var item in AccidentManager.listOfComplaints)
            {
                Console.WriteLine(item.Fullname + " " + item.Location + " " + item.AcidentType + " " + item.Position);
            }
        }
        public void Report()
        {
            Console.WriteLine("Welcome to lifesaver");
            Console.Write("Enter your location: ");
            string location = Console.ReadLine();
             
            Console.Write("Enter your type of Accident: \n enter 1 if bike accident\nenter 2 if car accident\nenter 3 if slippery accident");
            System.Console.WriteLine(" ");
            string typeOfAccident = Console.ReadLine();
            if (typeOfAccident == "1")
            {
                System.Console.WriteLine("we will be in the location in some moment");
            }
            else if (typeOfAccident == "2")
            {
                System.Console.WriteLine("our Ambulance will be in the location in some moment ");
            }
            else if (typeOfAccident == "3")
            {
                System.Console.WriteLine("try getting aspirin from the first aid for the victim and our firstaider will be with you in a moment");
            }

             AccidentManager acid = new AccidentManager();
            acid.ReportAccident(location,typeOfAccident);
            acid.CheckAccident(location,typeOfAccident);
           



        }
        
    }
}