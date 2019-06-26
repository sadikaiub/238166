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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Home form1 = this;
            Save form2 = new Save();
            form2.Show();
            form1.Hide();


        }

        private void PriceButton_Click(object sender, EventArgs e)
        {
            Home form1 = this;
            SearchPrice form3 = new SearchPrice();
            form3.Show();
            form1.Hide();

        }
    }
}
