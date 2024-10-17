using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=THAOMAI\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection = null;

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                if (connection == null)
                    connection = new SqlConnection(connectionString);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                MessageBox.Show("Connected to database successfully!");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection == null)
                    connection = new SqlConnection(connectionString);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM CLASS", connection);

                lsbClass.Items.Clear();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string classID = reader.GetString(0);
                    string name = reader.GetString(1);
                    int year = reader.GetInt32(2);

                    string line = $"{classID} - {name} - {year}";
                    lsbClass.Items.Add(line); 
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbClass.SelectedIndex == -1) return;

            string selectedClass = lsbClass.SelectedItem.ToString();
            string[] classInfo = selectedClass.Split('-');
            string classID = classInfo[0].Trim();

            lsvStudents.Items.Clear();

            try
            {
                if (connection == null)
                    connection = new SqlConnection(connectionString);

                if (connection.State == ConnectionState.Closed)
                    connection.Open();

                SqlCommand command = new SqlCommand($"SELECT * FROM STUDENT WHERE ClassID = '{classID}'", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string studentID = reader.GetString(0);
                    string name = reader.GetString(1);
                    string classIDFromDB = reader.GetString(2);

                    ListViewItem item = new ListViewItem(studentID);
                    item.SubItems.Add(name);
                    item.SubItems.Add(classIDFromDB);
                    lsvStudents.Items.Add(item); 
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
