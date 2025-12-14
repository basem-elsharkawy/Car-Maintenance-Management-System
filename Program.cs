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

    // Start Service providers class
    class ServiceProviders{
        struct ServiceProvider
{
public string ID;
public string Name;
public string Service;

// Constructor
public ServiceProvider(string id, string name, string service)
{
ID = id;
Name = name;
Service = service;
}
}
                    // Creating service providers (static data)
ServiceProvider sp1 = new ServiceProvider(
"POV001",
"Car Care Center",
"Oil Change"
);

ServiceProvider sp2 = new ServiceProvider(
"POV002",
"Speed Fix Garage",
"Engine Repair"
);

ServiceProvider sp3 = new ServiceProvider(
"POV003",
"Auto Shine",
"Car Washing"
);

ServiceProvider sp4 = new ServiceProvider(
"POV004",
"Brake Masters",
"Brake Maintenance"
);

static void PrintServiceProvider(ServiceProvider sp)
{
Console.WriteLine("ID: " + sp.ID);
Console.WriteLine("Name: " + sp.Name);
Console.WriteLine("Service: " + sp.Service);
Console.WriteLine("----------------------");
        }
    
    // End Service providers class

     // Start MaintenanceRecord Class
        //  MaintenanceRecord.cs
    public class MaintenanceRecord
    {
        // Private data for encapsulation
        private string vehicleID; 
        private string vehicleName;
        private string categoryName; // e.g., "Sedan" or "SUV"
        private string maintenanceTask;
        private string assignedProviderID = "Unassigned"; // Store the ID 

        // Public Constructor
        public MaintenanceRecord(string vehicleID, string vehicleName, string categoryName, string maintenanceTask)
        {
            this.vehicleID = vehicleID;
            this.vehicleName = vehicleName;
            this.categoryName = categoryName;
            this.maintenanceTask = maintenanceTask;
        }

        // Method required for assigning provider in a separate step[span_14](end_span)[span_15](end_span)
        public void AssignProvider(string providerID)
        {
            this.assignedProviderID = providerID;
        }
        
        // Getters/Properties
        public string VehicleID => vehicleID;
        public string VehicleName => vehicleName;
        public string MaintenanceTask => maintenanceTask;
        public string AssignedProviderID => assignedProviderID;

        // Method to display the record details
        public void DisplayRecord()
        {
            Console.WriteLine($"\t- Vehicle ID: {vehicleID}, Name: {vehicleName}");
            Console.WriteLine($"\t  Category: {categoryName}, Task: {maintenanceTask}");
            Console.WriteLine($"\t  Provider ID: {assignedProviderID}");
        }
    }
    // End MaintenanceRecord Class

   
   
    }
     class Program
    {
        static void Main(string[] args)
        {

    }
}
}
