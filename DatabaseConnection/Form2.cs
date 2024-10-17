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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string connectionString = "Data Source=THAOMAI\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection connection = null;

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            if (connection == null)
                connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed) 
                connection.Open();

            SqlCommand command = new SqlCommand($"SELECT count(*) from STUDENT Where ClassID= '{txtClassID.Text}'", connection);

            int result = (int)command.ExecuteScalar();
            txtNumber.Text = result.ToString();
            connection.Close();
            
        }
    }
}
