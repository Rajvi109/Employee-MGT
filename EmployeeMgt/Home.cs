﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void employee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ViewEmployee Vemp = new ViewEmployee();
            Vemp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ViewEmployee Vemp = new ViewEmployee();
            Vemp.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.Show();
            this.Hide();

        }
    }
}
