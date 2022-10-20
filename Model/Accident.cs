namespace EMERGENCY_APPLICATION.Model
{
    public class Accident:User
    {

        public string TypeOffAccident{get;set;}



        public Accident( string location, string typeoffaccident):base(location)
        {
            
            Location = location;
            TypeOffAccident = typeoffaccident;
            
        }
    }    
        
}