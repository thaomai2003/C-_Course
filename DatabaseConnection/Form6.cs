using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=THAOMAI\\SQLEXPRESS;Initial Catalog=STUDENT_MANAGEMENT;Integrated Security=True;TrustServerCertificate=True";
        private SqlDataAdapter adapter;
        private DataSet ds;
        private int position = -1;

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM Student", connectionString);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "Student");
                dtgStudent.DataSource = ds.Tables["Student"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentID.Text) || string.IsNullOrEmpty(txtStudentName.Text) || string.IsNullOrEmpty(txtClassID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            DataRow row = ds.Tables["Student"].NewRow();
            row["StudentID"] = txtStudentID.Text; 
            row["Name"] = txtStudentName.Text;
            row["ClassID"] = txtClassID.Text;

            ds.Tables["Student"].Rows.Add(row);
            try
            {
                adapter.Update(ds, "Student");
                MessageBox.Show("Thêm mới thành công!");
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm mới thất bại: " + ex.Message);
            }
        }

        private void dtgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1)
            {
                MessageBox.Show("Không có hàng nào được chọn");
                return;
            }

            DataRow row = ds.Tables["Student"].Rows[position];
            txtStudentID.Text = row["StudentID"].ToString(); 
            txtStudentName.Text = row["Name"].ToString();
            txtClassID.Text = row["ClassID"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("Không có hàng nào được chọn");
                return;
            }

            DataRow row = ds.Tables["Student"].Rows[position];
            row.BeginEdit();
            row["StudentID"] = txtStudentID.Text; 
            row["Name"] = txtStudentName.Text;
            row["ClassID"] = txtClassID.Text;
            row.EndEdit();

            try
            {
                adapter.Update(ds, "Student");
                MessageBox.Show("Cập nhật thành công!");
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (position == -1)
            {
                MessageBox.Show("Không có hàng nào được chọn");
                return;
            }

            DataRow row = ds.Tables["Student"].Rows[position];
            row.Delete();

            try
            {
                adapter.Update(ds, "Student");
                MessageBox.Show("Xóa thành công!");
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message);
            }
        }
    }
}
