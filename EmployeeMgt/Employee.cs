using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace EmployeeMgt
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\mca sem1\c#\employeemgt\EmployeeMgt\MyemployeeDb.mdf';Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void add_Click(object sender, EventArgs e)
        {
            if (EmpId.Text == "" || EmpName.Text == "" || EmpPho.Text == "" || EmpAdd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
                try
                {
                    Con.Open();
                    string query = "insert into EmployeeTbl values('"+EmpId.Text+"','"+EmpName.Text+"','"+EmpAdd.Text+"','"+EmpPos.SelectedItem.ToString()+"','" + EmpDob.Value.Date+"','"+ EmpPho.Text+"','"+EmpEdu.SelectedItem.ToString()+"','"+EmpGen.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query ,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Added");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query , Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(EmpId.Text=="")
            {
                MessageBox.Show("Enter the Employee ID");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from EmployeeTbl where Empid='" + EmpId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpId.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpName.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAdd.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpGen.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
            EmpPos.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpPho.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpEdu.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (EmpId.Text == "" || EmpName.Text == "" || EmpPho.Text == "" || EmpAdd.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Employeetbl set Empname='" + EmpName.Text + "',Empadd='" + EmpAdd.Text + "',Emppos='"+EmpPos.SelectedItem.ToString()+ "',empdob='"+EmpDob.Value.Date+ "',empphone='"+EmpPho.Text+ "',empedu='"+EmpEdu.SelectedItem.ToString()+ "',empgen='"+EmpGen.SelectedItem.ToString()+ "' where Empid='"+EmpId.Text+"';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Succrssfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }

        
    }
}
