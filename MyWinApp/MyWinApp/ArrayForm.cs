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
    public partial class ArrayForm : Form
    {
        public ArrayForm()
        {
            InitializeComponent();
            
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] firstNumber = new int[size];

            firstNumber[0] = 5;
            firstNumber[5] = 8;
            firstNumber[8] = 9;
            string message = "";

           
            for (int index = 0; index < firstNumber.Length; index++)
            {
                if (firstNumber[index]!=0)
                message = message +"Value at index: "+ index + " is:"+firstNumber[index]+"\n";
                richTextBox.Text = message;
            }
        }
    }
}
