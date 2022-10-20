namespace EMERGENCY_APPLICATION.Model
{
    public class Accident:User
    {

        public string TypeOffAccident{get;set;}

        public string Position{get;set;}


        public Accident( string location, string typeoffaccident, string position ):base(location)
        {
            
            Location = location;
            TypeOffAccident = typeoffaccident;
            Position = position;
        }
    }    
        
}