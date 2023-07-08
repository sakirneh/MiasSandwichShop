namespace MiasSandwichShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            foodTab = new TabControl();
            FoodPage = new TabPage();
            goToCart = new Button();
            lblTotal = new Label();
            BtnRemoveItemFromLSTbox = new Button();
            orderLabel = new Label();
            SandwichGroupBox = new GroupBox();
            sandwichListView = new ListView();
            sandwichListBox = new ListBox();
            DrinksPage = new TabPage();
            goToCart2 = new Button();
            DrinkListView = new ListView();
            lblTotal2 = new Label();
            BTNremoveItem = new Button();
            label3 = new Label();
            drinkListBox = new ListBox();
            DesertPage = new TabPage();
            goToCart3 = new Button();
            DessertListView = new ListView();
            lblTotal3 = new Label();
            BTNremoveLastItem2 = new Button();
            label4 = new Label();
            DessertListBox = new ListBox();
            CartPage = new TabPage();
            CartGroupBox = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            AddCustomSandwitchBTN = new Button();
            label8 = new Label();
            label7 = new Label();
            SpreadCheckedListBox = new CheckedListBox();
            label6 = new Label();
            ToppingsCheckedListBox = new CheckedListBox();
            label5 = new Label();
            label2 = new Label();
            BaseTypeCheckedBox = new CheckedListBox();
            ClearCartOrderBTN = new Button();
            lblTotal4 = new Label();
            PrintOrder = new Button();
            label1 = new Label();
            FinalCartListBox = new ListBox();
            RemoveLastItemInCartPage = new Button();
            foodTab.SuspendLayout();
            FoodPage.SuspendLayout();
            SandwichGroupBox.SuspendLayout();
            DrinksPage.SuspendLayout();
            DesertPage.SuspendLayout();
            CartPage.SuspendLayout();
            CartGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // foodTab
            // 
            foodTab.AllowDrop = true;
            foodTab.Controls.Add(FoodPage);
            foodTab.Controls.Add(DrinksPage);
            foodTab.Controls.Add(DesertPage);
            foodTab.Controls.Add(CartPage);
            foodTab.Location = new Point(0, -1);
            foodTab.Name = "foodTab";
            foodTab.SelectedIndex = 0;
            foodTab.Size = new Size(784, 560);
            foodTab.TabIndex = 0;
            foodTab.Selected += sndwichTabSelected;
            // 
            // FoodPage
            // 
            FoodPage.AllowDrop = true;
            FoodPage.AutoScroll = true;
            FoodPage.Controls.Add(goToCart);
            FoodPage.Controls.Add(lblTotal);
            FoodPage.Controls.Add(BtnRemoveItemFromLSTbox);
            FoodPage.Controls.Add(orderLabel);
            FoodPage.Controls.Add(SandwichGroupBox);
            FoodPage.Controls.Add(sandwichListBox);
            FoodPage.Location = new Point(4, 24);
            FoodPage.Name = "FoodPage";
            FoodPage.Padding = new Padding(3);
            FoodPage.Size = new Size(776, 532);
            FoodPage.TabIndex = 0;
            FoodPage.Text = "Sandwiches";
            FoodPage.UseVisualStyleBackColor = true;
            // 
            // goToCart
            // 
            goToCart.Location = new Point(556, 488);
            goToCart.Name = "goToCart";
            goToCart.Size = new Size(211, 38);
            goToCart.TabIndex = 16;
            goToCart.Text = "Go To Cart";
            goToCart.UseVisualStyleBackColor = true;
            goToCart.Click += goToCart_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(557, 402);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(92, 40);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: ";
            // 
            // BtnRemoveItemFromLSTbox
            // 
            BtnRemoveItemFromLSTbox.Location = new Point(556, 445);
            BtnRemoveItemFromLSTbox.Name = "BtnRemoveItemFromLSTbox";
            BtnRemoveItemFromLSTbox.Size = new Size(211, 38);
            BtnRemoveItemFromLSTbox.TabIndex = 3;
            BtnRemoveItemFromLSTbox.Text = "Remove Last Added Item";
            BtnRemoveItemFromLSTbox.UseVisualStyleBackColor = true;
            BtnRemoveItemFromLSTbox.Click += BtnRemoveItemFromLSTbox_Click;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            orderLabel.Location = new Point(557, 15);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(216, 32);
            orderLabel.TabIndex = 2;
            orderLabel.Text = "Your Current Order";
            // 
            // SandwichGroupBox
            // 
            SandwichGroupBox.Controls.Add(sandwichListView);
            SandwichGroupBox.Location = new Point(3, 0);
            SandwichGroupBox.Name = "SandwichGroupBox";
            SandwichGroupBox.Size = new Size(547, 514);
            SandwichGroupBox.TabIndex = 1;
            SandwichGroupBox.TabStop = false;
            // 
            // sandwichListView
            // 
            sandwichListView.Alignment = ListViewAlignment.SnapToGrid;
            sandwichListView.Location = new Point(3, 6);
            sandwichListView.Name = "sandwichListView";
            sandwichListView.Size = new Size(538, 505);
            sandwichListView.TabIndex = 0;
            sandwichListView.UseCompatibleStateImageBehavior = false;
            sandwichListView.Click += sndwichListViewClick;
            // 
            // sandwichListBox
            // 
            sandwichListBox.FormattingEnabled = true;
            sandwichListBox.ItemHeight = 15;
            sandwichListBox.Location = new Point(556, 50);
            sandwichListBox.Name = "sandwichListBox";
            sandwichListBox.Size = new Size(214, 349);
            sandwichListBox.TabIndex = 0;
            // 
            // DrinksPage
            // 
            DrinksPage.Controls.Add(goToCart2);
            DrinksPage.Controls.Add(DrinkListView);
            DrinksPage.Controls.Add(lblTotal2);
            DrinksPage.Controls.Add(BTNremoveItem);
            DrinksPage.Controls.Add(label3);
            DrinksPage.Controls.Add(drinkListBox);
            DrinksPage.Location = new Point(4, 24);
            DrinksPage.Name = "DrinksPage";
            DrinksPage.Padding = new Padding(3);
            DrinksPage.Size = new Size(776, 532);
            DrinksPage.TabIndex = 1;
            DrinksPage.Text = "Drinks";
            DrinksPage.UseVisualStyleBackColor = true;
            // 
            // goToCart2
            // 
            goToCart2.Location = new Point(557, 488);
            goToCart2.Name = "goToCart2";
            goToCart2.Size = new Size(211, 38);
            goToCart2.TabIndex = 16;
            goToCart2.Text = "Go To Cart";
            goToCart2.UseVisualStyleBackColor = true;
            goToCart2.Click += goToCart2_Click;
            // 
            // DrinkListView
            // 
            DrinkListView.Alignment = ListViewAlignment.SnapToGrid;
            DrinkListView.Location = new Point(3, 8);
            DrinkListView.Name = "DrinkListView";
            DrinkListView.Size = new Size(540, 511);
            DrinkListView.TabIndex = 5;
            DrinkListView.UseCompatibleStateImageBehavior = false;
            DrinkListView.Click += DrinkListViewClick;
            // 
            // lblTotal2
            // 
            lblTotal2.AutoSize = true;
            lblTotal2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal2.Location = new Point(558, 401);
            lblTotal2.Name = "lblTotal2";
            lblTotal2.Size = new Size(92, 40);
            lblTotal2.TabIndex = 9;
            lblTotal2.Text = "Total: ";
            // 
            // BTNremoveItem
            // 
            BTNremoveItem.Location = new Point(557, 444);
            BTNremoveItem.Name = "BTNremoveItem";
            BTNremoveItem.Size = new Size(211, 38);
            BTNremoveItem.TabIndex = 8;
            BTNremoveItem.Text = "Remove Last Added Item";
            BTNremoveItem.UseVisualStyleBackColor = true;
            BTNremoveItem.Click += BTNremoveItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(558, 14);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 7;
            label3.Text = "Your Current Order";
            // 
            // drinkListBox
            // 
            drinkListBox.FormattingEnabled = true;
            drinkListBox.ItemHeight = 15;
            drinkListBox.Location = new Point(557, 49);
            drinkListBox.Name = "drinkListBox";
            drinkListBox.Size = new Size(214, 349);
            drinkListBox.TabIndex = 6;
            // 
            // DesertPage
            // 
            DesertPage.Controls.Add(goToCart3);
            DesertPage.Controls.Add(DessertListView);
            DesertPage.Controls.Add(lblTotal3);
            DesertPage.Controls.Add(BTNremoveLastItem2);
            DesertPage.Controls.Add(label4);
            DesertPage.Controls.Add(DessertListBox);
            DesertPage.Location = new Point(4, 24);
            DesertPage.Name = "DesertPage";
            DesertPage.Padding = new Padding(3);
            DesertPage.Size = new Size(776, 532);
            DesertPage.TabIndex = 2;
            DesertPage.Text = "Deserts";
            DesertPage.UseVisualStyleBackColor = true;
            // 
            // goToCart3
            // 
            goToCart3.Location = new Point(557, 481);
            goToCart3.Name = "goToCart3";
            goToCart3.Size = new Size(211, 38);
            goToCart3.TabIndex = 15;
            goToCart3.Text = "Go To Cart";
            goToCart3.UseVisualStyleBackColor = true;
            goToCart3.Click += goToCart3_Click;
            // 
            // DessertListView
            // 
            DessertListView.Alignment = ListViewAlignment.SnapToGrid;
            DessertListView.Location = new Point(3, 8);
            DessertListView.Name = "DessertListView";
            DessertListView.Size = new Size(540, 511);
            DessertListView.TabIndex = 10;
            DessertListView.UseCompatibleStateImageBehavior = false;
            DessertListView.Click += DessertsListViewClick;
            // 
            // lblTotal3
            // 
            lblTotal3.AutoSize = true;
            lblTotal3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal3.Location = new Point(558, 401);
            lblTotal3.Name = "lblTotal3";
            lblTotal3.Size = new Size(92, 40);
            lblTotal3.TabIndex = 14;
            lblTotal3.Text = "Total: ";
            // 
            // BTNremoveLastItem2
            // 
            BTNremoveLastItem2.Location = new Point(557, 440);
            BTNremoveLastItem2.Name = "BTNremoveLastItem2";
            BTNremoveLastItem2.Size = new Size(211, 38);
            BTNremoveLastItem2.TabIndex = 13;
            BTNremoveLastItem2.Text = "Remove Last Added Item";
            BTNremoveLastItem2.UseVisualStyleBackColor = true;
            BTNremoveLastItem2.Click += BTNremoveLastItem2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(558, 14);
            label4.Name = "label4";
            label4.Size = new Size(216, 32);
            label4.TabIndex = 12;
            label4.Text = "Your Current Order";
            // 
            // DessertListBox
            // 
            DessertListBox.FormattingEnabled = true;
            DessertListBox.ItemHeight = 15;
            DessertListBox.Location = new Point(557, 49);
            DessertListBox.Name = "DessertListBox";
            DessertListBox.Size = new Size(214, 349);
            DessertListBox.TabIndex = 11;
            // 
            // CartPage
            // 
            CartPage.Controls.Add(CartGroupBox);
            CartPage.Location = new Point(4, 24);
            CartPage.Name = "CartPage";
            CartPage.Size = new Size(776, 532);
            CartPage.TabIndex = 3;
            CartPage.Text = "Cart";
            CartPage.UseVisualStyleBackColor = true;
            // 
            // CartGroupBox
            // 
            CartGroupBox.Controls.Add(RemoveLastItemInCartPage);
            CartGroupBox.Controls.Add(label11);
            CartGroupBox.Controls.Add(label10);
            CartGroupBox.Controls.Add(label9);
            CartGroupBox.Controls.Add(AddCustomSandwitchBTN);
            CartGroupBox.Controls.Add(label8);
            CartGroupBox.Controls.Add(label7);
            CartGroupBox.Controls.Add(SpreadCheckedListBox);
            CartGroupBox.Controls.Add(label6);
            CartGroupBox.Controls.Add(ToppingsCheckedListBox);
            CartGroupBox.Controls.Add(label5);
            CartGroupBox.Controls.Add(label2);
            CartGroupBox.Controls.Add(BaseTypeCheckedBox);
            CartGroupBox.Controls.Add(ClearCartOrderBTN);
            CartGroupBox.Controls.Add(lblTotal4);
            CartGroupBox.Controls.Add(PrintOrder);
            CartGroupBox.Controls.Add(label1);
            CartGroupBox.Controls.Add(FinalCartListBox);
            CartGroupBox.Location = new Point(2, 0);
            CartGroupBox.Name = "CartGroupBox";
            CartGroupBox.Size = new Size(774, 532);
            CartGroupBox.TabIndex = 0;
            CartGroupBox.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(621, 276);
            label11.Name = "label11";
            label11.Size = new Size(82, 21);
            label11.TabIndex = 17;
            label11.Text = "Cost : Free";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(621, 137);
            label10.Name = "label10";
            label10.Size = new Size(127, 21);
            label10.TabIndex = 16;
            label10.Text = "Cost : £1.00 each";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(621, 34);
            label9.Name = "label9";
            label9.Size = new Size(127, 21);
            label9.TabIndex = 15;
            label9.Text = "Cost : £0.25 each";
            // 
            // AddCustomSandwitchBTN
            // 
            AddCustomSandwitchBTN.Location = new Point(399, 399);
            AddCustomSandwitchBTN.Name = "AddCustomSandwitchBTN";
            AddCustomSandwitchBTN.Size = new Size(349, 60);
            AddCustomSandwitchBTN.TabIndex = 14;
            AddCustomSandwitchBTN.Text = "Add Custom Sandwitch To Cart";
            AddCustomSandwitchBTN.UseVisualStyleBackColor = true;
            AddCustomSandwitchBTN.Click += AddCustomSandwitchBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(399, 276);
            label8.Name = "label8";
            label8.Size = new Size(59, 21);
            label8.TabIndex = 13;
            label8.Text = "Spread";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(399, 276);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 12;
            // 
            // SpreadCheckedListBox
            // 
            SpreadCheckedListBox.FormattingEnabled = true;
            SpreadCheckedListBox.Items.AddRange(new object[] { "No Spread\t ", "Butter ", "Salted Butter ", "Margarine\t " });
            SpreadCheckedListBox.Location = new Point(399, 300);
            SpreadCheckedListBox.Name = "SpreadCheckedListBox";
            SpreadCheckedListBox.Size = new Size(349, 76);
            SpreadCheckedListBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(399, 137);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 10;
            label6.Text = "Toppings";
            // 
            // ToppingsCheckedListBox
            // 
            ToppingsCheckedListBox.FormattingEnabled = true;
            ToppingsCheckedListBox.Items.AddRange(new object[] { "Cheese ", "Egg ", "Bacon ", "Salad ", "Chicken patty ", "Beef Patty\t " });
            ToppingsCheckedListBox.Location = new Point(399, 161);
            ToppingsCheckedListBox.Name = "ToppingsCheckedListBox";
            ToppingsCheckedListBox.Size = new Size(349, 112);
            ToppingsCheckedListBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(399, 36);
            label5.Name = "label5";
            label5.Size = new Size(78, 21);
            label5.TabIndex = 8;
            label5.Text = "Base Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(399, 19);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 7;
            label2.Text = "Your Custom Sandwich";
            // 
            // BaseTypeCheckedBox
            // 
            BaseTypeCheckedBox.FormattingEnabled = true;
            BaseTypeCheckedBox.Items.AddRange(new object[] { "Burger Bun ", "Grilled Burger Bun ", "Toast ", "White Bread " });
            BaseTypeCheckedBox.Location = new Point(399, 58);
            BaseTypeCheckedBox.Name = "BaseTypeCheckedBox";
            BaseTypeCheckedBox.Size = new Size(349, 76);
            BaseTypeCheckedBox.TabIndex = 5;
            // 
            // ClearCartOrderBTN
            // 
            ClearCartOrderBTN.Location = new Point(6, 465);
            ClearCartOrderBTN.Name = "ClearCartOrderBTN";
            ClearCartOrderBTN.Size = new Size(354, 61);
            ClearCartOrderBTN.TabIndex = 4;
            ClearCartOrderBTN.Text = "Clear Order";
            ClearCartOrderBTN.UseVisualStyleBackColor = true;
            ClearCartOrderBTN.Click += ClearCartOrderBTN_Click;
            // 
            // lblTotal4
            // 
            lblTotal4.AutoSize = true;
            lblTotal4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal4.Location = new Point(172, 23);
            lblTotal4.Name = "lblTotal4";
            lblTotal4.Size = new Size(84, 32);
            lblTotal4.TabIndex = 3;
            lblTotal4.Text = "Total: ";
            // 
            // PrintOrder
            // 
            PrintOrder.Location = new Point(6, 399);
            PrintOrder.Name = "PrintOrder";
            PrintOrder.Size = new Size(356, 60);
            PrintOrder.TabIndex = 2;
            PrintOrder.Text = "Print Order";
            PrintOrder.UseVisualStyleBackColor = true;
            PrintOrder.Click += PrintOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(160, 30);
            label1.TabIndex = 1;
            label1.Text = "Your Final Items";
            // 
            // FinalCartListBox
            // 
            FinalCartListBox.FormattingEnabled = true;
            FinalCartListBox.ItemHeight = 15;
            FinalCartListBox.Location = new Point(6, 58);
            FinalCartListBox.Name = "FinalCartListBox";
            FinalCartListBox.Size = new Size(356, 334);
            FinalCartListBox.TabIndex = 0;
            // 
            // RemoveLastItemInCartPage
            // 
            RemoveLastItemInCartPage.Location = new Point(399, 465);
            RemoveLastItemInCartPage.Name = "RemoveLastItemInCartPage";
            RemoveLastItemInCartPage.Size = new Size(349, 60);
            RemoveLastItemInCartPage.TabIndex = 18;
            RemoveLastItemInCartPage.Text = "Remove Last Item";
            RemoveLastItemInCartPage.UseVisualStyleBackColor = true;
            RemoveLastItemInCartPage.Click += RemoveLastItemInCartPage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(784, 561);
            Controls.Add(foodTab);
            Name = "Form1";
            Text = "Mia's Sandwich Shop";
            Load += Form1_Load;
            foodTab.ResumeLayout(false);
            FoodPage.ResumeLayout(false);
            FoodPage.PerformLayout();
            SandwichGroupBox.ResumeLayout(false);
            DrinksPage.ResumeLayout(false);
            DrinksPage.PerformLayout();
            DesertPage.ResumeLayout(false);
            DesertPage.PerformLayout();
            CartPage.ResumeLayout(false);
            CartGroupBox.ResumeLayout(false);
            CartGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl foodTab;
        private TabPage FoodPage;
        private TabPage DrinksPage;
        private TabPage DesertPage;
        private TabPage CartPage;
        private Label orderLabel;
        private GroupBox SandwichGroupBox;
        private ListBox sandwichListBox;
        private GroupBox CartGroupBox;
        private Button PrintOrder;
        private Label label1;
        private ListBox FinalCartListBox;
        private ListView sandwichListView;
        private Button BtnRemoveItemFromLSTbox;
        private Label lblTotal;
        private ListView DrinkListView;
        private Label lblTotal2;
        private Button BTNremoveItem;
        private Label label3;
        private ListBox drinkListBox;
        private ListView DessertListView;
        private Label lblTotal3;
        private Button BTNremoveLastItem2;
        private Label label4;
        private ListBox DessertListBox;
        private Button goToCart;
        private Button goToCart2;
        private Button goToCart3;
        private Label lblTotal4;
        private Button ClearCartOrderBTN;
        private CheckedListBox BaseTypeCheckedBox;
        private Label label5;
        private Label label2;
        private Label label6;
        private CheckedListBox ToppingsCheckedListBox;
        private Label label8;
        private Label label7;
        private CheckedListBox SpreadCheckedListBox;
        private Button AddCustomSandwitchBTN;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button RemoveLastItemInCartPage;
    }
}