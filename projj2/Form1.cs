using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projj2
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

        private void button1_Click(object sender, EventArgs e)
        {
            string task = textBox1.Text;
            if (!string.IsNullOrEmpty(task) )
            {
                listBox1.Items.Add(task);
                textBox1.Clear();
                textBox1.Focus();
            } else
            {
                MessageBox.Show("enter task todo");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedTask = listBox1.SelectedIndex;
            if (selectedTask != -1)
            {
                listBox1.Items.RemoveAt(selectedTask); 
            } else
            {
                MessageBox.Show("выбери что убрать");
            }
        }
    }
}
