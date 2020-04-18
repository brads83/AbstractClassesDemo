using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles


            //Create an abstract class called Vehicle
            // Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle

            // Create a list of Vehicle called vehicles
            
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car = new Car() { Year = 1999, Make = "Buick", Model = "Century", HasTrunk = true };
            Motorcycle cycle = new Motorcycle() { Year = 1994, Make = "Honda", Model = "Ninja", HasSideCart = false };
            Vehicle vehicle1 = new Car() { Year = 2019, Make = "Kia", Model = "Forte", HasTrunk = true };
            Vehicle vehicle2 = new Motorcycle() { Year = 1997, Make = "Harley Davidson", Model = "Softtail", HasSideCart = false };


            /*cycle.Make = "Honda";
            cycle.Model = "Ninja";
            cycle.Year = 1994;

            vehicle1.Make = "Kia";
            vehicle1.Model = "Forte";
            vehicle1.Year = 2019;

            vehicle2.Make = "Harley Davidson";
            vehicle2.Model = "Softail";
            vehicle2.Year = 1997;

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car);
            vehicles.Add(cycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach(var item in vehicles)
            {
                Console.WriteLine($"Year: {item.Year} Make: {item.Make} Model: {item.Model}");
                item.DriveAbstract();
                item.DriveVirtual();
            }

            /* Call each of the drive methods for one car and one motorcycle
            vehicle1.DriveAbstract();
            vehicle1.DriveVirtual();
            vehicle2.DriveVirtual();*/
            
            #endregion
            Console.ReadLine();
        }
    }
}
