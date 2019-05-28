using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class FeaturesForm : Form
    {
        List<string> users = new List<string>();
        List<string> names = new List<string>();
        List<int> ages = new List<int>();
        public FeaturesForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string user;
                string name;
                int age;


                if (!string.IsNullOrEmpty(userTextBox.Text))
                {
                    user = userTextBox.Text;

                    bool isTrue = false;
                    isTrue = IsExist(user);

                    if (isTrue)
                    {
                        MessageBox.Show("User" + user + " already exist!");
                        return;
                    }
                   
                }
                else
                {
                    MessageBox.Show("Field can not be empty!");
                    return;
                }

                
                if (!string.IsNullOrEmpty(nameTextBox.Text))
                {
                    name =nameTextBox.Text;
                    
                }
                else
                {
                    MessageBox.Show("Field can not be empty!");
                    return;

                }
               
                if (!string.IsNullOrEmpty(ageTextBox.Text))
                {
                     age = Convert.ToInt32(ageTextBox.Text);
                     
                }
                else
                {
                    MessageBox.Show("Field can not be empty!");
                    return;
                }

                users.Add(user);
                names.Add(name);
                ages.Add(age);


                richTextBox.Text = Display();
                userTextBox.Clear();
                nameTextBox.Clear();
                ageTextBox.Clear();


                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            
           
        }

        private string Display()
        {
            string message= "";
            message = "SL\tUser\tName\tAge\n";
            int index = 0;

            foreach (string user in users)
            {
                message = message + (index+1)+"\t"+user+"\t"+ names[index] + "\t" + ages[index] + "\n";
                index++;
            }

            return message;
            
        }

        private bool IsExist(string user)
        {
            
            foreach (string userCheck in users)
            {
                if (user.Equals( userCheck))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
