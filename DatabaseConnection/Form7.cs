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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=THAOMAI\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        private SqlDataAdapter adapter;
        private DataSet ds;
        private int position = -1;
    }
}
