using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwichShop
{
    public class Product // setting class access level to public - other classes can access properties and methods
    {
        // properties of Product Class objects.
        public string? ID { get; set; }
        public string? productName { get; set; }
        public int productCount { get; set; }
        public string? price { get; set; }

        // constructor used to initialise Product objects with 3 parameters.
        public Product(string _productName, string _ID, string _price)
        {
            productName = _productName;
            ID = _ID;
            price = _price;
        }

        public Product() // empty constructor - used to test objects and create new objects without parameters. ( can still set parameters of created objects)
        {

        }
        ~Product() // deconstructor - removes unused objects from memory// manages memory.
        {

        }

        public override string ToString() // overriden method to output the name, id and price of product object
        {
            return $"{productName},{ID},{price}";
        }


    }
}
