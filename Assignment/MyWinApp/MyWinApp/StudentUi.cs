using MyWinApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class StudentUi : Form
    {
        private string connectionString;
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;
        private Student student;
        
       
       

        public StudentUi()
        {
            InitializeComponent();
            connectionString = @"Server=DESKTOP-PHFRTLE\SQLEXPRESS; Database=Student_DB; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            student = new Student();
         
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            student.Name = nameTextBox.Text;
            student.RollNo = rollNoTextBox.Text;
            student.Address = addressTextBox.Text;
            student.Age = Convert.ToInt32(ageTextBox.Text);
            student.DistrictID = Convert.ToInt32(districtComboBox.SelectedValue);

            
            Insert(student);
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            LoadDistrict();

        }
        private void LoadDistrict()
        {
            
            sqlConnection.Open();
            commandString = @"select * from Districts";
            sqlCommand = new SqlCommand(commandString,sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                districtComboBox.DataSource = dataTable;
            }
            sqlConnection.Close();
        }

        private void Insert(Student student)
        {
            sqlConnection.Open();
            commandString = @"INSERT INTO Students (RollNo, Name, Age,Address, DistrictId) VALUES ( '" + student.RollNo + "','" + student.Name + "','"+student.Age+"','"+student.Address+"','"+student.DistrictID+ "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            int isExecuted = 0;

            isExecuted = sqlCommand.ExecuteNonQuery();

            if (isExecuted > 0)
            {
                MessageBox.Show("Saved Successfuly!");
            }
            else
            {
                MessageBox.Show("Save Failed!");
            }
            sqlConnection.Close();
        }

        private void Show(Student student)
        {
            sqlConnection.Open();
            commandString = @"select s.ID, RollNo,s.Name,Age, Address, d.Name As District FROM Students As s left join Districts As d ON d.ID=s.DistrictID";
            sqlCommand = new SqlCommand(commandString, sqlConnection);

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);

                displayDataGridView.DataSource = dataTable;
            }

            sqlConnection.Close();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

            Show(student);
        }

    }
}
