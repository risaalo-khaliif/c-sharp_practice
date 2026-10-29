using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigmentfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_file_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "Students.txt";
                StreamWriter fileWriter = File.CreateText(filename);

                fileWriter.WriteLine("Student ID: 101 - Ali Farah");
                fileWriter.WriteLine("Student ID: 102 - Sahra Ahmed");
                fileWriter.WriteLine("Student ID: 103 - Mohamed Noor");
                fileWriter.Close();

                MessageBox.Show("Students.txt file was generated!");
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occurred: " + err.Message);
            }
        }

       
        private void btn_delete_item_in_file_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedItem != null)
                {
                    listBox1.Items.Remove(listBox1.SelectedItem);

             
                    StreamWriter updateWriter = File.CreateText("Students.txt");
                    for (int idx = 0; idx < listBox1.Items.Count; idx++)
                    {
                        updateWriter.WriteLine(listBox1.Items[idx].ToString());
                    }
                    updateWriter.Close();

                    MessageBox.Show("Record removed successfully.");
                }
                else
                {
                    MessageBox.Show("Select an item first to delete!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occurred: " + err.Message);
            }
        }

        private void btn_remove_file_Click(object sender, EventArgs e)
        {
            try
            {
                string targetFile = "Students.txt";

                if (File.Exists(targetFile))
                {
                    File.Delete(targetFile);
                    listBox1.Items.Clear();
                    MessageBox.Show("The entire file was deleted successfully!");
                }
                else
                {
                    MessageBox.Show("File already removed or not found.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occurred: " + err.Message);
            }
        }

        private void btn_read_file_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "Students.txt";
                StreamWriter fileWriter = File.CreateText(filename);

                fileWriter.WriteLine("Student ID: 101 - Ali Farah");
                fileWriter.WriteLine("Student ID: 102 - Sahra Ahmed");
                fileWriter.WriteLine("Student ID: 103 - Mohamed Noor");
                fileWriter.Close();

                MessageBox.Show("Students.txt file was generated!");
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occurred: " + err.Message);
            }
        }
    }
}
