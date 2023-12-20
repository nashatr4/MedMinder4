using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;

namespace MedMinder4
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panel2.Controls.Add(leftBorderBtn);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null) 
            {
                //Button
                currentBtn = (IconButton)senderBtn; 
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            g.Show();
            this.Hide();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
