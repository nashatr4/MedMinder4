﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedMinder4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medMinderDataSet1.Medicine2' table. You can move, or remove it, as needed.
            this.medicine2TableAdapter.Fill(this.medMinderDataSet1.Medicine2);

        }
    }
}