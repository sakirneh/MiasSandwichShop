using MiasSandwichShop;
using System;

public class Cart
{
	//creat list of products, strings
	private List<Product> products = new List<Product>();
	private List<string> OutContents = new List<string>();

	//two variables 
	private decimal total;
	private decimal tempTotal;

    private bool isNum;

	//empty constructor 
	public Cart()
	{
		
	}
	// method that adds a passed object of Product Class to a product list.
	public void AddToCart(Product product)
	{
		products.Add(product);
	}


	//method that removes a passed product object of Product class from a product list.
	public void RemoveFromCart(Product product)
	{
		products.Remove(product);
	}


    public List<Product> GetAllProducts() // example of abstraction - hiding the list of products in a method rather than manually getting and setting it.
	{
		return products;
	}

	public decimal Total() // method for adding the price of each product in a list into a single variable of type double.
	{
		total = 0.0m;

		foreach (var item in products)
		{
			total = total + Convert.ToDecimal(item.price);
			if (item.price == null)
			{
				
			}
		}
		return total;
		
	}
	public decimal CustomTotal(string customPrice)
	{
		
        total = 0.0m;
        total = total + Convert.ToDecimal(customPrice);
        foreach (var item in products)
        {
            total = total + Convert.ToDecimal(item.price);
            if (item.price == null)
            {

            }
        }
        


		return total;
	}

    public void WriteContents()
    {
		
        string OutFile = @"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\shop data\Receipt.txt";
        foreach (Product p in products)
        {
            OutContents.Add(p.ToString());
            File.WriteAllLines(OutFile, OutContents);
        }

        tempTotal = total * 1.2m;
        OutContents.Add($"£ {total.ToString()}");
        OutContents.Add($"VAT Total:{tempTotal}\n");
        File.WriteAllLines(OutFile, OutContents);

        MessageBox.Show($"Total:£{total}\nVAT Total:£{tempTotal.ToString()}");


    }


}
