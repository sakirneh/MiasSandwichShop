using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwichShop
{
    public class CustomSandwich : Product
    {

        
        public string baseType { get; set; }
        public string toppings { get; set; }
        public string spread { get; set; }

        
        public CustomSandwich(string _baseType, string _toppings, string _spread)
        {
            
            baseType = _baseType;
            toppings = _toppings;
            spread = _spread;
        }
        //string baseType, string toppings, string spread
        public override string ToString()
        {

            return $"{baseType},{toppings},{spread}";
        }
    }
}
