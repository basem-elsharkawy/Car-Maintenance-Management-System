using System;
using static CarMaintenanceSystem.ServiceProviders;

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
                 Console.WriteLine("Checking fuel efficiency for sedan..."); 
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
                  Console.WriteLine("Checking off-road capability for SUV...");  
            }
        }
        // End SUV Class
    }

    // Start Service providers class
    class ServiceProviders
    {
       public struct ServiceProvider
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
            private DateTime maintenanceDate;
            // Public Constructor
            public MaintenanceRecord(string vehicleID, string vehicleName, string categoryName, string maintenanceTask , DateTime maintenanceDate)
            {
                this.vehicleID = vehicleID;
                this.vehicleName = vehicleName;
                this.categoryName = categoryName;
                this.maintenanceTask = maintenanceTask;
                this.maintenanceDate = maintenanceDate;
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
            public DateTime MaintenanceDate => maintenanceDate;
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
    public class MaintanceManager
    {
        MaintenanceRecord[] records = new MaintenanceRecord[10];
        int recordcount = 0;
        ServiceProvider[] providers = 
           {
            new ServiceProvider("POV001","Car Care Center","Oil Change"),
            new ServiceProvider("POV002","Speed Fix Garage","Engine Repair"),
            new ServiceProvider("POV003","Auto Shine","Car Washing"),
            new ServiceProvider("POV004","Brake Masters","Brake Maintenance")
        };


        public void scheduleMaintenance()
        {
            Console.WriteLine("Scheduling Maintenance:");
            if (recordcount > records.Length)
                Console.WriteLine(" Cannot add more maintenance records");
            else
            {

                Console.WriteLine("Enter vehicleID");
                string id = Console.ReadLine();
                Console.WriteLine("Enter vehicleName");
                string name = Console.ReadLine();
                Console.WriteLine("Enter vehicleCategory \n 1-Sedan \n 2-SUV");
                string cat = "";
                int c = int.Parse(Console.ReadLine());
                string category = (c == 1) ? "Sedan" : "SUV";
                Console.WriteLine("Enter maintancetask");
                string task = Console.ReadLine();
                Console.Write("Enter Maintenance Date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                records[recordcount] = new MaintenanceRecord(id, name, category, task,date);
                ++recordcount;
                Console.WriteLine($"Maintenace task {task} scheduled successfuly for {cat}{name}(ID:{id})!");
            }
        }

        public void viewMaintenanceHistory()
        {
            Console.WriteLine("View Maintenance History:");
            if (recordcount == 0)
            {
                Console.WriteLine("NO Maintenance records available");
                return;
            }
            else
            {
                Console.WriteLine("-------UPComing Maintenance Services-------");
                bool T1 = false;
                for (int i = 0; i < records.Length; i++)
                {
                    if (records[i].MaintenanceDate > DateTime.Now)
                    {
                        records[i].DisplayRecord();
                        T1 = true;
                    }
                }
                if (T1 = false)
                    Console.WriteLine("there is no upcomingservices");
                Console.WriteLine("-------Past Maintenance Services-------");
                bool T2 = false;
                for (int i = 0; i < records.Length; i++)
                {
                    if (records[i].MaintenanceDate < DateTime.Now)
                    {
                        records[i].DisplayRecord();
                        T2 = true;
                    }
                }
                if (T2 = false)
                    Console.WriteLine("there is no upcomingservices");
            }
        }
        public void assignServiceProvider()
        {
            Console.WriteLine("Assign Service Provider:");
            Console.WriteLine("Enter vehicle ID");
            string vid = Console.ReadLine();
            Console.WriteLine("Enter provider ID");
            string pid = Console.ReadLine();
            for (int i = 0; i < recordcount; i++)
            {
                if (records[i].VehicleID == vid)
                {
                    records[i].AssignProvider(pid);
                    Console.WriteLine($" Service Provider {pid} assigned successfully to vehicle ID {vid}!");
                    return;
                }
            }
            Console.WriteLine("Vehicle not found.");
        }
        public void viewServiceProviders()
        {
            foreach (var sp in providers)
            {
                Console.WriteLine($"ID: {sp.ID}, Name: {sp.Name}, Service: {sp.Service}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
