using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=THAOMAI\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection = null;

        private void Form5_Load(object sender, EventArgs e)
        {
            ViewListOfStudents();  // Dữ liệu tự động load khi form được mở
        }

        private void ViewListOfStudents()
        {
            lvwStudent.Items.Clear();
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from STUDENT", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string masv = reader["StudentID"].ToString();
                string hoten = reader["Name"].ToString();
                string malop = reader["ClassID"].ToString();
                ListViewItem item = new ListViewItem(masv);
                item.SubItems.Add(hoten);
                item.SubItems.Add(malop);
                lvwStudent.Items.Add(item);
            }
            connection.Close();
        }

        int result = -1;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "insert into STUDENT (StudentID, Name, ClassID) values(@StudentId, @Name, @ClassID)";
            command.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
            command.Parameters.AddWithValue("@Name", txtName.Text);
            command.Parameters.AddWithValue("@ClassID", txtClassID.Text);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Insert record failed");
            }

            if (result > 0)
            {
                ViewListOfStudents();  
            }
        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwStudent.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lvwStudent.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lvwStudent.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lvwStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand($"update STUDENT set Name='{txtName.Text}', ClassID='{txtClassID.Text}' where StudentID= '{txtStudentID.Text}'", connection);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Update failed!!!!");
            }

            if (result > 0)
            {
                ViewListOfStudents();  
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand($"delete from STUDENT where StudentID= '{txtStudentID.Text}'", connection);

            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Delete failed!!!!");
            }

            if (result > 0)
            {
                ViewListOfStudents();  
                txtStudentID.Text = "";
                txtName.Text = "";
                txtClassID.Text = "";
            }
        }
    }
}
