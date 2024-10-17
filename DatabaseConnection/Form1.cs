using System.Data;
using System.Data.SqlClient;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=THAOMAI\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection = null;

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Ket noi thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai: " + ex.Message);

            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Ngat ket noi thanh cong");
            }
            }
        }
    }

