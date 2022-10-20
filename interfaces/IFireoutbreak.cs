using System;
using EMERGENCY_APPLICATION.Model;
namespace EMERGENCY_APPLICATION.interfaces
{
    public interface IFireoutbreak
    {
         
       public void CheckFireoutbreak(string location,string typeofbuilding ,bool fireextigushier);
       public void ReportFireoutbreak( string location,string typeofbuilding,bool fireextigushier);

       public void UpdateFireoutbreak(string location);

       public void DeleteFireoutbreak(string location);

       public Fireoutbreak GetFireoutbreak(string location);    

    }
}