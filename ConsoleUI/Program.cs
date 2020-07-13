using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            /*
             * Create an abstract class called Vehicle - DONE 
             * The vehicle class shall have three string properties Year, Make, and Model- Done
             * Set the defaults to something generic in the Vehicle class- Done 
             * Vehicle shall have an abstract method called DriveAbstract with no implementation-Done 
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.-Done 
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle- DONE
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle -DONE
             * Provide the implementations for the abstract methods - DONE
             * Only in the Motorcycle class will you override the virtual drive method -Done 
            */

            // Create a list of Vehicle called vehicles-Done 

            var vehicles = new List<Vehicle>();




            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class -DONW 
             * Set the properties with object initializer syntax
             */

            var audi = new Car() { HasTrunk= true, Make = "Audi", Model = "A7", Year = 2012};

            var motorcyle = new Motorcycle { HasSideCart = true, Make = "Harley", Model = "Chopper", Year = 2018 };

            Vehicle suv = new Car() { HasTrunk = true, Make = "Chevrolet", Model = "Tahoe", Year = 2014 };

            Vehicle sedan = new Car() { HasTrunk = true, Make = "Honda ", Model = "Accord", Year = 2008 };





            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             * 
             */

            vehicles.Add(audi);
            vehicles.Add(motorcyle);
            vehicles.Add(suv);
            vehicles.Add(sedan);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make {veh.Make}, Model {veh.Model}, Year {veh.Year}");

                veh.DriveAbstract();
                
            }
            
           





            // Call each of the drive methods for one car and one motorcycle


            
            #endregion            
            Console.ReadLine();
        }
    }
}
