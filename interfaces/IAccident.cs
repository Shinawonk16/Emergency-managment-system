using System;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.interfaces
{
    public interface IAccident
    {
       public void CheckAccident (string location,string typeoffaccident);

       public void ReportAccident(string location,string typeOfAccident);

       public void UpdateAccident(string location);

       public void DeleteAccident (string location);
       
       public Accident GetAccident(string location);                                                                                                                  
    }
}    