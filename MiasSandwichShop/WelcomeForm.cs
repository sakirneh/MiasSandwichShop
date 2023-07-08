using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;



namespace MiasSandwichShop
{
    public partial class WelcomeForm : Form
    {
        Image? logo;
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            Size = new Size(800, 600); // sets size of form 800px wide and 600 px high.
            CenterToScreen();
            FormBorderStyle = FormBorderStyle.Fixed3D; // cannot change the size of the form window - improves visual and reduces potential issues with changing the size of a window when displaying information.
            logoPicBoxImage.SizeMode = PictureBoxSizeMode.Zoom; // not working - sizeMode in stretch doesnt work either it just repeats the image.


            logo = Image.FromFile(@"H:\Unit 16 OOP Jhora\kiosk project\MiasSandwichShop\Images\Logo\miasShopLogo.png");
            logoPicBoxImage.BackgroundImage = logo;
        }

        private void clcToShopBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void helpBTN_Click(object sender, EventArgs e)
        {
            // creates a message box displaying information.
            string help = $"\nAfter you choose your items you can go to the final cart at the top Left to check out!";
            string by = "Created by Henrikas Varanauskas";
            string custom = $"To Create a custom sandwich head to the Cart Page.";

            string messageBreak = $"\n<----------------------------------->\n";
            MessageBox.Show($"{by}{messageBreak}Mia's Sandwich Shop app that sells sandwiches,\nto purchase something click to shop where you\nwill have a selection of items to choose from.{help}{messageBreak}{custom}");
        }
    }
}
