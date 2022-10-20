using System;
namespace EMERGENCY_APPLICATION.Model
{
    public class Fireoutbreak:User
    {
        public string TypeOfBuilding{get;set;}

        public bool FireExtigushier{get;set;}


        public Fireoutbreak(string location,string typeofbuilding,bool fireextigushier ):base(location)
        {
            Location = location;
            TypeOfBuilding = typeofbuilding;
            FireExtigushier = fireextigushier;
        }
    }
}