﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            int c;
            c = a + b;
            textBox3.Text = c.ToString();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            int c;
            c = a - b;
            textBox3.Text = c.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            int c ;
            c = a * b;
            textBox3.Text = c.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Int16.Parse(textBox1.Text);
            int b = Int16.Parse(textBox2.Text);
            int c;
            c = a / b;
            textBox3.Text = c.ToString();
        }
    }
}
