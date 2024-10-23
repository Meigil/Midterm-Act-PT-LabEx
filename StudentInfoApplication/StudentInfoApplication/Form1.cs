using StudentInfoApplication;

namespace StudentInfoApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(StudentID.Text, Fname.Text, Lname.Text);

            
            listBox1.Items.Add(student.StudentID);
            listBox2.Items.Add(student.FirstName);
            listBox3.Items.Add(student.LastName);

          
            StudentID.Clear();
            Fname.Clear();
            Lname.Clear();
        }
        public class StudentInfo
        {
           
            private string studentID;
            private string firstName;
            private string lastName;

            
            public StudentInfo() { }

            public StudentInfo(string id, string firstName, string lastName)
            {
                this.studentID = id;
                this.firstName = firstName;
                this.lastName = lastName;
            }

         
            public string StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }
        }

        private void StudentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
