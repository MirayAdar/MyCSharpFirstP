using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student1 = new Student();
            student1.FirstName = "Miray";
            student1.Age = 26;
            student1.Mail = "mirayadar@hotmail.com";
            Student student2 = new Student();
            student2.FirstName = "Vildan";
            student2.Age = 21;
            student2.Mail = "vildanorhan@hotmail.com";

            List<Student> students = new List<Student>() { student1, student2 };

            foreach (var student in students)
            {
                Console.WriteLine(lbxStudentList.Items.Add(student.FirstName));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
