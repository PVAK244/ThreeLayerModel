using System;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Form1 : Form
    {
        StudentBLL stdBLL = new StudentBLL();
        public Form1()
        {
            InitializeComponent();
        }
        
        public void ShowGridView()
        {
            dtgStudent.DataSource = stdBLL.SelectAllStudent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowGridView();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtStudentID.Text, txtFullName.Text, txtClassID.Text);
            if (stdBLL.InsertStudent(st))
                ShowGridView();
            else
                MessageBox.Show("Insert Failed!!!");
        }
        int position = -1;
        private void dtgStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1) return;
            DataGridViewRow row = dtgStudent.Rows[position];
            txtStudentID.Text = row.Cells[0].Value.ToString();
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtClassID.Text = row.Cells[2].Value.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student st = new Student(txtStudentID.Text, txtFullName.Text, txtClassID.Text);
            if (stdBLL.UpdateStudent(st))
                ShowGridView();
            else
                MessageBox.Show("Update failed!!!");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            if (stdBLL.DeleteStudent(studentID))
            {
                ShowGridView();
                txtStudentID.Text = "";
                txtFullName.Text = "";
                txtClassID.Text = "";
            }
            else
            {
                MessageBox.Show("Delete failed!!!");
            }
        }
    }
}
