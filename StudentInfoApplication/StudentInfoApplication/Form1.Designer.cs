namespace StudentInfoApplication
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
            StudentID = new TextBox();
            Lname = new TextBox();
            Fname = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 0;
            label1.Text = "Student ID *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 11);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 10);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 2;
            label3.Text = "First name *";
            // 
            // StudentID
            // 
            StudentID.Location = new Point(12, 30);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(153, 23);
            StudentID.TabIndex = 3;
            StudentID.TextChanged += StudentID_TextChanged;
            // 
            // Lname
            // 
            Lname.Location = new Point(171, 30);
            Lname.Name = "Lname";
            Lname.Size = new Size(153, 23);
            Lname.TabIndex = 4;
            Lname.TextChanged += Lname_TextChanged;
            // 
            // Fname
            // 
            Fname.Location = new Point(330, 30);
            Fname.Name = "Fname";
            Fname.Size = new Size(153, 23);
            Fname.TabIndex = 5;
            Fname.TextChanged += Fname_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(90, 16);
            label4.TabIndex = 6;
            label4.Text = "Student ID List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(171, 109);
            label5.Name = "label5";
            label5.Size = new Size(92, 16);
            label5.TabIndex = 7;
            label5.Text = "First Name List";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(334, 109);
            label6.Name = "label6";
            label6.Size = new Size(90, 16);
            label6.TabIndex = 8;
            label6.Text = "Last Name List";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(400, 58);
            button1.Name = "button1";
            button1.Size = new Size(83, 30);
            button1.TabIndex = 9;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 164);
            listBox1.TabIndex = 10;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(171, 129);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(145, 164);
            listBox2.TabIndex = 11;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(334, 129);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(145, 164);
            listBox3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MistyRose;
            ClientSize = new Size(497, 317);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Fname);
            Controls.Add(Lname);
            Controls.Add(StudentID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Student Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox StudentID;
        private TextBox Lname;
        private TextBox Fname;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
    }
}
