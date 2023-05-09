
namespace EmployeeMgt
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalarySlip = new System.Windows.Forms.RichTextBox();
            this.home = new Bunifu.Framework.UI.BunifuThinButton2();
            this.fatchdata = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Print = new Bunifu.Framework.UI.BunifuThinButton2();
            this.view = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Worked = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpPos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmpName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1282, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Salary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SalarySlip);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.fatchdata);
            this.panel1.Controls.Add(this.Print);
            this.panel1.Controls.Add(this.view);
            this.panel1.Controls.Add(this.Worked);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpPos);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(24, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 625);
            this.panel1.TabIndex = 13;
            // 
            // SalarySlip
            // 
            this.SalarySlip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalarySlip.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalarySlip.ForeColor = System.Drawing.Color.Navy;
            this.SalarySlip.Location = new System.Drawing.Point(624, 56);
            this.SalarySlip.Name = "SalarySlip";
            this.SalarySlip.Size = new System.Drawing.Size(669, 448);
            this.SalarySlip.TabIndex = 31;
            this.SalarySlip.Text = "";
            this.SalarySlip.TextChanged += new System.EventHandler(this.SalarySlip_TextChanged);
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
            this.home.Location = new System.Drawing.Point(201, 458);
            this.home.Margin = new System.Windows.Forms.Padding(5);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(116, 46);
            this.home.TabIndex = 30;
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // fatchdata
            // 
            this.fatchdata.ActiveBorderThickness = 1;
            this.fatchdata.ActiveCornerRadius = 20;
            this.fatchdata.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.fatchdata.ActiveForecolor = System.Drawing.Color.White;
            this.fatchdata.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.fatchdata.BackColor = System.Drawing.Color.White;
            this.fatchdata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fatchdata.BackgroundImage")));
            this.fatchdata.ButtonText = "FATCH DATA";
            this.fatchdata.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fatchdata.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatchdata.ForeColor = System.Drawing.Color.SeaGreen;
            this.fatchdata.IdleBorderThickness = 1;
            this.fatchdata.IdleCornerRadius = 20;
            this.fatchdata.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.fatchdata.IdleForecolor = System.Drawing.Color.White;
            this.fatchdata.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.fatchdata.Location = new System.Drawing.Point(293, 56);
            this.fatchdata.Margin = new System.Windows.Forms.Padding(5);
            this.fatchdata.Name = "fatchdata";
            this.fatchdata.Size = new System.Drawing.Size(169, 44);
            this.fatchdata.TabIndex = 29;
            this.fatchdata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fatchdata.Click += new System.EventHandler(this.fatchdata_Click);
            // 
            // Print
            // 
            this.Print.ActiveBorderThickness = 1;
            this.Print.ActiveCornerRadius = 20;
            this.Print.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Print.ActiveForecolor = System.Drawing.Color.White;
            this.Print.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Print.BackColor = System.Drawing.Color.White;
            this.Print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Print.BackgroundImage")));
            this.Print.ButtonText = "PRINT";
            this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print.ForeColor = System.Drawing.Color.SeaGreen;
            this.Print.IdleBorderThickness = 1;
            this.Print.IdleCornerRadius = 20;
            this.Print.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.Print.IdleForecolor = System.Drawing.Color.White;
            this.Print.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Print.Location = new System.Drawing.Point(913, 539);
            this.Print.Margin = new System.Windows.Forms.Padding(5);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(116, 46);
            this.Print.TabIndex = 28;
            this.Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // view
            // 
            this.view.ActiveBorderThickness = 1;
            this.view.ActiveCornerRadius = 20;
            this.view.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.view.ActiveForecolor = System.Drawing.Color.White;
            this.view.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.view.BackColor = System.Drawing.Color.White;
            this.view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("view.BackgroundImage")));
            this.view.ButtonText = "VIEW";
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.SeaGreen;
            this.view.IdleBorderThickness = 1;
            this.view.IdleCornerRadius = 20;
            this.view.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.view.IdleForecolor = System.Drawing.Color.White;
            this.view.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.view.Location = new System.Drawing.Point(53, 458);
            this.view.Margin = new System.Windows.Forms.Padding(5);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(116, 46);
            this.view.TabIndex = 27;
            this.view.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // Worked
            // 
            this.Worked.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Worked.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Worked.ForeColor = System.Drawing.Color.OrangeRed;
            this.Worked.HintForeColor = System.Drawing.Color.Empty;
            this.Worked.HintText = "";
            this.Worked.isPassword = false;
            this.Worked.LineFocusedColor = System.Drawing.Color.Brown;
            this.Worked.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.Worked.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.Worked.LineThickness = 3;
            this.Worked.Location = new System.Drawing.Point(8, 374);
            this.Worked.Margin = new System.Windows.Forms.Padding(4);
            this.Worked.Name = "Worked";
            this.Worked.Size = new System.Drawing.Size(234, 44);
            this.Worked.TabIndex = 22;
            this.Worked.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(13, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Worked Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(13, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Empoyee Position";
            // 
            // EmpPos
            // 
            this.EmpPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmpPos.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPos.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPos.HintText = "";
            this.EmpPos.isPassword = false;
            this.EmpPos.LineFocusedColor = System.Drawing.Color.Brown;
            this.EmpPos.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.EmpPos.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.EmpPos.LineThickness = 3;
            this.EmpPos.Location = new System.Drawing.Point(8, 269);
            this.EmpPos.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.Size = new System.Drawing.Size(266, 44);
            this.EmpPos.TabIndex = 16;
            this.EmpPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.EmpName.Location = new System.Drawing.Point(8, 160);
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
            this.label3.Location = new System.Drawing.Point(13, 124);
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
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1356, 813);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Salary";
            this.Load += new System.EventHandler(this.Salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox SalarySlip;
        private Bunifu.Framework.UI.BunifuThinButton2 home;
        private Bunifu.Framework.UI.BunifuThinButton2 fatchdata;
        private Bunifu.Framework.UI.BunifuThinButton2 Print;
        private Bunifu.Framework.UI.BunifuThinButton2 view;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Worked;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}