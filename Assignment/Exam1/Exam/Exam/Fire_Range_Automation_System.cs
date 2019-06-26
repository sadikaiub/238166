using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> soldierNumbers = new List<string>();
        List<string> soldierNames = new List<string>();
        List<int> target1Scores = new List<int>();
        List<int> target2Scores = new List<int>();
        List<int> target3Scores = new List<int>();
        List<int> target4Scores = new List<int>();
        List<double> avgScores = new List<double>();
        List<double> totalScores = new List<double>();


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string soldierNumber;
                string soldierName = soldierNameTextBox.Text;
                double target1Score = Convert.ToDouble(target1ScoreTextBox.Text);
                double target2Score = Convert.ToDouble(target2ScoreTextBox.Text);
                double target3Score = Convert.ToDouble(target3ScoreTextBox.Text);
                double target4Score = Convert.ToDouble(target4ScoreTextBox.Text);

                double[] array = { target1Score, target2Score, target3Score, target4Score };
                double TotalValue = array.Sum();

                if (!string.IsNullOrEmpty(soldireNumberTextBox.Text))
                {
                    soldierNumber = soldireNumberTextBox.Text;

                    bool isTrue = false;
                    isTrue = IsExist(soldierNumber);

                    if (isTrue)
                    {
                        soldierMessage.Text=("Solder Number" +" "+ soldierNumber +" "+ "already exist!");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Field can not be empty!");
                    return;
                }


                soldierNumbers.Add(soldierNumber);
                soldierNames.Add(soldierName);
                totalScores.Add(TotalValue);
                avgScores.Add(TotalValue / 4);

                MessageBox.Show("Sucessfully Saved!");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            soldireNumberTextBox.Clear();
            soldierNameTextBox.Clear();
            target1ScoreTextBox.Clear();
            target2ScoreTextBox.Clear();
            target3ScoreTextBox.Clear();
            target4ScoreTextBox.Clear();



        }

        private string Display()
        {
            string message = "";
            message = "SL\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";
            int index = 0;

            foreach (string soldierNumber in soldierNumbers)
            {
                message = message + (index + 1) + "\t" + soldierNumber + "\t" + soldierNames[index] + "\t" + avgScores[index] +"\t"+totalScores[index]+ "\n";
                index++;
            }

            return message;


        }

        private bool IsExist(string soldierNumber)
        {

            foreach (string userCheck in soldierNumbers)
            {
                if (soldierNumber.Equals(userCheck))
                {
                    return true;
                }
            }
            return false;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            displayRichTextBox.Text = Display();
           
        }



        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (soldierNoRadioButton.Checked)
            {

                string message = "";
                message = "SL\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";
                int index = 0;

                for (index = 0; soldierNumbers.Count > index; index++)
                {
                    if (soldierNumbers[index] == searchTextBox.Text)
                    {
                        displayRichTextBox.Text = message + (index + 1) + "\t" + soldierNumbers[index] + "\t" + soldierNames[index] + "\t" + avgScores[index] + "\t" + totalScores[index] + "\n";
                    }
                    
                }
                

            }

            else if (SoldieNameRadioButton.Checked)
            {

                string message = "";
                message = "SL\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";
                int index = 0;

                for (index = 0; soldierNames.Count > index; index++)
                {
                    if (soldierNames[index] == searchTextBox.Text)
                    {
                        displayRichTextBox.Text = message + (index + 1) + "\t" + soldierNumbers[index] + "\t" + soldierNames[index] + "\t" + avgScores[index] + "\t" + totalScores[index] + "\n";
                    }
                   
                }
            }
        }

        private void soldireNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
