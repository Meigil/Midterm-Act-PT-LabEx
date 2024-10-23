namespace EmployeeApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblBasicSalary = new Label();
            txtFirstName = new TextBox();
            txtDepartment = new TextBox();
            txtLastName = new TextBox();
            txtJobTitle = new TextBox();
            txtRatePerHour = new TextBox();
            txtTotalHoursWorked = new TextBox();
            ComputeSalary = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 18);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(86, 18);
            label2.TabIndex = 1;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(231, 9);
            label3.Name = "label3";
            label3.Size = new Size(77, 18);
            label3.TabIndex = 2;
            label3.Text = "Last name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(231, 64);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 3;
            label4.Text = "Job title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 147);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 4;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(231, 147);
            label6.Name = "label6";
            label6.Size = new Size(133, 18);
            label6.TabIndex = 5;
            label6.Text = "Total hours worked";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(14, 243);
            label7.Name = "label7";
            label7.Size = new Size(82, 18);
            label7.TabIndex = 6;
            label7.Text = "First name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 273);
            label8.Name = "label8";
            label8.Size = new Size(82, 18);
            label8.TabIndex = 7;
            label8.Text = "Last name:";
            // 
            // lblBasicSalary
            // 
            lblBasicSalary.AutoSize = true;
            lblBasicSalary.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBasicSalary.Location = new Point(12, 302);
            lblBasicSalary.Name = "lblBasicSalary";
            lblBasicSalary.Size = new Size(90, 18);
            lblBasicSalary.TabIndex = 8;
            lblBasicSalary.Text = "Basic Salary:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 38);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(213, 23);
            txtFirstName.TabIndex = 9;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(12, 85);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(213, 23);
            txtDepartment.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(231, 38);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(196, 23);
            txtLastName.TabIndex = 11;
            // 
            // txtJobTitle
            // 
            txtJobTitle.Location = new Point(231, 85);
            txtJobTitle.Name = "txtJobTitle";
            txtJobTitle.Size = new Size(196, 23);
            txtJobTitle.TabIndex = 12;
            // 
            // txtRatePerHour
            // 
            txtRatePerHour.Location = new Point(14, 168);
            txtRatePerHour.Name = "txtRatePerHour";
            txtRatePerHour.Size = new Size(211, 23);
            txtRatePerHour.TabIndex = 13;
            // 
            // txtTotalHoursWorked
            // 
            txtTotalHoursWorked.Location = new Point(231, 168);
            txtTotalHoursWorked.Name = "txtTotalHoursWorked";
            txtTotalHoursWorked.Size = new Size(196, 23);
            txtTotalHoursWorked.TabIndex = 14;
            // 
            // ComputeSalary
            // 
            ComputeSalary.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComputeSalary.Location = new Point(168, 206);
            ComputeSalary.Name = "ComputeSalary";
            ComputeSalary.Size = new Size(130, 28);
            ComputeSalary.TabIndex = 15;
            ComputeSalary.Text = "Compute Salary";
            ComputeSalary.UseVisualStyleBackColor = true;
            ComputeSalary.Click += ComputeSalary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 333);
            Controls.Add(ComputeSalary);
            Controls.Add(txtTotalHoursWorked);
            Controls.Add(txtRatePerHour);
            Controls.Add(txtJobTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtDepartment);
            Controls.Add(txtFirstName);
            Controls.Add(lblBasicSalary);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblBasicSalary;
        private TextBox txtFirstName;
        private TextBox txtDepartment;
        private TextBox txtLastName;
        private TextBox txtJobTitle;
        private TextBox txtRatePerHour;
        private TextBox txtTotalHoursWorked;
        private Button ComputeSalary;
    }
}
