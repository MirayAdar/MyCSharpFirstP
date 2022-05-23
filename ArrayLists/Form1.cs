using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayLists
{
    public partial class Form1 : Form
    {
        List<String> students; 
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            students.Add(tbxStudentN.Text);
            lbxStudentList.Items.Clear();
            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbxStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            students = new List<String>() { "Miray", "Ata", "Muco" };

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }
    }
}
