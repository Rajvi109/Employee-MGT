using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(UidTb.Text==""||PwdTb.Text=="")
            {
                MessageBox.Show("Enter User Name or Password ");
            }
            else if(UidTb.Text=="admin" && PwdTb.Text=="admin123")
            {
                this.Hide();
                Home home = new Home();
                home.Show(); 

            }
            else
            {
                MessageBox.Show("Wrong User Name or Password ");
            }
        }

        private void UidTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
