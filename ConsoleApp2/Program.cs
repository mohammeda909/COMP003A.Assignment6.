/*
 * Author: mohammed ali
 * Course: COMP-003A
 * Purpose: Object-oriented programming concepts for week 6
 */
using System.Diagnostics;

namespace COMP003A.Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Printing separator for vehicle1 section
            PrintSeparator("vehicle1");
            // Instantiating vehicle1 as a Car object
            Vehicle vehicle1 = new Car();
            // Setting properties for vehicle1
            vehicle1.Brand = "Tesla";
            vehicle1.Model = "Model X";
            vehicle1.NumberOfWheels = 4;
            // Displaying information about vehicle1
            vehicle1.GetInfo();

            // Printing separator for vehicle2 section
            PrintSeparator("vehicle2");
            // Instantiating vehicle2 as a Car object using object initializer syntax
            Vehicle vehicle2 = new Car()
            {
                Brand = "Toyota",
                Model = "Supra",
                NumberOfWheels = 4
            };
            // Displaying information about vehicle2
            vehicle2.GetInfo();
            // Showing that properties of vehicle2 can still be accessed directly
            Console.WriteLine("But you can still access my Properties.");
            Console.WriteLine($"{vehicle2.Brand} {vehicle2.Model} {vehicle2.NumberOfWheels}");

            // Printing separator for vehicle3 section
            PrintSeparator("vehicle3");
            // Instantiating vehicle3 as a Truck object with specific parameters
            Vehicle vehicle3 = new Truck("GMC", "Sierra 1500 AT4", 6, 5.5);
            // Displaying information about vehicle3
            vehicle3.GetInfo();

            // Printing separator for vehicle4 section
            PrintSeparator("vehicle4");
            // Instantiating vehicle4 as a Truck object with named arguments
            Vehicle vehicle4 = new Truck(truckNumberOfWheels: 4, truckBrand: "Ford", truckModel: "F-150 Raptor", sizeOfTruckBed: 5.5);
            // Displaying information about vehicle4
            vehicle4.GetInfo();
        }

        // Method to print a separator for different sections
        static void PrintSeparator(string sectionName)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine($"\t{sectionName} Section");
            Console.WriteLine("".PadRight(50, '*'));
        }
    }
}
