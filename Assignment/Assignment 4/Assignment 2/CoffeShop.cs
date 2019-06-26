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

        List<string>customerList=new List<string>();
        List<string> contactList = new List<string>();
        List<string> addressList = new List<string>();
        List<string> orderList = new List<string>();
        List<int> quantityList=new List<int>();
        List<int> totaList=new List<int>();

        private int unit_Price_Black_Coffe = 120;
        private int unit_Price_cold_Coffe = 100;
        private int unit_Price_hot_Coffe = 90;
        private int unit_Price_regular_Coffe = 80;


        private void button1_Click(object sender, EventArgs e)
        {
            customerList.Add(customerNameTextBox.Text);
            contactList.Add(contactNoTextBox.Text);
            addressList.Add(addressTextBox.Text);
            orderList.Add(orderComboBox.Text);
            quantityList.Add(Convert.ToInt32(quantityTextBox.Text));
            totaList.Add(i);

            string message = "";

            
           
                if (orderComboBox.Text == "Black Coffe")
                {
                    totaList[i] = Convert.ToInt32(quantityTextBox.Text) * unit_Price_Black_Coffe;

                }
                else if (orderComboBox.Text == "Cold Coffe")
                {
                    totaList[i] = Convert.ToInt32(quantityTextBox.Text) * unit_Price_cold_Coffe;

                }
                else if (orderComboBox.Text == "Hot Coffe")
                {
                    totaList[i] = Convert.ToInt32(quantityTextBox.Text) * unit_Price_hot_Coffe;

                }
                else if (orderComboBox.Text == "Regular Coffe")
                {
                    totaList[i] = Convert.ToInt32(quantityTextBox.Text) * unit_Price_regular_Coffe;

                }

                i++;
                for (int i = 0; i < customerList.Count; i++)
                {
                    message = message+ "\n\n" +
                              "\t\tCutomer Information" +
                              "\n" + "\n\n" +
                              "Customer Name:  " +
                              customerList[i] + "\n" + "Contact No:  " + contactList[i] +
                              "\n" +
                              "Address:  " +
                              addressList[i] + "\n\n" +
                              "" +
                              "\t\tPurchase Information" +
                              "\n" +
                              "\n\n" + "Order: " + orderList[i] + "\nQuantity:  " +
                              quantityList[i] + "\nTotal Price:" +totaList[i] +"\n\n"+
                              "________________________________________________________________________________________" +
                              "___________________" ;
                    richTextBoxDisplay.Text = message;

            }


            //customerNameTextBox.Clear();
            //contactNoTextBox.Clear();
            //addressTextBox.Clear();
            //quantityTextBox.Clear();



        }

    }
}
