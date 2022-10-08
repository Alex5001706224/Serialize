using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;

namespace Assignment_5._4
{
    public partial class Form1 : Form
    {
        Student student;
        const string filePath = @"D:\应用程序\Visual Studio\PCAD7-Assignment\pcad7Seralize.txt";
        const string filePath1 = @"D:\应用程序\Visual Studio\PCAD7-Assignment\pcad7Seralize.xml";
        const string filePath2 = @"D:\应用程序\Visual Studio\PCAD7-Assignment\pcad7Seralizejson.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btBinary.Enabled = false;
            btDisBinary.Enabled = false;
            btXML.Enabled = false;
            btDesXML.Enabled = false;
            btJSON.Enabled = false;
            btDesJSON.Enabled = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, student);
                MessageBox.Show("Binary serialized successful");
                btDisBinary.Enabled = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream=new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Student temp = (Student)formatter.Deserialize(fileStream);
                MessageBox.Show($"Student ID:{temp.Id} First Name:{temp.FirstName} Last Name:{temp.LastName}");

            }
            catch (Exception ex)
            {

            }
            finally 
            { fileStream.Close(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
                try
            {
                fileStream = new FileStream(filePath2, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Student));
                serializer.WriteObject(fileStream, student);
                MessageBox.Show("JSON Seralized successful");
                btDesJSON.Enabled = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath1, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(fileStream, student);
                MessageBox.Show("XML serialized successful");
                btDesXML.Enabled = true;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            student = new Student();
            student.Id = Int32.Parse(textBox1.Text);
            student.FirstName = textBox2.Text;
            student.LastName = textBox3.Text;
            MessageBox.Show("Student information Created");
            btBinary.Enabled = true;
            btXML.Enabled = true;
            btJSON.Enabled = true;
        }

        private void btDesXML_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Student temp = (Student)soapFormatter.Deserialize(fileStream);
                MessageBox.Show($"Student ID:{temp.Id} First Name:{temp.FirstName} Last Name:{temp.LastName}");

            }
            catch
            {

            }
            finally
            {
                fileStream.Close();
            }
        }

        private void btDesJSON_Click(object sender, EventArgs e)
        {
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(filePath2, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Student));
                Student temp = serializer.ReadObject(fileStream) as Student;
                MessageBox.Show($"Student ID:{temp.Id} First Name:{temp.FirstName}, Last Name:{temp.LastName}");

            }
            catch (Exception ex)
            {

            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}
