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
    public partial class ViewEmployee : Form
    {
        public ViewEmployee()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='E:\mca sem1\c#\employeemgt\EmployeeMgt\MyemployeeDb.mdf';Integrated Security=True");
        private void fetchempdata()
        {
            Con.Open();
            string query = "select * from EmployeeTbl where Empid='"+empidsearch.Text+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                empidlbl.Text = dr["Empid"].ToString();
                empnamelbl.Text = dr["Empname"].ToString();
                empaddlbl.Text = dr["Empadd"].ToString();
                empposlbl.Text = dr["Emppos"].ToString();
                empdoblbl.Text = dr["Empdob"].ToString();
                emppholbl.Text = dr["Empphone"].ToString();
                empedulbl.Text = dr["Empedu"].ToString();
                empgenlbl.Text = dr["Empgen"].ToString();

                empidlbl.Visible = true;
                empnamelbl.Visible = true;
                empaddlbl.Visible = true;
                empposlbl.Visible = true;
                empdoblbl.Visible = true;
                emppholbl.Visible = true;
                empedulbl.Visible = true;
                empgenlbl.Visible = true;

            }
            Con.Close();
        }

        private void ViewEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();  
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            fetchempdata();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("===== Employee Summary =====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(190));
            e.Graphics.DrawString("Employee Id : " + empidlbl.Text+ "\t Employee Name : " + empnamelbl.Text,new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 100));
            e.Graphics.DrawString("Employee Address : " + empaddlbl.Text+ "\t Employee Gender : " + empgenlbl.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 140));
            e.Graphics.DrawString("Employee Position : " + empposlbl.Text+ "\t Date of Birth : " + empdoblbl.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 180));
            e.Graphics.DrawString("Employee Phone : " + emppholbl.Text+ "\t Employee Education : " + empedulbl.Text, new Font("Century Gothic", 15, FontStyle.Regular), Brushes.Blue, new Point(10, 220));

            e.Graphics.DrawString("===== Employee Soft =====", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Red, new Point(190,280));
        }
    }
}
