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
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }
        List<string> userNames=new List<string>();
        List<string> firstNames = new List<string>();
        List<string> lastNames=new List<string>();
        List<string> contactNumbers = new List<string>();
        List<string> emails=new List<string>();
        List<string> addressList=new List<string>();
        List<int> accountNumbers=new List<int>();

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userName;
                string firstName;
                string lastName = lastNameTextBox.Text;
                string contactNumber;
                string email = emailTextBox.Text;
                string address = addressTextBox.Text;
                int accountNumber = Convert.ToInt32(accountNumberTextBox.Text);

                userNameMessage.Text = "";
                contactNumberMessage.Text = "";
                firstNameMessage.Text = "";

                if (!string.IsNullOrEmpty(userNameTextBox.Text))
                {
                    userName = userNameTextBox.Text;
                    bool isTrue = false;
                    isTrue = IsExist(userName);
                    if (isTrue)
                    {
                        userNameMessage.Text = "Duplicate User Name found!";
                        return;
                    }

                }
                else
                {
                    userNameMessage.Text = "User Name Can not be empty!";
                    return;
                }

                if (!string.IsNullOrEmpty(firstNameTextBox.Text))
                {
                    firstName = firstNameTextBox.Text;
                }
                else
                {
                    firstNameMessage.Text = "First Name Can not be empty!";
                    return;
                }

                if (!string.IsNullOrEmpty(contactNumberTextBox.Text))
                {
                    contactNumber = contactNumberTextBox.Text;
                    bool isTrue = false;
                    isTrue = ContactIsExist(contactNumber);
                    if (isTrue)
                    {
                        contactNumberMessage.Text = "Duplicate Contact Number found!";
                        return;
                    }

                }
                else
                {
                    contactNumberMessage.Text = "Contact Number Can not be empty!";
                    return;
                }




                userNames.Add(userName);
                firstNames.Add(firstName);
                lastNames.Add(lastName);
                contactNumbers.Add(contactNumber);
                emails.Add(email);
                addressList.Add(address);
                accountNumbers.Add(accountNumber);

                displayRichTextBox.Text = Display();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private string Display()
        {
            string message = "";

            message = "SL\t" + "User Name\t" + "First Name\t" + "Last Name\t" + "Contact Number\t" + "Email\t" +
                      "Address\t" + "Account Number\n";
            int index = 0;
            foreach (string userName in userNames)
            {
                message = message + (index + 1) + "\t" + userName + "\t\t" + firstNames[index] + "\t\t" +
                          lastNames[index] +
                          "\t\t" + contactNumbers[index] + "\t" + emails[index] +
                          "\t" + addressList[index] + "\t" + accountNumbers[index] + "\n";
                index++;
            }

            return message;
        }

        private bool IsExist(string userName)
        {
            foreach (string userCheck in userNames)
            {
                if (userName.Equals(userCheck))
                {
                    return true;
                }
            }

            return false;
        }

        private bool ContactIsExist(string contactNumber )
        {
            foreach (string contactCheck in contactNumbers)
            {
                if (contactNumber.Equals(contactCheck))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
