using System;
namespace EMERGENCY_APPLICATION.Menu
{
    public class Mainmenu
    {
        public void MiniMenu()
        {
            System.Console.WriteLine("welcome to the National Emergency Lifesaver");
            System.Console.WriteLine("enter 1 for Acident Emergency\nenter 2 for Electric outbreak\nenter 3 for Fire outbreak\nenter 4 for Robberycase Emergency");
            int situation = int.Parse(Console.ReadLine());
            if(situation == 1)
            {
              Accidentmenu men = new Accidentmenu();
              men.AccidentSubMenu();
            }

            else if(situation == 2)
            {
              Electricoutbreakmenu wen = new Electricoutbreakmenu();
              wen.ElectricoutbreakSubMenu();
            }
            else if (situation == 3)
            {
              
            }
            else if (situation == 4)
            {
              Robberymenu robberymenu = new Robberymenu();
              robberymenu.RobberySubMenu();
  
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}