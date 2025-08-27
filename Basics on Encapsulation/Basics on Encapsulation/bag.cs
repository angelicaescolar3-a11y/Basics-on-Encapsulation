using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_on_Encapsulation
{
    internal class Bag
    {
        //NAME: ANGELICA ESCOLAR
        //SECTION: IT301
        //EXERCISE TITLE: Basics on Encapsulation

        //declare bag fields
        private string brand;
        private int price;

        //Set properties for the fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        //Method to display bag details
        public void DisplayBagDetails()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Price: " + price);
        }

    }
}
