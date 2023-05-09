
namespace EmployeeMgt
{
    partial class Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.home = new Bunifu.Framework.UI.BunifuThinButton2();
            this.delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmpGen = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EmpEdu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpPho = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpDob = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpPos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpAdd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.edit);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.EmpGen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EmpEdu);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.EmpPho);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpDob);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpPos);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 625);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmpDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpDGV.ColumnHeadersHeight = 25;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDGV.Location = new System.Drawing.Point(617, 20);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersVisible = false;
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.Size = new System.Drawing.Size(671, 572);
            this.EmpDGV.TabIndex = 31;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmpDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.EmpDGV.ThemeStyle.ReadOnly = false;
            this.EmpDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpDGV.ThemeStyle.RowsStyle.Height = 22;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.OrangeRed;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // home
            // 
            this.home.ActiveBorderThickness = 1;
            this.home.ActiveCornerRadius = 20;
            this.home.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.home.ActiveForecolor = System.Drawing.Color.White;
            this.home.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.home.BackColor = System.Drawing.Color.White;
            this.home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("home.BackgroundImage")));
            this.home.ButtonText = "HOME";
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.ForeColor = System.Drawing.Color.SeaGreen;
            this.home.IdleBorderThickness = 1;
            this.home.IdleCornerRadius = 20;
            this.home.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.home.IdleForecolor = System.Drawing.Color.White;
            this.home.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.home.Location = new System.Drawing.Point(437, 458);
            this.home.Margin = new System.Windows.Forms.Padding(5);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(116, 46);
            this.home.TabIndex = 30;
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // delete
            // 
            this.delete.ActiveBorderThickness = 1;
            this.delete.ActiveCornerRadius = 20;
            this.delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.delete.ActiveForecolor = System.Drawing.Color.White;
            this.delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.delete.BackColor = System.Drawing.Color.White;
            this.delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delete.BackgroundImage")));
            this.delete.ButtonText = "DELETE";
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.delete.IdleBorderThickness = 1;
            this.delete.IdleCornerRadius = 20;
            this.delete.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.delete.IdleForecolor = System.Drawing.Color.White;
            this.delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.delete.Location = new System.Drawing.Point(305, 458);
            this.delete.Margin = new System.Windows.Forms.Padding(5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(116, 46);
            this.delete.TabIndex = 29;
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.ActiveBorderThickness = 1;
            this.edit.ActiveCornerRadius = 20;
            this.edit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.edit.ActiveForecolor = System.Drawing.Color.White;
            this.edit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.edit.BackColor = System.Drawing.Color.White;
            this.edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("edit.BackgroundImage")));
            this.edit.ButtonText = "EDIT";
            this.edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.edit.IdleBorderThickness = 1;
            this.edit.IdleCornerRadius = 20;
            this.edit.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.edit.IdleForecolor = System.Drawing.Color.White;
            this.edit.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.edit.Location = new System.Drawing.Point(179, 458);
            this.edit.Margin = new System.Windows.Forms.Padding(5);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(116, 46);
            this.edit.TabIndex = 28;
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // add
            // 
            this.add.ActiveBorderThickness = 1;
            this.add.ActiveCornerRadius = 20;
            this.add.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.add.ActiveForecolor = System.Drawing.Color.White;
            this.add.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.ButtonText = "ADD";
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.SeaGreen;
            this.add.IdleBorderThickness = 1;
            this.add.IdleCornerRadius = 20;
            this.add.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.add.IdleForecolor = System.Drawing.Color.White;
            this.add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.add.Location = new System.Drawing.Point(53, 458);
            this.add.Margin = new System.Windows.Forms.Padding(5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(116, 46);
            this.add.TabIndex = 27;
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // EmpGen
            // 
            this.EmpGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpGen.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpGen.FormattingEnabled = true;
            this.EmpGen.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.EmpGen.Location = new System.Drawing.Point(330, 174);
            this.EmpGen.Name = "EmpGen";
            this.EmpGen.Size = new System.Drawing.Size(245, 30);
            this.EmpGen.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(324, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "Empoyee Gender";
           
            // 
            // EmpEdu
            // 
            this.EmpEdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpEdu.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpEdu.FormattingEnabled = true;
            this.EmpEdu.Items.AddRange(new object[] {
            "Mca",
            "Bca",
            "Mcom",
            "Bcom",
            "Bsc",
            "Msc"});
            this.EmpEdu.Location = new System.Drawing.Point(330, 387);
            this.EmpEdu.Name = "EmpEdu";
            this.EmpEdu.Size = new System.Drawing.Size(245, 30);
            this.EmpEdu.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(324, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "Empoyee Education";
           
            // 
            // EmpPho
            // 
            this.EmpPho.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPho.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpPho.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPho.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPho.HintText = "";
            this.EmpPho.isPassword = false;
            this.EmpPho.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpPho.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpPho.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpPho.LineThickness = 3;
            this.EmpPho.Location = new System.Drawing.Point(8, 374);
            this.EmpPho.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPho.Name = "EmpPho";
            this.EmpPho.Size = new System.Drawing.Size(234, 44);
            this.EmpPho.TabIndex = 22;
            this.EmpPho.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                       // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(13, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Empoyee Phone";
            
            // 
            // EmpDob
            // 
            this.EmpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDob.Location = new System.Drawing.Point(330, 278);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.Size = new System.Drawing.Size(214, 28);
            this.EmpDob.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(324, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date Of Birth";
            
            // 
            // EmpPos
            // 
            this.EmpPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPos.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPos.FormattingEnabled = true;
            this.EmpPos.Items.AddRange(new object[] {
            "Manager",
            "Juniour Developer",
            "Seniour Developer",
            "Accountant"});
            this.EmpPos.Location = new System.Drawing.Point(19, 278);
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.Size = new System.Drawing.Size(245, 30);
            this.EmpPos.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(13, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Empoyee Position";
         
            // 
            // EmpAdd
            // 
            this.EmpAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpAdd.HintForeColor = System.Drawing.Color.Empty;
            this.EmpAdd.HintText = "";
            this.EmpAdd.isPassword = false;
            this.EmpAdd.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpAdd.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpAdd.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpAdd.LineThickness = 3;
            this.EmpAdd.Location = new System.Drawing.Point(-2, 161);
            this.EmpAdd.Margin = new System.Windows.Forms.Padding(4);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.Size = new System.Drawing.Size(266, 44);
            this.EmpAdd.TabIndex = 16;
            this.EmpAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(3, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Empoyee Address";
            
            // 
            // EmpName
            // 
            this.EmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpName.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpName.HintForeColor = System.Drawing.Color.Empty;
            this.EmpName.HintText = "";
            this.EmpName.isPassword = false;
            this.EmpName.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpName.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpName.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpName.LineThickness = 3;
            this.EmpName.Location = new System.Drawing.Point(319, 56);
            this.EmpName.Margin = new System.Windows.Forms.Padding(4);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(234, 44);
            this.EmpName.TabIndex = 14;
            this.EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(324, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Empoyee Name";
            
            // 
            // EmpId
            // 
            this.EmpId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpId.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpId.HintForeColor = System.Drawing.Color.Empty;
            this.EmpId.HintText = "";
            this.EmpId.isPassword = false;
            this.EmpId.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpId.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpId.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpId.LineThickness = 3;
            this.EmpId.Location = new System.Drawing.Point(4, 56);
            this.EmpId.Margin = new System.Windows.Forms.Padding(4);
            this.EmpId.Name = "EmpId";
            this.EmpId.Size = new System.Drawing.Size(234, 44);
            this.EmpId.TabIndex = 12;
            this.EmpId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Empoyee Id";
            
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1309, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 32);
            this.label10.TabIndex = 5;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1356, 813);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpId;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox EmpPos;
        private System.Windows.Forms.DateTimePicker EmpDob;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EmpGen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox EmpEdu;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPho;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 home;
        private Bunifu.Framework.UI.BunifuThinButton2 delete;
        private Bunifu.Framework.UI.BunifuThinButton2 edit;
        private Bunifu.Framework.UI.BunifuThinButton2 add;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}