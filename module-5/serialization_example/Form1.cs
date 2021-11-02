using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace serialization_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            //Values taken from textboxes
            Student objStudent = new Student {
                Name = txtName.Text,
                Department = txtDepartment.Text,
                College = txtCollege.Text
            };

            //XML Serialization
            XmlSerializer xs = new XmlSerializer(typeof(Student));

            //Creating a stream
            FileStream fs = new FileStream(@"D:\student.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            //Passing serialized object in the stream
            xs.Serialize(fs, objStudent);
            lblStatus.Text = "Object Serialized";


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            //Values taken from textboxes
            Student objStudent = new Student();

            //XML Deserialization
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            //Creating a stream
            FileStream fs = new FileStream(@"D:\student.xml", FileMode.Open, FileAccess.Read, FileShare.None);
            //Desirializing object
            objStudent = (Student)xs.Deserialize(fs);
            lblStatus.Text = "Object Deserialized";

            //Showing values from deserialization into textboxes
            txtName.Text = objStudent.Name;
            txtDepartment.Text = objStudent.Department;
            txtCollege.Text = objStudent.College;








        }
    }
}
