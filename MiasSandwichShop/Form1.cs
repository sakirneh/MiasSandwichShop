using System.Security.AccessControl;

namespace MiasSandwichShop
{
    public partial class Form1 : Form
    {
        const string SandwichListFilePath = @"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\shop data\Sandwich List.txt";
        const string DrinkListFilePath = @"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\shop data\Drink List.txt";
        const string DessertListFilePath = @"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\shop data\Dessert List.txt";

        const string SandwichImageFilePath = @"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\Images\sandwiches";
        const string DrinkImageFilePath = @"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\Images\Drinks";
        const string DessertImageFilePath = @"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\Images\Desserts";

        Cart cart;

        //SandWich sndWich;
        //Drink drink;
        //Dessert dessert;


        BindingSource cartBindingSource;
        List<Product> products;// create new product list
        List<Product>? CartProductList;
        Product product;

        List<Product>? tempProductList;

        CSVReader? csvSandwichReader;
        CSVReader? csvDrinkReader;
        CSVReader? csvDessertReader;

        public const int cartIndex = 3;

        bool isCustom = false;
        string tempCustomprice = "";

        public Form1()
        {

            InitializeComponent();

            //sndWich = new SandWich();
            //sndWich.GetAllSandwichesFromFile();

            //drink = new Drink();
            //drink.GetAllDrinksFromFile();

            //dessert = new Dessert();
            //dessert.GetAllDessertsFromFile();

            cartBindingSource = new BindingSource();
            cart = new Cart();

            cartBindingSource.DataSource = cart.GetAllProducts();

            sandwichListBox.DataSource = cartBindingSource; // sandwich list box connected to cart.
            sandwichListBox.DisplayMember = ToString();

            drinkListBox.DataSource = cartBindingSource; // drinks list box connected to cart class/ object.
            drinkListBox.DisplayMember = ToString();

            DessertListBox.DataSource = cartBindingSource;
            DessertListBox.DisplayMember = ToString();

            FinalCartListBox.DataSource = cartBindingSource;
            FinalCartListBox.DisplayMember = ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Size = new Size(800, 600); // sets form size to the same as the previous form.
            FormBorderStyle = FormBorderStyle.Fixed3D;
            CenterToScreen();

            this.foodTab.SelectedIndex = 0;
            

            LoadFirstTabOnFormLoad();
        }





