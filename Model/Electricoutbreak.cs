using System;
namespace EMERGENCY_APPLICATION.Model
{
    public class Electricoutbreak:User
    {
        public bool RemoveCircuitBreaker{get;set;}

        public Electricoutbreak(string location,bool removecircuitbreaker):base(location)
        {
        
            Location = location;
            RemoveCircuitBreaker = removecircuitbreaker;
        }
        
    }
}