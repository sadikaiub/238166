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
        public CoffeShop()
        {
            InitializeComponent();
        }

        private int i = 0;
        private const int size = 10;

        string[]customerName=new string[size];
        string[]contactNumber=new string[size];
        string[]address=new string[size];
        string[]order=new string[size];
        int[]quantity=new int[size];
        int[] total = new int[size];

        private int unit_Price_Black_Coffe = 120;
        private int unit_Price_cold_Coffe = 100;
        private int unit_Price_hot_Coffe = 90;
        private int unit_Price_regular_Coffe = 80;


        


        private void button1_Click(object sender, EventArgs e)
        {
            customerName[i] = Convert.ToString(customerNameTextBox.Text);
            contactNumber[i] = Convert.ToString(contactNoTextBox.Text);
            address[i] = Convert.ToString(addressTextBox.Text);
            order[i] = Convert.ToString(orderComboBox.Text);
            quantity[i] = Convert.ToInt32(quantityTextBox.Text);

            string message = "";

            
           
                if (order[i] == "Black Coffe")
                {
                    total[i] = quantity[i] * unit_Price_Black_Coffe;

                }
                else if (order[i] == "Cold Coffe")
                {
                total[i] = quantity[i] * unit_Price_cold_Coffe;

                }
                
                else if (order[i] == "Hot Coffe")
                {
                    total[i] = quantity[i] * unit_Price_hot_Coffe;

                }

                else if (order[i] == "Regular Coffe")
                {
                total[i] = quantity[i] * unit_Price_regular_Coffe;

            }

                i++;
                for (int i = 0; i < customerName.Length; i++)
                {
                    message = message+ "\n\n" +
                              "\t\tCutomer Information" +
                              "\n" + "\n\n" +
                              "Customer Name:  " +
                              customerName[i] + "\n" + "Contact No:  " + contactNumber[i] +
                              "\n" +
                              "Address:  " +
                              address[i] + "\n\n" +
                              "" +
                              "\t\tPurchase Information" +
                              "\n" +
                              "\n\n" + "Order: " + order[i] + "\nQuantity:  " +
                              quantity[i] + "\nTotal Price:" +total[i] +"\n\n"+
                              "________________________________________________________________________________________" +
                              "___________________" ;
                    richTextBoxDisplay.Text = message;

            }


            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            quantityTextBox.Clear();



        }

    }
}