        private void FillListBox(string _path, ListView _listView, int index)
        {
            //instantiate new object of ImageList type, set images to 100px by 100px.
            ImageList images = new ImageList();
            images.ImageSize = new Size(200, 200);


            //load images from file path given.
            String[] paths = { };
            paths = Directory.GetFiles(_path);

            try
            {
                foreach (string path in paths)
                {
                    images.Images.Add(Image.FromFile(path));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            _listView.SmallImageList = images;

            for (int i = 0; i < index; i++)
            {
                _listView.Items.Add(products[i].productName + products[i].price, i);
            }

        }





        private void BtnRemoveItemFromLSTbox_Click(object sender, EventArgs e)
        {
            CartProductList = cart.GetAllProducts();
            try
            {
                product = CartProductList[CartProductList.Count - 1];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Your Cart is already Empty!");
                Console.WriteLine(ex);
            }
            cart.RemoveFromCart(product);
            cartBindingSource.ResetBindings(false);
            if (isCustom == true)
            {
                lblTotal.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            }
            else
            {
                lblTotal.Text = "Total: £" + cart.Total().ToString();
            }
        }


        private void sndwichListViewClick(object sender, EventArgs e)
        {
            String Selected = sandwichListView.SelectedItems[0].SubItems[0].Text;


            for (int i = 0; i < products.Count; i++)
            {
                string temp = products[i].productName + products[i].price;
                if (temp == Selected)
                {
                    product = products[i];
                    cart.AddToCart(product);

                    cartBindingSource.ResetBindings(false);
                    
                    if (isCustom == true)
                    {
                        lblTotal.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
                        
                    }
                    else
                    {
                        lblTotal.Text = "Total: £" + cart.Total().ToString();
                    }
                    break;
                }
            }
        }

        private void sndwichTabSelected(object sender, TabControlEventArgs e)
        {

            int tabSelected = foodTab.SelectedIndex;

            csvSandwichReader = new CSVReader(SandwichListFilePath);
            csvDrinkReader = new CSVReader(DrinkListFilePath);
            csvDessertReader = new CSVReader(DessertListFilePath);


            if (isCustom == true)
            {
                lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
                lblTotal3.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
                lblTotal2.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
                lblTotal.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
                
            }
            else
            {
                lblTotal.Text = "Total: £" + cart.Total().ToString();
                lblTotal2.Text = "Total: £" + cart.Total().ToString();
                lblTotal3.Text = "Total: £" + cart.Total().ToString();
                lblTotal4.Text = "Total: £" + cart.Total().ToString();
            }

            //clear the images displayed on the form otherwise they will load again once switched back to the same tab.
            sandwichListView.Clear();
            DrinkListView.Clear();
            DessertListView.Clear();

            DrinkListView.View = View.Details;
            sandwichListView.View = View.Details;
            DessertListView.View = View.Details;


            //make columns for the listbox view.
            sandwichListView.Columns.Add("Sandwich Options", 200, HorizontalAlignment.Left);
            sandwichListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            DrinkListView.Columns.Add("Drink Options", 200, HorizontalAlignment.Left);
            DrinkListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            DessertListView.Columns.Add("Dessert Options", 200, HorizontalAlignment.Left);
            DessertListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);



            int index;
            switch (tabSelected)
            {
                case 0:
                    tempProductList = csvSandwichReader.GetAllProductsFromFile();

                    products = csvSandwichReader.GetAllProducts();
                    index = tempProductList.Count;

                    FillListBox(SandwichImageFilePath, sandwichListView, index);
                    break;
                case 1:
                    tempProductList = csvDrinkReader.GetAllProductsFromFile();

                    products = csvDrinkReader.GetAllProducts();
                    index = tempProductList.Count;

                    FillListBox(DrinkImageFilePath, DrinkListView, index);
                    break;
                case 2:
                    tempProductList = csvDessertReader.GetAllProductsFromFile();

                    products = csvDessertReader.GetAllProducts();
                    index = tempProductList.Count;

                    FillListBox(DessertImageFilePath, DessertListView, index);
                    break;
                case 3:
                    if (isCustom == true)
                    {
                        lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
                    }
                    else
                    {
                        lblTotal4.Text = "Total: £" + cart.Total().ToString();
                    }
                    break;
                default:
                    break;
            }


        }

        private void DrinkListViewClick(object sender, EventArgs e)
        {
            String Selected = DrinkListView.SelectedItems[0].SubItems[0].Text;


            for (int i = 0; i < products.Count; i++)
            {
                string temp = products[i].productName + products[i].price;
                if (temp == Selected)
                {
                    product = products[i];
                    cart.AddToCart(product);

                    cartBindingSource.ResetBindings(false);
                    if (isCustom == true)
                    {
                        lblTotal2.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
                    }
                    else
                    {
                        lblTotal2.Text = "Total: £" + cart.Total().ToString();
                    }
                    break;
                }
            }
        }

        private void DessertsListViewClick(object sender, EventArgs e)
        {
            String Selected = DessertListView.SelectedItems[0].SubItems[0].Text;


            for (int i = 0; i < products.Count; i++)
            {
                string temp = products[i].productName + products[i].price;
                if (temp == Selected)
                {
                    product = products[i];
                    cart.AddToCart(product);

                    cartBindingSource.ResetBindings(false);
                    if (isCustom == true)
                    {
                        lblTotal3.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString(); 
                    }
                    else
                    {
                        lblTotal3.Text = "Total: £" + cart.Total().ToString();
                    }
                    break;
                }
            }
        }

        private void BTNremoveItem_Click(object sender, EventArgs e)
        {
            CartProductList = cart.GetAllProducts();
            try
            {
                product = CartProductList[CartProductList.Count - 1];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Your Cart is already Empty!");
                Console.WriteLine(ex);
            }
            cart.RemoveFromCart(product);
            cartBindingSource.ResetBindings(false);
            if (isCustom == true)
            {
                lblTotal2.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            }
            else
            {
                lblTotal2.Text = "Total: £" + cart.Total().ToString();
            }
        }

        private void BTNremoveLastItem2_Click(object sender, EventArgs e)
        {
            CartProductList = cart.GetAllProducts();
            try
            {
                product = CartProductList[CartProductList.Count - 1];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Your Cart is already Empty!");
                Console.WriteLine(ex);
            }
            cart.RemoveFromCart(product);
            cartBindingSource.ResetBindings(false);
            if (isCustom == true)
            {
                lblTotal3.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            }
            else
            {
                lblTotal3.Text = "Total: £" + cart.Total().ToString();
            }
        }

        private void goToCart_Click(object sender, EventArgs e)
        {
            this.foodTab.SelectedIndex = cartIndex;
            if (isCustom == true)
            {
                lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            }
            else
            {
                lblTotal4.Text = "Total: £" + cart.Total().ToString();
            }
        }

        private void goToCart2_Click(object sender, EventArgs e)
        {
            this.foodTab.SelectedIndex = cartIndex;
            if (isCustom == true)
            {
                lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            }
            else
            {
                lblTotal4.Text = "Total: £" + cart.Total().ToString();
            }
        }

        private void goToCart3_Click(object sender, EventArgs e)
        {
            this.foodTab.SelectedIndex = cartIndex;
            if (isCustom == true)
            {
                lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            }
            else
            {
                lblTotal4.Text = "Total: £" + cart.Total().ToString();
            }
        }

        private void PrintOrder_Click(object sender, EventArgs e)
        {
            cart.WriteContents();
        }

        private void ClearCartOrderBTN_Click(object sender, EventArgs e)
        {
            ClearListBoxes();

            foreach (Product item in cart.GetAllProducts().ToList())
            {
                cart.RemoveFromCart(item);
            }

            foreach (int i in BaseTypeCheckedBox.CheckedIndices)
            {
                BaseTypeCheckedBox.SetItemCheckState(i,CheckState.Unchecked);
            }
            foreach (int b in ToppingsCheckedListBox.CheckedIndices)
            {
                ToppingsCheckedListBox.SetItemCheckState(b, CheckState.Unchecked);
            }
            foreach (int c in SpreadCheckedListBox.CheckedIndices)
            {
                SpreadCheckedListBox.SetItemCheckState(c, CheckState.Unchecked);
            }
            isCustom = false;


            SetDataSources();
        }

        private void SetDataSources()
        {
            FinalCartListBox.DataSource = cartBindingSource;
            sandwichListBox.DataSource = cartBindingSource;
            drinkListBox.DataSource = cartBindingSource;
            DessertListBox.DataSource = cartBindingSource;
        }

        private void ClearListBoxes()
        {
            FinalCartListBox.DataSource = null;
            FinalCartListBox.Items.Clear();
            lblTotal4.Text = "Total:";

            sandwichListBox.DataSource = null;
            sandwichListBox.Items.Clear();

            drinkListBox.DataSource = null;
            drinkListBox.Items.Clear();

            DessertListBox.DataSource = null;
            DessertListBox.Items.Clear();
        }

        private void LoadFirstTabOnFormLoad()
        {
            csvSandwichReader = new CSVReader(SandwichListFilePath);

            tempProductList = csvSandwichReader.GetAllProductsFromFile();

            //int index = sndwich.GetAllProducts().Count;
            int index = tempProductList.Count;
            sandwichListView.View = View.Details;

            //make columns for the listbox view.
            sandwichListView.Columns.Add("Sandwich Options", 200, HorizontalAlignment.Left);
            sandwichListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

            products = csvSandwichReader.GetAllProducts();
            FillListBox(SandwichImageFilePath, sandwichListView, index);
        }

        private void AddCustomSandwitchBTN_Click(object sender, EventArgs e)
        {
            isCustom = true;

            string CustomBase = "";
            string CustomToppings = "";
            string CustomSpread = "";
            decimal Customprice = 0.0M;

            foreach (string basetype in BaseTypeCheckedBox.CheckedItems)
            {
                CustomBase = CustomBase + basetype;
                Customprice += 0.25M;
            }

            foreach (string toppings in ToppingsCheckedListBox.CheckedItems)
            {
                CustomToppings = CustomToppings + " " + toppings;
                Customprice += 1.00M;
            }

            foreach (string spread in SpreadCheckedListBox.CheckedItems)
            {
                CustomSpread = CustomSpread + spread;
            }
            tempCustomprice = Convert.ToString(Customprice);

            CustomSandwich customSandwich = new CustomSandwich(CustomBase, CustomToppings, CustomSpread);

            
            cart.AddToCart(customSandwich);
            isCustom = true;
            lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();


            cartBindingSource.ResetBindings(false);
            FinalCartListBox.DisplayMember = ToString();
            //cartBindingSource.ResetBindings(false);

            

            
            //lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            //FinalCartListBox.DisplayMember = ToString();

        }

        private void RemoveLastItemInCartPage_Click(object sender, EventArgs e)
        {
            CartProductList = cart.GetAllProducts();
            try
            {
                product = CartProductList[CartProductList.Count - 1];
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Your Cart is already Empty!");
                Console.WriteLine(ex);
            }
            cart.RemoveFromCart(product);
            cartBindingSource.ResetBindings(false);
            if (isCustom == true)
            {
                lblTotal4.Text = "Total: £" + cart.CustomTotal(tempCustomprice).ToString();
            }
            else
            {
                lblTotal4.Text = "Total: £" + cart.Total().ToString();
            }
        }
    }
}