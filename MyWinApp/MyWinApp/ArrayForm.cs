﻿using System;
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

        int index = 0;
        const int size = 10;
        int[] firstNumber = new int[size];


        private void ShowButton_Click(object sender, EventArgs e)
        {


            firstNumber[0] = 5;
            firstNumber[5] = 8;
            firstNumber[8] = 9;        

           string message =  Show();
           richTextBox.AppendText( message);
           
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            firstNumber[index] = Convert.ToInt32(numberTextBox.Text);
            index++;
            string messege= Show();
            richTextBox.Text=messege;



        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            //firstNumber[index] = Convert.ToInt32(numberTextBox.Text);
            //index--;
            string message = "";


            for (int index =(firstNumber.Length-1);index>=0 ; index--)
            {
                if (firstNumber[index] != 0)
                    message = message + "Value at index: " + index + " is:" + firstNumber[index] + "\n";
                
            }
            richTextBox.AppendText(message);

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (index = 0; index<size; index++)
            {
                sum = sum + firstNumber[index];
            }
            richTextBox.Text = "Sum:" + sum;
        }

        private string Show()
        {
            string message = "";


            for (int index = 0; index < firstNumber.Length; index++)
            {
                if (firstNumber[index] != 0)
                    message = message + "Value at index: " + index + " is:" + firstNumber[index] + "\n";
                
            }
            return message;
        }

    }
}
