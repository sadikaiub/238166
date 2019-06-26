using Exam2.BLL;
using Exam2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class Save : Form
    {

        MobileManager _mobileManager = new MobileManager();
        private Mobile mobile;

        public Save()
        {
            InitializeComponent();
            mobile = new Mobile();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            try
            {
                mobile.ModelName = modelNameTextBox.Text;
                mobile.Imei = imeiTextBox.Text;
                mobile.Price = Convert.ToInt32( priceTextBox.Text);
                if (imeiTextBox.Text.Length <= 15)
                {
                    MessageBox.Show("IMEI must be exact 15 Character !");
                    return;
                }
                int isExecuted;
                isExecuted = _mobileManager.Insert(mobile);

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved!!");
                }
                else
                {
                    MessageBox.Show("Not saved!!");
                }
            }

            catch (Exception exception)
            {
                MessageBox.Show("Exception!");
            }
           // _mobileManager.Insert(mobile);


        }
    }
}
