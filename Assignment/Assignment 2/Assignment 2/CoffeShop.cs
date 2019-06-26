using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class CoffeShop : Form
    {
        private int unit_Price_Black_Coffe = 120;
        private int unit_Price_cold_Coffe = 100;
        private int unit_Price_hot_Coffe = 90;
        private int unit_Price_regular_Coffe = 80;
        public CoffeShop()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (orderComboBox.Text == "Black Coffe")
            {
                richTextBoxDisplay.Text = "\n_________________________________________________________" +
                                          "\t\tCutomer Information" +
                                          "\n_________________________________________________________" + "\n\n" +
                                          "Customer Name:  " +
                                          customerNameTextBox.Text + "\n" + "Contact No:  " + contactNoTextBox.Text +
                                          "\n" +
                                          "Address:  " +
                                          addressTextBox.Text + "\n\n" +
                                          "________________________________________________________" +
                                          "\t\tPurchase Information" +
                                          "\n_________________________________________________________" +
                                          "\n\n" + "Order: " + orderComboBox.SelectedItem + "\nQuantity:  " +
                                          quantityTextBox.Text + "\nTotal Price:"+Convert.ToInt32(quantityTextBox.Text)*unit_Price_Black_Coffe;

            }
            else if (orderComboBox.Text == "Cold Coffe")
            {
                richTextBoxDisplay.Text = "\n_________________________________________________________" +
                                          "\t\tCutomer Information" +
                                          "\n_________________________________________________________" + "\n\n" +
                                          "Customer Name:  " +
                                          customerNameTextBox.Text + "\n" + "Contact No:  " + contactNoTextBox.Text +
                                          "\n" +
                                          "Address:  " +
                                          addressTextBox.Text + "\n\n" +
                                          "________________________________________________________" +
                                          "\t\tPurchase Information" +
                                          "\n_________________________________________________________" +
                                          "\n\n" + "Order: " + orderComboBox.SelectedItem + "\nQuantity:  " +
                                          quantityTextBox.Text + "\nTotal Price:" + Convert.ToInt32(quantityTextBox.Text) * unit_Price_cold_Coffe;

            }
            else if (orderComboBox.Text == "Cold Coffe")
            {
                richTextBoxDisplay.Text = "\n_________________________________________________________" +
                                          "\t\tCutomer Information" +
                                          "\n_________________________________________________________" + "\n\n" +
                                          "Customer Name:  " +
                                          customerNameTextBox.Text + "\n" + "Contact No:  " + contactNoTextBox.Text +
                                          "\n" +
                                          "Address:  " +
                                          addressTextBox.Text + "\n\n" +
                                          "________________________________________________________" +
                                          "\t\tPurchase Information" +
                                          "\n_________________________________________________________" +
                                          "\n\n" + "Order: " + orderComboBox.SelectedItem + "\nQuantity:  " +
                                          quantityTextBox.Text + "\nTotal Price:" + Convert.ToInt32(quantityTextBox.Text) * unit_Price_cold_Coffe;

            }
            else if (orderComboBox.Text == "Hot Coffe")
            {
                richTextBoxDisplay.Text = "\n_________________________________________________________" +
                                          "\t\tCutomer Information" +
                                          "\n_________________________________________________________" + "\n\n" +
                                          "Customer Name:  " +
                                          customerNameTextBox.Text + "\n" + "Contact No:  " + contactNoTextBox.Text +
                                          "\n" +
                                          "Address:  " +
                                          addressTextBox.Text + "\n\n" +
                                          "________________________________________________________" +
                                          "\t\tPurchase Information" +
                                          "\n_________________________________________________________" +
                                          "\n\n" + "Order: " + orderComboBox.SelectedItem + "\nQuantity:  " +
                                          quantityTextBox.Text + "\nTotal Price:" + Convert.ToInt32(quantityTextBox.Text) * unit_Price_hot_Coffe;

            }

            else if (orderComboBox.Text == "Regular Coffe")
            {
                richTextBoxDisplay.Text = "\n_________________________________________________________" +
                                          "\t\tCutomer Information" +
                                          "\n_________________________________________________________" + "\n\n" +
                                          "Customer Name:  " +
                                          customerNameTextBox.Text + "\n" + "Contact No:  " + contactNoTextBox.Text +
                                          "\n" +
                                          "Address:  " +
                                          addressTextBox.Text + "\n\n" +
                                          "________________________________________________________" +
                                          "\t\tPurchase Information" +
                                          "\n_________________________________________________________" +
                                          "\n\n" + "Order: " + orderComboBox.SelectedItem + "\nQuantity:  " +
                                          quantityTextBox.Text + "\nTotal Price:" + Convert.ToInt32(quantityTextBox.Text) * unit_Price_regular_Coffe;

            }


        }

    }
}
