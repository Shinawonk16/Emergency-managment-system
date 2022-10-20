using System;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.interfaces
{
    public interface IElectricoutbreak
    {
         
       public void CheckElectricoutbreak( string location,bool removecircuitbreaker);
       
       public void ReportElectricoutbreak( string location,bool removecircuitbreaker);

       public void UpdateElectricoutbreak(string location);

       public void DeleteElectricoutbreak(string location); 

       public Electricoutbreak GetElectricoutbreak(string location);    
    }
}