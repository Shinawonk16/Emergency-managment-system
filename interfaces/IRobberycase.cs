using System;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.interfaces
{
    public interface IRobberycase
    {
       public void CheckRobberycase(string location,string harmed);
       public void ReportCase(string location,string harmed);

       public void UpdateRobberycase(string location);

       public void DeleteRoberrycase(string location);

       public Robberycase GetRobberycase(string location);    

    
    }
}