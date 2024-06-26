﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleCalculator02
{
    public partial class Form1 : Form
    {
        private MyData _data;

        public Form1()
        {
            InitializeComponent();
            _data = new MyData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculate(false);
        }

        private void Calculate(bool add)
        {
            _data.X = int.Parse(textBox1.Text);
            _data.Y = int.Parse(textBox2.Text);
            if (add)
            {
                label1.Text = _data.Add().ToString();
            }
            else 
            {
                label1.Text = _data.Less().ToString();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = (decimal.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
        }
    }
}
