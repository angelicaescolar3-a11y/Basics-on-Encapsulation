using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Basics_on_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the bag from the fields
            Bag bag1 = new Bag();

            //Set properties using the setter method
            bag1.Brand = "Belinda";
            bag1.Price = 300;

            //Display bag dertails using the method
            bag1.DisplayBagDetails();

            Console.ReadKey();
        }

        
    }
}
