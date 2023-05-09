
namespace EmployeeMgt
{
    partial class ViewEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.empgenlbl = new System.Windows.Forms.Label();
            this.empedulbl = new System.Windows.Forms.Label();
            this.empdoblbl = new System.Windows.Forms.Label();
            this.empnamelbl = new System.Windows.Forms.Label();
            this.emppholbl = new System.Windows.Forms.Label();
            this.empposlbl = new System.Windows.Forms.Label();
            this.empaddlbl = new System.Windows.Forms.Label();
            this.empidlbl = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.empidsearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.home = new Bunifu.Framework.UI.BunifuThinButton2();
            this.add = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pictureBox1.Location = new System.Drawing.Point(31, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1289, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 32);
            this.label10.TabIndex = 8;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(140, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.empgenlbl);
            this.panel1.Controls.Add(this.empedulbl);
            this.panel1.Controls.Add(this.empdoblbl);
            this.panel1.Controls.Add(this.empnamelbl);
            this.panel1.Controls.Add(this.emppholbl);
            this.panel1.Controls.Add(this.empposlbl);
            this.panel1.Controls.Add(this.empaddlbl);
            this.panel1.Controls.Add(this.empidlbl);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.empidsearch);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 625);
            this.panel1.TabIndex = 10;
            // 
            // empgenlbl
            // 
            this.empgenlbl.AutoSize = true;
            this.empgenlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empgenlbl.ForeColor = System.Drawing.Color.Black;
            this.empgenlbl.Location = new System.Drawing.Point(995, 224);
            this.empgenlbl.Name = "empgenlbl";
            this.empgenlbl.Size = new System.Drawing.Size(251, 32);
            this.empgenlbl.TabIndex = 41;
            this.empgenlbl.Text = "Empoyee Gender";
            this.empgenlbl.Visible = false;
            // 
            // empedulbl
            // 
            this.empedulbl.AutoSize = true;
            this.empedulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empedulbl.ForeColor = System.Drawing.Color.Black;
            this.empedulbl.Location = new System.Drawing.Point(995, 437);
            this.empedulbl.Name = "empedulbl";
            this.empedulbl.Size = new System.Drawing.Size(287, 32);
            this.empedulbl.TabIndex = 40;
            this.empedulbl.Text = "Empoyee Education";
            this.empedulbl.Visible = false;
            // 
            // empdoblbl
            // 
            this.empdoblbl.AutoSize = true;
            this.empdoblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdoblbl.ForeColor = System.Drawing.Color.Black;
            this.empdoblbl.Location = new System.Drawing.Point(995, 328);
            this.empdoblbl.Name = "empdoblbl";
            this.empdoblbl.Size = new System.Drawing.Size(191, 32);
            this.empdoblbl.TabIndex = 39;
            this.empdoblbl.Text = "Date Of Birth";
            this.empdoblbl.Visible = false;
            // 
            // empnamelbl
            // 
            this.empnamelbl.AutoSize = true;
            this.empnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empnamelbl.ForeColor = System.Drawing.Color.Black;
            this.empnamelbl.Location = new System.Drawing.Point(995, 119);
            this.empnamelbl.Name = "empnamelbl";
            this.empnamelbl.Size = new System.Drawing.Size(229, 32);
            this.empnamelbl.TabIndex = 38;
            this.empnamelbl.Text = "Empoyee Name";
            this.empnamelbl.Visible = false;
            // 
            // emppholbl
            // 
            this.emppholbl.AutoSize = true;
            this.emppholbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emppholbl.ForeColor = System.Drawing.Color.Black;
            this.emppholbl.Location = new System.Drawing.Point(378, 437);
            this.emppholbl.Name = "emppholbl";
            this.emppholbl.Size = new System.Drawing.Size(238, 32);
            this.emppholbl.TabIndex = 37;
            this.emppholbl.Text = "Empoyee Phone";
            this.emppholbl.Visible = false;
            // 
            // empposlbl
            // 
            this.empposlbl.AutoSize = true;
            this.empposlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empposlbl.ForeColor = System.Drawing.Color.Black;
            this.empposlbl.Location = new System.Drawing.Point(378, 328);
            this.empposlbl.Name = "empposlbl";
            this.empposlbl.Size = new System.Drawing.Size(261, 32);
            this.empposlbl.TabIndex = 36;
            this.empposlbl.Text = "Empoyee Position";
            this.empposlbl.Visible = false;
            // 
            // empaddlbl
            // 
            this.empaddlbl.AutoSize = true;
            this.empaddlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empaddlbl.ForeColor = System.Drawing.Color.Black;
            this.empaddlbl.Location = new System.Drawing.Point(378, 224);
            this.empaddlbl.Name = "empaddlbl";
            this.empaddlbl.Size = new System.Drawing.Size(261, 32);
            this.empaddlbl.TabIndex = 35;
            this.empaddlbl.Text = "Empoyee Address";
            this.empaddlbl.Visible = false;
            // 
            // empidlbl
            // 
            this.empidlbl.AutoSize = true;
            this.empidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empidlbl.ForeColor = System.Drawing.Color.Black;
            this.empidlbl.Location = new System.Drawing.Point(378, 119);
            this.empidlbl.Name = "empidlbl";
            this.empidlbl.Size = new System.Drawing.Size(175, 32);
            this.empidlbl.TabIndex = 34;
            this.empidlbl.Text = "Empoyee Id";
            this.empidlbl.Visible = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "SEARCH";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(741, 6);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(116, 46);
            this.bunifuThinButton21.TabIndex = 33;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // empidsearch
            // 
            this.empidsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empidsearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.empidsearch.ForeColor = System.Drawing.Color.OrangeRed;
            this.empidsearch.HintForeColor = System.Drawing.Color.Empty;
            this.empidsearch.HintText = "";
            this.empidsearch.isPassword = false;
            this.empidsearch.LineFocusedColor = System.Drawing.Color.Brown;
            this.empidsearch.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.empidsearch.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.empidsearch.LineThickness = 3;
            this.empidsearch.Location = new System.Drawing.Point(579, 6);
            this.empidsearch.Margin = new System.Windows.Forms.Padding(4);
            this.empidsearch.Name = "empidsearch";
            this.empidsearch.Size = new System.Drawing.Size(153, 44);
            this.empidsearch.TabIndex = 32;
            this.empidsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.OrangeRed;
            this.label11.Location = new System.Drawing.Point(378, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 32);
            this.label11.TabIndex = 31;
            this.label11.Text = "Empoyee Id";
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
            this.home.Location = new System.Drawing.Point(751, 530);
            this.home.Margin = new System.Windows.Forms.Padding(5);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(116, 46);
            this.home.TabIndex = 30;
            this.home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.home.Click += new System.EventHandler(this.home_Click);
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
            this.add.ButtonText = "PRINT";
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.SeaGreen;
            this.add.IdleBorderThickness = 1;
            this.add.IdleCornerRadius = 20;
            this.add.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.add.IdleForecolor = System.Drawing.Color.White;
            this.add.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.add.Location = new System.Drawing.Point(437, 530);
            this.add.Margin = new System.Windows.Forms.Padding(5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(116, 46);
            this.add.TabIndex = 27;
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(691, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "Empoyee Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(691, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(287, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "Empoyee Education";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(85, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 32);
            this.label7.TabIndex = 21;
            this.label7.Text = "Empoyee Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(691, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(85, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Empoyee Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(85, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Empoyee Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(691, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Empoyee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(85, 119);
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
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // ViewEmployee
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
            this.Name = "ViewEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            this.Load += new System.EventHandler(this.ViewEmployee_Load);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox empidsearch;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuThinButton2 home;
        private Bunifu.Framework.UI.BunifuThinButton2 add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label empgenlbl;
        private System.Windows.Forms.Label empedulbl;
        private System.Windows.Forms.Label empdoblbl;
        private System.Windows.Forms.Label empnamelbl;
        private System.Windows.Forms.Label emppholbl;
        private System.Windows.Forms.Label empposlbl;
        private System.Windows.Forms.Label empaddlbl;
        private System.Windows.Forms.Label empidlbl;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}