using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace MiasSandwichShop 
{
     class CSVReader : FileReader
    {
        string filePath;
        List<Product> products = new List<Product>();
        List<string> lines = new List<string>();
        public CSVReader(string _filePath)
        {
            filePath = _filePath;
        }

        public override List<Product> GetAllProductsFromFile()
        {

            lines = File.ReadAllLines(filePath).ToList(); 

            try
            {
                foreach (string line in lines)
                {
                    string[] items = line.Split(',');
                    Product product = new Product(items[0], items[1], items[2]);
                    products.Add(product);

                }
                return products;
            }
            catch (Exception ex)
            {
                return products;
            }
        }
        public override List<Product> GetAllProducts()
        {
            return products;
        }


    }
}
