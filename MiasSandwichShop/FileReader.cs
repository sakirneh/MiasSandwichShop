using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiasSandwichShop
{
    abstract class FileReader
    {
        abstract public List<Product> GetAllProductsFromFile();

        abstract public List<Product> GetAllProducts();

    }
}
