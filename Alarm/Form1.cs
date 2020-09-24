using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour.ToString();
            label2.Text = DateTime.Now.Minute.ToString();

            if(label1.Text==comboBox1.Text && label2.Text==comboBox2.Text)
            {
                timer1.Enabled = false; //durdurmamız gerekiyor yoksa timer devam eder.
                axWindowsMediaPlayer1.URL = "C:\\Users\\Eren\\Desktop\\1.mp3";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 00; i < 24; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int j = 00; j < 60; j++)
            {
                comboBox2.Items.Add(j);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
