using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantBill
{
    public partial class Form1 : Form
    {

        private double[] beveragePrices = { 1.95, 1.50, 1.25, 2.95, 2.50, 1.50 };
        private double[] appetizerPrices = { 5.95, 6.95, 8.95, 8.95, 10.95, 12.95, 6.95 };
        private double[] mainCoursePrices = { 13.95, 13.95, 11.95, 19.95, 20.95, 18.95, 13.95, 14.95 };
        private double[] dessertPrices = { 5.95, 3.95, 5.95, 4.95, 5.95 };
        private double subtotal = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadMenuItems()
        {
            Beverage.Items.AddRange(new string[] { "Soda", "Tea", "Coffee", "Mineral Water", "Juice", "Milk" });
            Appetizer.Items.AddRange(new string[] { "Buffalo Wings", "Buffalo Fingers", "Potato Skins", "Nachos", "Mushroom Caps", "Shrimp Cocktail", "Chips and Salsa" });
            MainCourse.Items.AddRange(new string[] { "Chicken Alfredo", "Chicken Picatta", "Turkey Club", "Lobster Pie", "Prime Rib", "Shrimp Scampi", "Turkey Dinner", "Stuffed Chicken" });
            Dessert.Items.AddRange(new string[] { "Apple Pie", "Sundae", "Carrot Cake", "Mud Pie", "Apple Crisp" });
        
        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Beverage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Beverage.SelectedIndex != -1)
                subtotal += beveragePrices[Beverage.SelectedIndex];
            UpdateTotals();
        }

        private void Appetizer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Appetizer.SelectedIndex != -1)
                subtotal += appetizerPrices[Appetizer.SelectedIndex];
            UpdateTotals();
        }

        private void MainCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainCourse.SelectedIndex != -1)
                subtotal += mainCoursePrices[MainCourse.SelectedIndex];
            UpdateTotals();
        }

        private void Dessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Dessert.SelectedIndex != -1)
                subtotal += dessertPrices[Dessert.SelectedIndex];
            UpdateTotals();
        }
        private void UpdateTotals()
        {
            double tax = subtotal * 0.16; 
            double total = subtotal + tax;

            SubTotal.Text = $"Subtotal: ${subtotal:F2}";
            Tax.Text = $"Tax: ${tax:F2}";
            Total.Text = $"Total: ${total:F2}";
        }

        private void ClearBill_Click(object sender, EventArgs e)
        {
            subtotal = 0.0;

            SubTotal.Text = "Subtotal: $0.00";
            Tax.Text = "Tax: $0.00";
            Total.Text = "Total: $0.00";

            Beverage.SelectedIndex = -1;
            Appetizer.SelectedIndex = -1;
            MainCourse.SelectedIndex = -1;
            Dessert.SelectedIndex = -1;

            TableNumber.Clear();
            WaiterName.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
