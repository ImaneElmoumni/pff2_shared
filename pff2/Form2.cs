﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pff2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void circleButton15_Click(object sender, EventArgs e)
        {
            int b = 0;
            if (b == 0)
            {


                class11.Visible = true;
                b = 1;
            }
        }

        private void circleButton3_Click(object sender, EventArgs e)
        {

            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void circleButton4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void circleButton2_Click(object sender, EventArgs e)
        {

        }

        private void circleButton5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
    }
}
