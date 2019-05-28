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
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            string message = "";
            int index = 0;
            foreach (int number in numbers)
            {
                message = message + "Value at index "+ index+" :"+ number +"\n";
                index++;
            }
            showRichTextBox.Text ="Foreach\n"+ message;
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
           
        }
    }
}
