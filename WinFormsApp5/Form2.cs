using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Альбом");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Оборудование");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Активы");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CRM");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выход");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Событие");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отчет");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Собрание");
        }
    }
}
