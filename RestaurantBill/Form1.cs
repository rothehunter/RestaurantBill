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
        public struct Orders
        {
            public string item;
            public double price;
        }

        const double TAX = 0.09; //6% TVA
        Orders order = new Orders();
        static double subTotal;
        static double totalTaxes;
        static double total;
        string finalBill = "FINAl BILL: \n";

        public Form1()
        {
            InitializeComponent();
        }

        private void getValues(string custOrder)
        {
            order.item = custOrder.Split('$')[0];
            order.price = Convert.ToDouble(custOrder.Split('$')[1]);
            //listBox1.Items.Add("Price: " + order.price);
            finalBill += "Ordered Item: " + order.item + "\nPrice: " + order.price.ToString("C2") + "\n";
            updateBill();
        }

        private void updateBill()
        {
            subTotal += order.price;
            total += order.price + (order.price * TAX);
            totalTaxes += order.price * TAX;

            listBox1.Items.Clear();
            listBox1.Items.AddRange(finalBill.Split('\n'));
            listBox1.Items.Add("Subtotal: " + subTotal.ToString("C2"));
            listBox1.Items.Add("Tax: " + totalTaxes.ToString("C2"));
            listBox1.Items.Add("Total: " + total.ToString("C2"));
        }

        private void dropdownSelection(object sender, EventArgs e)
        {
            if (sender == cmbDrinks)
                getValues(cmbDrinks.SelectedItem.ToString());
            else if (sender == cmbMeals)
                getValues(cmbMeals.SelectedItem.ToString());
            else if (sender == cmbAppetizers)
                getValues(cmbAppetizers.SelectedItem.ToString());
            else
                getValues(cmbDesserts.SelectedItem.ToString());
            //test
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            subTotal = 0;     
            totalTaxes = 0;
            total = 0;
            finalBill = "FINAl BILL: \n";
            listBox1.Items.Clear();
            cmbDesserts.Text = "Desserts";
            cmbAppetizers.Text = "Appetizers";
            cmbDrinks.Text = "Beverages";
            cmbMeals.Text = "Main Meals";
        }
    }
}
