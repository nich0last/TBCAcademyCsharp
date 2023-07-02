using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    // Abstract base class for all vehicles
    public abstract class Vehicle
    {
        public double Mass { get; set; } // Mass in kg
        public double Speed { get; set; } // Speed in km/h
        public bool HasCruiseControl { get; set; }
        public int NumberOfDoors { get; set; }

        public abstract void DisplayInfo();
    }

    // Interface for vehicles with types
    public interface IVehicleType
    {
        void DisplayTypes();
    }

    // Types of Battle Vehicles
    public class BattleVehicle : Vehicle, IVehicleType
    {
        public enum BattleVehicleType
        {
            Tank,
            BTR
            // Add more types as needed
        }

        public void DisplayTypes()
        {
            Console.WriteLine("1) Tank");
            Console.WriteLine("2) BTR");
            // Display more types as needed
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Battle Vehicle Info:");
            Console.WriteLine($"Mass: {Mass} kg");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Cruise Control: {(HasCruiseControl ? "Yes" : "No")}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Types of Consumer Vehicles
    public class ConsumerVehicle : Vehicle, IVehicleType
    {
        public enum ConsumerVehicleType
        {
            Sedan,
            Jeep,
            Motorcycle,
            Bicycle
            // Add more types as needed
        }

        public void DisplayTypes()
        {
            Console.WriteLine("1) Sedan");
            Console.WriteLine("2) Jeep");
            Console.WriteLine("3) Motorcycle");
            Console.WriteLine("4) Bicycle");
            // Display more types as needed
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Consumer Vehicle Info:");
            Console.WriteLine($"Mass: {Mass} kg");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Cruise Control: {(HasCruiseControl ? "Yes" : "No")}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Types of Public Transport
    public class PublicTransport : Vehicle, IVehicleType
    {
        public enum PublicTransportType
        {
            Bus,
            MicroBus,
            CableCar
            // Add more types as needed
        }

        public void DisplayTypes()
        {
            Console.WriteLine("1) Bus");
            Console.WriteLine("2) MicroBus");
            Console.WriteLine("3) Cable Car");
            // Display more types as needed
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Public Transport Info:");
            Console.WriteLine($"Mass: {Mass} kg");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Cruise Control: {(HasCruiseControl ? "Yes" : "No")}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    // Types of Sports Cars
    public class SportsCar : Vehicle, IVehicleType
    {
        public enum SportsCarType
        {
            Formula1,
            Rally,
            Offroad
            // Add more types as needed
        }

        public void DisplayTypes()
        {
            Console.WriteLine("1) Formula 1");
            Console.WriteLine("2) Rally");
            Console.WriteLine("3) Offroad");
            // Display more types as needed
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Sports Car Info:");
            Console.WriteLine($"Mass: {Mass} kg");
            Console.WriteLine($"Speed: {Speed} km/h");
            Console.WriteLine($"Cruise Control: {(HasCruiseControl ? "Yes" : "No")}");
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }
}
