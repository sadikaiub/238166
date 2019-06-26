using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInformationKeeper
{
    public partial class BookInformationKeeperUI : Form
    {
        Dictionary<string, string> bookList  = new Dictionary<string, string>();
        public BookInformationKeeperUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string isbn = isbnTextBox.Text;
            string name = nameTextBox.Text;
            string message = "";

            //clearing the text boxes
            isbnTextBox.Clear();
            nameTextBox.Clear();

            //checking for the errors
            if (!bookList.ContainsKey(isbn) && name != "" && isbn.Length == 13)
            {
                bookList.Add(isbn, name);
                RefreshBookListBox();
            }
            else if (isbn.Length != 13)
            {
                message = "ISBN must be 13 charachter long!";
            }
            else if (bookList.ContainsKey(isbn))
            {
                message = "The ISBN alredy in the record!";
            }
            else if (name != null)
            {
                message = "Book Name cannot be empty!";
            }
            else
            {
                message = "The ISBN already exist in the list!";
            }
            // if there is any error
            if (message != "")
            {
                MessageBox.Show(message, "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }

        // Refresh the bookListBox
        private void RefreshBookListBox()
        {
            bookListBox.Items.Clear();
            foreach (KeyValuePair<string, string> keyValuePair in bookList)
            {
                bookListBox.Items.Add(keyValuePair.Key);
                bookListBox.Items.Add(keyValuePair.Value);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string data = searchTextBox.Text;
            searchTextBox.Clear();
            if (isbnRadioButton.Checked)
            {
                resultListBox.Items.Clear();
                string result = GetValueByISBN(data);
                if (result != "")
                {
                    resultListBox.Items.Add(result);
                }
            }
            else if (nameRadioButton.Checked)//if name radio is checked
            {
                resultListBox.Items.Clear();

                List<string> resultList = GetValueByName(data);
                if (resultList.Count > 0)
                {
                    foreach (string result in resultList)
                    {
                        resultListBox.Items.Add(result);
                    }
                }
            }
            else // if none is checked
            {
                MessageBox.Show("Select one radio button");
            }
        }

        private List<string> GetValueByName(string name)
        {
            List<string> resultList = new List<string>();

            foreach (KeyValuePair<string, string> keyValuePair in bookList)
            {
                if (keyValuePair.Value == name)
                {
                    resultList.Add(keyValuePair.Key);
                }

            }
            return resultList;
        }

        private string GetValueByISBN(string isbn)
        {
            if (bookList.ContainsKey(isbn))
            {
                return bookList[isbn];
            }
            else
            {
                return "";
            }
        }

    }
}
