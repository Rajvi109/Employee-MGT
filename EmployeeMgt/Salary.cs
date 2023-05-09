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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\mca sem1\c#\employeemgt\EmployeeMgt\MyemployeeDb.mdf';Integrated Security=True");

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fetchempdata()
        {
            if (EmpId.Text == " ")
            {
                MessageBox.Show("Enter Employee Id");
            }
            else
            {
                Con.Open();
                string query = "select * from EmployeeTbl where Empid='" + EmpId.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    // EmpId.Text = dr["Empid"].ToString();
                    EmpName.Text = dr["Empname"].ToString();
                    EmpPos.Text = dr["EmpPos"].ToString();
                    // Worked.Text = dr["Emppos"].ToString();




                }
                Con.Close();
            }
        }


        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void fatchdata_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }
        int Dailybase,total;

        private void Print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("===== Salary Document =====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(190));
            e.Graphics.DrawString("Employee Id : " + EmpId.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Name : " + EmpName.Text , new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Employee Position : " + EmpPos.Text , new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Days Of Worked : " + Worked.Text , new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 220));
            e.Graphics.DrawString("Daily Pays : " + Dailybase, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 260));
            e.Graphics.DrawString("Total Amount : " + total, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 300));

            e.Graphics.DrawString("===== Employee Soft =====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(190, 360));
        }

        private void SalarySlip_TextChanged(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            if (EmpPos.Text == "")
            {
                MessageBox.Show("Select an Employee");

            }
            else if (Worked.Text == "" || Convert.ToInt32(Worked.Text) > 28)
            {
                MessageBox.Show("Enter a valid Number of Days");
            }
            else
            {
                if (EmpPos.Text == "Manager")
                {
                    Dailybase = 1200;
                }
                else if (EmpPos.Text == "Seniour Developer")
                {
                    Dailybase = 1000;
                }
                else if (EmpPos.Text == "Juniour Developer")
                {
                    Dailybase = 950;
                }
                else
                {
                    Dailybase = 850;
                }
                total = Dailybase * Convert.ToInt32(Worked.Text);
                SalarySlip.Text ="Employee ID : "+ EmpId.Text + "\n" + "Employee Name : "+EmpName.Text + "\n" + "Employee Position : "+EmpPos.Text + "\n" + "Worked Days : "+Worked.Text + "\n" +"Daily Salary Rs. : "+ Dailybase + "\n"+"Total Amount Rs. : " + total;
            }
        }
    }
}
