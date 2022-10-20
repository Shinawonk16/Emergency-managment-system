using System;
using EMERGENCY_APPLICATION.Implementation;
using EMERGENCY_APPLICATION.interfaces;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.Menu
{
    public class Robberymenu
    {
        public void RobberySubMenu()
        {
            
         System.Console.WriteLine("enter 1 to seek for help\nenter 2 to report\nenter 3 to go back to main menu");
         int ask = int.Parse(Console.ReadLine());
         if (ask == 1)
         {
            SeekHelp();
         }
         else if (ask == 2)
         {
            ReportCase();
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

            Console.Write("Are you harmed\nenter: yes if you re harmed\nenter: no if you are not harmed");
            System.Console.WriteLine(" ");
            string harmed =Console.ReadLine();
            if(harmed == "yes")
            {
                System.Console.WriteLine("try getting any nearby firstaid");
            }
            else if (harmed == "no")
            {
                System.Console.WriteLine("dont panick ");
            }
            else  
            {
                Robberymenu robberyMenu = new Robberymenu();
                robberyMenu.RobberySubMenu();

            }
            RobberyManager robberyManager = new RobberyManager();
            robberyManager.CheckRobberycase(location,harmed);

        }
        public void ReportCase()
        {
            System.Console.WriteLine("welcome to elifesaver");
              Console.Write("Enter your location: ");
            string location = Console.ReadLine();

            Console.Write("is the person   harmed\nenter: yes if the person is harmed \nenter: no if the person is not harmed");
            System.Console.WriteLine(" ");
            string harmed =Console.ReadLine();
            if(harmed == "yes")
            {
                System.Console.WriteLine("try getting any nearby firstaid for to person ");
            }
            else if (harmed == "no")
            {
                System.Console.WriteLine("abide with the person and make sure he/she does not panic");
            }
            else  
            {
                Robberymenu robberyMenu = new Robberymenu();
                robberyMenu.RobberySubMenu();

            }
              RobberyManager robberyManager = new RobberyManager();
              robberyManager.ReportCase(location,harmed);



        }
    }
}