using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information
{
    public partial class Form1 : Form
    {
        List<string> userNames = new List<string>();
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<string> contactNumbers = new List<string>();
        List<string> emails = new List<string>();
        List<string> accountNumbers = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

            string userName = userNameTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string contactNumber = contactNumberTextBox.Text;
            string email = emailTextBox.Text;
            string accountNumber = accountNumberTextBox.Text;

            userNames.Add(userName);
            firstNames.Add(firstName);
            lastNames.Add(lastName);
            contactNumbers.Add(contactNumber);
            emails.Add(email);
            accountNumbers.Add(accountNumber);

            displayRichTextBox.Text = Display();

        }

        private string Display()
        {
            string message = "";
            message= "SL\t\t" + "User Name\t" + "First Name\t" + "Last Name\t" + "Contact Number\t" +
                     "Email\t" + "AccountNumber";
            int index = 0;

            foreach (string userName in userNames)
            {
                message = message +"\n"+ (index + 1)+"\t\t"+userName+"\t"+firstNames[index]+"\t"+lastNames[index]+"\t"+
                          contactNumbers[index]+"\t"+emails[index]+"\t"+accountNumbers[index]+"\n";
                index++;
            }

            return message;


        }

 
    }
}
