namespace EMERGENCY_APPLICATION
{
    public class Complaints
    {
        public string Fullname {get;set;}
        public string Location {get;set;}
        public string AcidentType {get;set;}
        public string Position {get;set;}

        public Complaints(string fullname,string location,string typeoffaccident, string position)
        {
            Fullname = fullname;
            Location = location;
            AcidentType = typeoffaccident;
            Position  = position; 
        }
    }
}