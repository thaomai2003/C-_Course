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

namespace DatabaseConnection
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=THAOMAI\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection = null;

        private void btnViewClass_Click(object sender, EventArgs e)
        {
            txtClassID.Text = "";
            txtClassName.Text = "";
            txtYear.Text = "";

            if (connection == null)
                connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * from Class Where ClassID= '{txtEnterClassID.Text}'";
            command.Connection = connection;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                txtClassID.Text = reader.GetString(0);
                txtClassName.Text = reader.GetString(1);
                txtYear.Text = reader.GetInt32(2).ToString();
            }
            connection.Close();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (connection == null)
                connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand($"SELECT * FROM STUDENT WHERE ClassID= '{txtEnterClassID.Text}'", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string studentID = reader["StudentID"].ToString();
                string name = reader["Name"].ToString();
                string classID = reader["ClassID"].ToString();
                ListViewItem item = new ListViewItem(studentID);

                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lsvStudents.Items.Add(item);
            }
            connection.Close ();
        }
    }
}
