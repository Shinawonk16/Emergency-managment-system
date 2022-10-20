using System;
namespace EMERGENCY_APPLICATION.Model
{
    public class Robberycase:User
    {
        public string Harmed{set;get;}

        public Robberycase(string location,string harmed):base(location)
        {
            Location = location;
            Harmed =  harmed;

        }
    }
}