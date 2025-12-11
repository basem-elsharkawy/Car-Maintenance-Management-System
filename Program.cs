using System; 

namespace CarMaintenanceSystem
{
    // Start Vehicle Category Class
     class VehicleCategory
    {
        private string categoryID;
        private string name;
        private string description;

        public string CategoryID { get { return categoryID; } }
        public string Name { get { return name; } }
        public string Description { get { return description; } }

        public VehicleCategory(string categoryID, string name, string description)
        {
            this.categoryID = categoryID;
            this.name = name;
            this.description = description;
        }
     // Ends Vehicle Category Class

    // Start Sedan Class 
     class Sedan : VehicleCategory
    {
        public Sedan(string categoryID, string name, string description)
            : base(categoryID, name, description) { }

        public void checkFuelEfficiency()
        {
           // Console.WriteLine("Checking fuel efficiency for sedan...");  //Waiting untill final decision
        }
    }
    // End Sedan Class

    // Start SUV Class
     class SUV : VehicleCategory
    {
        public SUV(string categoryID, string name, string description)
            : base(categoryID, name, description) { }

        public void checkOffRoadCapability()
        {
          //  Console.WriteLine("Checking off-road capability for SUV...");   // //Waiting untill final decision
        }
    }
    // End SUV Class
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
